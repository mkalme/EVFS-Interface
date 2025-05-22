using System;
using System.Windows.Forms;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace FileExplorer {
    public partial class DirectoryProperties : Form {
        private EVFSManager Manager { get; set; }
        private VDirectory Directory { get; set; }

        public DirectoryProperties(EVFSManager manager, VDirectory directory)
        {
            InitializeComponent();

            Manager = manager;
            Directory = directory;

            Display();
        }

        private void Display()
        {
            SetImages();
            NameTextBox.Text = Directory.Name;
            SetInfo();
        }

        private void SetImages()
        {
            IconPictureBox.BackgroundImage = ViewHelper.GetDirectoryIcon(Directory);    
        }
        private void SetInfo()
        {
            LocationTextBox.Text = ViewHelper.GetPath(Directory.Parent, @"\");
            int size = Directory.GetSize();
            SizeTextBox.Text = $"{ ViewHelper.ParseSize(size) } { ViewHelper.ParseFormat(size) }";

            TypeTextBox.Text = "Directory";

            ContainsTextBox.Text =
                $"{ Directory.GetCountOfSubFiles() } files,{ Directory.GetCountOfSubDirectories() } directories";

            CreatedTextBox.Text = ViewHelper.ParseDateReadable(Directory.CreationDate);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
