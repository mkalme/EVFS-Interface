using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace FileExplorer {
    public partial class FileExplorerPanel : UserControl {
        private FileExplorerProfile Profile { get; set; }
        private int SelectedIndex {
            get {
                if (ExplorerDataGrid.SelectedRows.Count == 0) return -1;
                return int.Parse(ExplorerDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private VItem SelectedItem {
            get {
                int index = SelectedIndex;
                if (index > -1) return Profile.View.Items[index];
                else return null;
            }
        }

        public FileExplorerPanel(EVFSManager manager, VDirectory directory)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            ExplorerDataGrid.DoubleBuffered(true);

            ExplorerGridMenuStrip.Renderer = new MyToolStripRenderer();
            NewStripSeperator.Paint += ExtensionMethods.StripSeparator_Paint;
            PasteStripSeperator.Paint += ExtensionMethods.StripSeparator_Paint;
            DeleteStripSeperator.Paint += ExtensionMethods.StripSeparator_Paint;

            Profile = new FileExplorerProfile(manager, directory);
            Profile.Update += new EventHandler(Profile_Update);

            DisplayView(Profile.View);
        }

        //Event Handlers
        public event EventHandler DirectoryOpen;
        public event EventHandler ItemClick;
        public event EventHandler ItemDoubleClick;
        private void OnDirectoryOpen(VDirectory directory){
            if (DirectoryOpen != null)
                DirectoryOpen.Invoke(directory, EventArgs.Empty);
        }
        private void OnItemClick(VItem item)
        {
            if (ItemClick != null)
                ItemClick.Invoke(item, EventArgs.Empty);
        }
        private void OnItemDoubleClick(VItem item) {
            if (ItemDoubleClick != null)
                ItemDoubleClick.Invoke(item, EventArgs.Empty);
        }

        //Display
        private void DisplayView(FileExplorerView view)
        {
            LoadDataGrid(view);
            SetPathPanel(Profile, view.Directory);
        }

        private void LoadDataGrid(FileExplorerView view)
        {
            CanUpdate = false;

            ExplorerDataGrid.Rows.Clear();

            for (int i = 0; i < view.Items.Count; i++) {
                int index = view.Items.ElementAt(i).Key;
                VItem item = view.Items.ElementAt(i).Value;

                if (item.GetType() == typeof(VFile)) {
                    VFile file = (VFile)item;

                    ExplorerDataGrid.Rows.Add(
                        index,
                        Profile.Manager.GetFileIcon(file),
                        file.Name,
                        ViewHelper.ParseDate(file.LastModified),
                        ViewHelper.GetTypeDescription(Profile.Manager, file),
                        ViewHelper.ParseSize(file.Bytes.Length));

                    ExplorerDataGrid.Rows[i].Cells[1].Style.Padding = new Padding(4, 2, 0, 2);
                } else {
                    VDirectory dir = (VDirectory)item;

                    ExplorerDataGrid.Rows.Add(
                        index,
                        ViewHelper.GetDirectoryIcon(dir),
                        dir.Name,
                        ViewHelper.ParseDate(dir.CreationDate));
                }

                ExplorerDataGrid.Rows[i].Cells[2].ReadOnly = true;
            }

            ExplorerDataGrid.ClearSelection();

            SelectRow(view.GetSelectedItemIndex());

            CanUpdate = true;
        }
        private void SetPathPanel(FileExplorerProfile profile, VDirectory directory) {
            PathPanel panel = new PathPanel(profile, directory, CreateGraphics());

            PathPanel.Controls.Clear();
            PathPanel.Controls.Add(panel);
        }

        private void SelectRow(int itemIndex)
        {
            if (itemIndex == -1) return;

            foreach (DataGridViewRow row in ExplorerDataGrid.Rows) {
                int index = int.Parse(row.Cells[0].Value.ToString());

                if (index == itemIndex) {
                    row.Selected = true;
                    return;
                }
            }
        }
        private DataGridViewCell GetNameCellFromIndex(int index) {
            if (index == -1) return null;

            foreach (DataGridViewRow row in ExplorerDataGrid.Rows) {
                int rowIndex = int.Parse(row.Cells[0].Value.ToString());

                if (index == rowIndex) {
                    return row.Cells[2];
                }
            }

            return null;
        }

        private void Profile_Update(object sender, EventArgs e) {
            RefreshPanel();
        }
        private void FileExplorerPanel_Load(object sender, EventArgs e)
        {
            ExplorerDataGrid.ClearSelection();
        }

        private void ExplorerDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EndRename(ExplorerDataGrid.Rows[e.RowIndex]);
        }

        //ToolBar
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (Profile.ViewIndex > 0) {
                GoBack();
            }
        }
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (Profile.ViewIndex < Profile.PlacePaths.Count - 1) {
                GoForward();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshPanel();
        }

        //Functions
        private void GoBack()
        {
            Profile.GoBack();
        }
        private void GoForward()
        {
            Profile.GoForward();
        }
        private void RefreshPanel()
        {
            Profile.View.Update();

            DisplayView(Profile.View);
        }

        private void OpenDirectory(VDirectory directory)
        {
            Profile.OpenDirectory(directory);

            OnDirectoryOpen(directory);
        }

        private void Copy(VItem item) {
            Profile.Manager.ClipBoard = item;
        }
        private void Paste(VDirectory directory, VItem item) {
            directory.Paste(item);

            Profile.Manager.Save();
        }
        private void Delete(VItem item) {
            if (item.GetType() == typeof(VDirectory)) {
                GetCurrentDirectory().RemoveDirectory(item.Name);

                Profile.Manager.Save();
            } else if (item.GetType() == typeof(VFile)) {
                GetCurrentDirectory().RemoveFile(item.Name);

                Profile.Manager.Save();
            }
        }

        private void OpenProperties(VItem item) {
            //test
            //GetCurrentDirectory().Parent.RemoveDirectory(GetCurrentDirectory().Name);
            //return;
            //test

            if (item.GetType() == typeof(VDirectory)) {
                new DirectoryProperties(Profile.Manager, (VDirectory)item).ShowDialog();
            } else if (item.GetType() == typeof(VFile)) {
                new PropertiesWindow(Profile.Manager, (VFile)item).ShowDialog();
            }
        }

        private void StartRename(VItem item)
        {
            int index = Profile.View.GetItemIndex(item);
            DataGridViewCell cell = GetNameCellFromIndex(index);

            if (cell == null) { return; }

            cell.ReadOnly = false;
            ExplorerDataGrid.CurrentCell = cell;
            ExplorerDataGrid.BeginEdit(true);
        }
        private void EndRename(DataGridViewRow row) {
            var cell = row.Cells[2];
            int index = int.Parse(row.Cells[0].Value.ToString());

            cell.ReadOnly = true;

            VItem item = Profile.View.Items[index];
            Rename(cell, item);
        }
        private void Rename(DataGridViewCell cell, VItem item) {
            string newName = cell.Value.ToString();

            if (newName == item.Name) { return; }

            VDirectory currentDir = GetCurrentDirectory();
            if (item.GetType() == typeof(VDirectory)) {
                if (!currentDir.DirectoryExists(newName)) {
                    item.Name = newName;

                    Profile.Manager.Save();
                    return;
                }
            } else if (item.GetType() == typeof(VFile)) {
                if (!currentDir.FileExists(newName)) {
                    item.Name = newName;

                    Profile.Manager.Save();
                    return;
                }
            }

            RefreshPanel();
        }

        //Public Functions
        public VDirectory GetCurrentDirectory()
        {
            return Profile.View.Directory;
        }

        //Selection
        private void ExplorerDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = ExplorerDataGrid.HitTest(e.X, e.Y);

            if (hit.RowIndex < 0) {
                ExplorerDataGrid.ClearSelection();
                ExplorerDataGrid.EndEdit();
            } else{
                ExplorerDataGrid.Rows[hit.RowIndex].Selected = true;
            }
        }

        private bool CanUpdate = false;
        private void ExplorerDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CanUpdate) {
                Profile.View.SelectItem(SelectedItem);

                if(SelectedItem != null)
                    OnItemClick(SelectedItem);
            }
        }

        private void ExplorerDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            VItem selectedItem = SelectedItem;

            OnItemDoubleClick(selectedItem);

            if (selectedItem.GetType() == typeof(VDirectory)) {
                OpenDirectory((VDirectory)selectedItem);
            }
        }

        //Hover
        private void ExplorerDataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1) {
                HighlightRow(e.RowIndex, HightLightColor);
            }
        }
        private void ExplorerDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) {
                HighlightRow(e.RowIndex, ExplorerDataGrid.BackgroundColor);
            }
        }

        private static readonly Color HightLightColor = Color.FromArgb(65, 65, 65);
        private void HighlightRow(int rowIndex, Color color)
        {
            ExplorerDataGrid.Rows[rowIndex].DefaultCellStyle.BackColor = color;
        }

        //ExplorerGridMenuStrip
        private void ExplorerGridMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool onItem = SelectedIndex > -1;

            CopyStripItem.Enabled = onItem;
            PasteStripItem.Enabled = Profile.Manager.ClipBoard != null;
            RenameStripItem.Enabled = onItem;
            DeleteStripItem.Enabled = onItem;
        }

        private void CopyStripItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null) Copy(SelectedItem);
        }
        private void PasteStripItem_Click(object sender, EventArgs e)
        {
            if (Profile.Manager.ClipBoard == null) { return; }
            VDirectory dir;

            if (SelectedIndex < 0) {
                dir = GetCurrentDirectory();
            } else {
                if (SelectedItem.GetType() == typeof(VDirectory)) {
                    dir = (VDirectory)SelectedItem;
                } else {
                    dir = GetCurrentDirectory();
                }
            }

            Paste(dir, Profile.Manager.ClipBoard);
        }

        private void RenameStripItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null) {
                StartRename(SelectedItem);
            }
        }
        private void DeleteStripItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null) {
                Delete(SelectedItem);
            }
        }

        private void PropertiesStripItem_Click(object sender, EventArgs e)
        {
            if (SelectedIndex < 0) {
                OpenProperties(GetCurrentDirectory());
            } else{
                OpenProperties(SelectedItem);
            }
        }

        private void FolderStripItem_Click(object sender, EventArgs e)
        {
            VDirectory currentDir = GetCurrentDirectory();
            VDirectory newDirectory = new VDirectory(currentDir.GetDirectoryName("New Directory"));

            currentDir.AppendChild(newDirectory);

            Profile.Manager.Save();
        }
        private void FileStripItem_Click(object sender, EventArgs e)
        {
            VDirectory currentDir = GetCurrentDirectory();
            VFile newFile = new VFile(currentDir.GetFileName("New File"));

            currentDir.AppendChild(newFile);

            Profile.Manager.Save();
        }
    }
}