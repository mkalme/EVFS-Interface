using System;
using System.Collections.Generic;
using System.ComponentModel;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace FileExplorer {
    class FileExplorerProfile {
        public EVFSManager Manager { get; set; }
        
        public List<FileExplorerPlace> PlacePaths { get; set; }
        public FileExplorerPlace CurrentPlace { 
            get {
                if (ViewIndex >= PlacePaths.Count) return null;
                return PlacePaths[ViewIndex];
            } 
        }

        private FileExplorerView _view;
        public FileExplorerView View {
            get { return _view; }
            set {
                _view = value;
                OnUpdate();
            }
        }
        public int ViewIndex = -1;

        public FileExplorerProfile(EVFSManager manager, VDirectory directory) {
            Manager = manager;
            PlacePaths = new List<FileExplorerPlace>();

            OpenDirectory(directory);
        }

        public void GoBack() {
            if (ViewIndex == 0) return;

            ViewIndex--;

            FileExplorerView view = new FileExplorerView(CurrentPlace);
            View = view;
        }
        public void GoForward() {
            if (ViewIndex >= PlacePaths.Count - 1) return;
            
            ViewIndex++;

            FileExplorerView view = new FileExplorerView(CurrentPlace);
            View = view;
        }
        public void GoUp(){
            VDirectory parent = CurrentPlace.Directory.Parent;

            if (parent != null) {
                OpenDirectory(parent);
            }
        }
        public void OpenDirectory(VDirectory directory) {
            directory.PropertyChanged -= OnDirectoryContent_Change;
            directory.ContentsChanged -= OnDirectoryContent_Change;
            directory.Removed -= OnDirectoryRemove;

            directory.PropertyChanged += new PropertyChangedEventHandler(OnDirectoryContent_Change);
            directory.ContentsChanged += new PropertyChangedEventHandler(OnDirectoryContent_Change);
            directory.Removed += new EventHandler(OnDirectoryRemove);

            if (ViewIndex == -1) { // If new
                PlacePaths.Add(new FileExplorerPlace(directory));
                GoForward();

                return;
            }
            if (ViewIndex >= PlacePaths.Count - 1) { // If at the end of path, then just add.
                PlacePaths.Add(new FileExplorerPlace(directory));
                GoForward();

                return;
            }
            if (PlacePaths[ViewIndex + 1].Directory.Name == directory.Name) { // If on path, then just go.
                GoForward();

                return;
            } else { // Remove all places forward and add.
                PlacePaths.RemoveRange(ViewIndex + 1, PlacePaths.Count - ViewIndex - 1);

                PlacePaths.Add(new FileExplorerPlace(directory));
                GoForward();

                return;
            }
        }

        private void ClearPath(VDirectory directory) {
            PlacePaths.Clear();
            ViewIndex = -1;

            OpenDirectory(directory);
        }

        //View update event handler
        public event EventHandler Update;
        private void OnUpdate()
        {
            if (Update != null) {
                Update(this, EventArgs.Empty);
            }
        }
        private void OnDirectoryContent_Change(object sender, EventArgs e)
        {
            View = new FileExplorerView(CurrentPlace);
        }
        private void OnDirectoryRemove(object sender, EventArgs e) {
            VDirectory dir = (VDirectory)sender;

            ClearPath(dir);
        }
    }
    class FileExplorerView {
        private FileExplorerPlace Place { get; set; }
        public VDirectory Directory { get; set; }
        public Dictionary<int, VItem> Items { get; set; }
        public ItemSelection SelectedItem {
            get { return Place.SelectedItem; }
            set { Place.SelectedItem = value;}
        }

        public FileExplorerView(FileExplorerPlace place) {
            Place = place;
            Directory = place.Directory;
            Items = new Dictionary<int, VItem>();
            SelectedItem = place.SelectedItem;

            Update();
        }

        public void Update() {
            Items.Clear();

            for (int i = 0; i < Directory.Children.Count; i++) {
                Items.Add(i, Directory.Children[i]);
            }
        }
        public void SelectItem(VItem item) {
            if (item == null) {
                Place.SelectedItem = null;
            } else {
                Place.SelectedItem = new ItemSelection(item);
            }
        }
        public int GetItemIndex(VItem item) {
            if (item == null) return -1;

            return GetItemIndex(item.Name, item.GetType());
        }
        public int GetSelectedItemIndex() {
            if (SelectedItem == null) return -1;

            return GetItemIndex(SelectedItem.Name, SelectedItem.Type);
        }

        private int GetItemIndex(string name, Type type) {
            foreach (var keyPair in Items) {
                VItem value = keyPair.Value;

                if (value.Name != name) {
                    continue;
                }

                if (value.GetType() == type) {
                    return keyPair.Key;
                }
            }

            return -1;
        }
    }
    class FileExplorerPlace {
        public VDirectory Directory { get; set; }
        public ItemSelection SelectedItem { get; set; }

        public FileExplorerPlace(VDirectory directory) {
            Directory = directory;
        }
    }
    class ItemSelection {
        public string Name { get; set; }
        public Type Type;

        public ItemSelection(VItem item) {
            Name = item.Name;
            Type = item.GetType();
        }
    }
}
