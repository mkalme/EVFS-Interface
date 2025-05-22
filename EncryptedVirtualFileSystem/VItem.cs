using System;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;

namespace EncryptedVirtualFileSystem {
    public class VItem : INotifyPropertyChanged {
        private string _name;
        public string Name { 
            get { return _name; }
            set {
                if (_name != value) {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private DateTime _creationDate;
        public DateTime CreationDate {
            get { return _creationDate; }
            set {
                if (_creationDate != value) {
                    _creationDate = value;
                    OnPropertyChanged("CreationDate");
                }
            }
        }

        internal VDirectory _parent = null;
        public VDirectory Parent { get { return _parent; } }

        public VItem(string name) {
            _name = name;
            _creationDate = DateTime.Now;
        }
        public VItem(string name, DateTime creationDate) {
            _name = name;
            _creationDate = creationDate;
        }

        public virtual List<byte> SaveToBytes() {
            return new List<byte>();
        }
        protected List<byte> GetHeaderBytes() {
            List<byte> bytes = new List<byte>();

            byte[] nameBytes = Encoding.UTF8.GetBytes(Name);
            byte[] creationDateBytes = BitConverter.GetBytes(CreationDate.Ticks);

            bytes.Add((byte)nameBytes.Length);
            bytes.AddRange(nameBytes);
            bytes.AddRange(creationDateBytes);

            return bytes;
        }
        public static VItem LoadFromBytes(byte[] bytes, ref int index) {
            if (bytes[index] == 0) {
                return VDirectory.LoadFromBytes(bytes, ref index);
            } else if (bytes[index] == 1) {
                return VFile.LoadFromBytes(bytes, ref index);
            }

            return null;
        }

        public virtual VItem Clone() {
            return null;
        }
        public virtual int GetSize() {
            return 0;
        }

        //PropertyChangeEventHandler
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
    public enum PropertyType { 
        Name,
        CreationDate,
        LastModified,
        Bytes
    }
}
