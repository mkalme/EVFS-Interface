using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace EncryptedVirtualFileSystem {
    public class VDirectory : VItem , INotifyPropertyChanged {
        private List<VItem> _children = new List<VItem>();
        public IList<VItem> Children { get { return _children.AsReadOnly(); } }

        public VDirectory(string name) : base(name){
            _children = new List<VItem>();
        }
        public VDirectory(string name, DateTime creationDate) : base(name, creationDate) {
            _children = new List<VItem>();
        }

        public override List<byte> SaveToBytes()
        {
            List<byte> bytes = new List<byte>() { 0 };

            bytes.AddRange(GetHeaderBytes());
            bytes.AddRange(BitConverter.GetBytes((short)(_children.Count)));

            for (int i = 0; i < _children.Count; i++) {
                bytes.AddRange(_children[i].SaveToBytes());
            }

            return bytes;
        }

        public static new VDirectory LoadFromBytes(byte[] bytes, ref int index) {
            index++;

            string name = LoadHelper.GetName(bytes, ref index);
            DateTime creationDate = LoadHelper.GetDate(bytes, ref index);

            VDirectory directory = new VDirectory(name, creationDate);

            short count = BitConverter.ToInt16(bytes, index);
            index += 2;

            for (int i = 0; i < count; i++) {
                VItem item = VItem.LoadFromBytes(bytes, ref index);

                directory.AppendChild(item);
            }

            return directory;
        }

        public void AppendChild(VItem item) {
            item._parent = this;
            item.PropertyChanged += _contentsChanged;

            _children.Add(item);

            OnContentsChanged("OnContentsChanged");
        }

        public void RemoveFile(string name) {
            for (int i = 0; i < _children.Count; i++) {
                VItem item = _children[i];
                if (item.GetType() == typeof(VFile)) {
                    if (item.Name == name) {
                        _children.RemoveAt(i);
                        OnContentsChanged("RemoveFile");
                        
                        return;
                    }
                }
            }
        }
        public void RemoveDirectory(string name) {
            for (int i = 0; i < _children.Count; i++) {
                VItem item = _children[i];
                if (item.GetType() == typeof(VDirectory)) {
                    if (item.Name == name) {
                        _children.RemoveAt(i);
                        ((VDirectory)item).Remove(this);
                        OnContentsChanged("RemoveDirectory");

                        return;
                    }
                }
            }
        }
        public void RemoveAllChildren() {
            _children.Clear();

            OnContentsChanged("RemoveAllChildren");
        }

        public bool FileExists(string name) {
            foreach (VItem item in _children) {
                if (item.GetType() == typeof(VFile)) {
                    if (item.Name == name) return true;
                }
            }

            return false;
        }
        public bool DirectoryExists(string name) {
            foreach (VItem item in _children) {
                if (item.GetType() == typeof(VDirectory)) {
                    if (item.Name == name) return true;
                }
            }

            return false;
        }
        private bool SpecificItemExists(Type type, string name)
        {
            foreach (VItem item in _children) {
                if (item.GetType() == type) {
                    if (item.Name == name) return true;
                }
            }

            return false;
        }

        public override VItem Clone() {
            VDirectory directory = new VDirectory(Name);

            directory.CreationDate = CreationDate;
            for (int i = 0; i < _children.Count; i++) {
                VItem clone = _children[i].Clone();

                directory.AppendChild(clone);
            }
            directory._parent = _parent;

            return directory;
        }
        public void Paste(VItem item) {
            VItem clone = item.Clone();
            clone.Name = GetName(clone);

            if (clone.GetType() == typeof(VDirectory)) {
                ((VDirectory)clone).CreationDate = DateTime.Now;
            } else if (clone.GetType() == typeof(VFile)) {
                ((VFile)clone).LastModified = DateTime.Now;
            }

            AppendChild(clone);
        }

        private string GetName(VItem item) {
            string name = item.Name;
            string noExtension = Path.GetFileNameWithoutExtension(name);
            string extension = Path.GetExtension(name);

            Type type = item.GetType();

            bool exists = SpecificItemExists(type, name);
            while (exists) {
                noExtension += " - copy";
                name = noExtension + extension;

                exists = SpecificItemExists(type, name);
            }

            return name;
        }
        public string GetDirectoryName(string name) {
            List<VDirectory> directories = GetAllDirectories();

            string newName = name;
            int iteration = 2;

            bool exists = true;
            do {
                exists = directories.Any(item => item.Name == newName);

                if (exists) {
                    newName = string.Format("{0} ({1})", name, iteration);
                    iteration++;
                }
            } while (exists);

            return newName;
        }
        public string GetFileName(string name)
        {
            List<VFile> files = GetAllFiles();

            string newName = name;
            int iteration = 2;

            bool exists = true;
            do {
                exists = files.Any(item => item.Name == newName);

                if (exists) {
                    newName = string.Format("{0} ({1})", name, iteration);
                    iteration++;
                }
            } while (exists);

            return newName;
        }

        public List<VDirectory> GetAllDirectories() {
            List<VDirectory> directories = new List<VDirectory>();

            foreach (var item in _children) {
                if (item.GetType() == typeof(VDirectory)) {
                    directories.Add((VDirectory)item);
                }
            }

            return directories;
        }
        public List<VFile> GetAllFiles() {
            List<VFile> directories = new List<VFile>();

            foreach (var item in _children) {
                if (item.GetType() == typeof(VFile)) {
                    directories.Add((VFile)item);
                }
            }

            return directories;
        }

        public override int GetSize() {
            int length = 0;

            foreach (var item in _children) {
                length += item.GetSize();
            }

            return length;
        }
        public int GetCountOfSubDirectories() {
            int sub = 0;

            foreach (var item in _children) {
                if (item.GetType() == typeof(VDirectory)) {
                    sub++;
                    sub += ((VDirectory)item).GetCountOfSubDirectories();
                }
            }

            return sub;
        }
        public int GetCountOfSubFiles()
        {
            int sub = 0;

            foreach (var item in _children) {
                if (item.GetType() == typeof(VDirectory)) {
                    sub += ((VDirectory)item).GetCountOfSubFiles();
                } else if (item.GetType() == typeof(VFile)) {
                    sub++;
                }
            }

            return sub;
        }

        public bool ContainsFiles() {
            return _children.OfType<VFile>().Any();
        }
        public bool ContainsDirectories()
        {
            return _children.OfType<VDirectory>().Any();
        }

        private void Remove(VDirectory closestDir)
        {
            OnRemoved(closestDir);
        }


        //PropertyChangeEventHandler
        private event PropertyChangedEventHandler _contentsChanged;
        public event PropertyChangedEventHandler ContentsChanged {
            add {
                _contentsChanged += value;
                foreach (var item in _children) {
                    item.PropertyChanged += value;
                }
            }
            remove {
                _contentsChanged -= value;
                foreach (var item in _children) {
                    item.PropertyChanged -= value;
                }
            }
        }

        protected void OnContentsChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = _contentsChanged;
            if (handler != null)
                handler(this, e);
        }
        protected void OnContentsChanged(string propertyName)
        {
            OnContentsChanged(new PropertyChangedEventArgs(propertyName));
        }

        //RemoveEventHandler
        public event EventHandler Removed;
        protected void OnRemoved(VDirectory closestDir)
        {
            EventHandler handler = Removed;
            if (handler != null)
                handler(closestDir, EventArgs.Empty);
        }
    }
}
