using System;
using System.Windows.Forms;
using System.Drawing;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace FileExplorer {
    public partial class FileExplorerWindow : Form {
        private EVFSManager Manager { get; set; }
        private FileExplorerPanel ExplorerPanel { get; set; }

        public FileExplorerWindow(EVFSManager manager, VDirectory directory)
        {
            InitializeComponent();

            Manager = manager;
            ExplorerPanel = new FileExplorerPanel(manager, directory);

            ExplorerPanel.ItemDoubleClick += new EventHandler(ExplorerPanel_ItemDoubleClick);

            Controls.Add(ExplorerPanel);
        }

        private void ExplorerPanel_ItemDoubleClick(object sender, EventArgs e) {
            if (sender.GetType() != typeof(VFile)) return;

            ((VFile)sender).LaunchDefaultProgram(Manager);
        }
    }
}
