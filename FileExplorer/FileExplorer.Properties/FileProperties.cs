using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace FileExplorer {
    public partial class PropertiesWindow : Form {
        private EVFSManager Manager { get; set; }
        private VFile File { get; set; }
        private FileType _type;

        public PropertiesWindow(EVFSManager manager, VFile file)
        {
            InitializeComponent();

            Manager = manager;
            File = file;
            SetFileType();

            Display();
        }

        private void Display() {
            SetImages();
            NameTextBox.Text = File.Name;
            SetOpenWithProgram();
            SetInfo();
        }

        private void SetImages() {
            IconPictureBox.BackgroundImage = Manager.GetFileIcon(File);
        }
        private void SetOpenWithProgram() {
            if (_type == null) {
                ProgramNameLabel.Text = "No program";
                return;
            }

            EVFS.OS.Program program = _type.DefaultProgram;
            if (program == null) {
                ProgramNameLabel.Text = "No program";
                return;
            }

            ProgramPictureBox.BackgroundImage = program.Icon;
            ProgramNameLabel.Text = program.Name;
        }
        private void SetInfo() {
            LocationTextBox.Text = ViewHelper.GetPath(File.Parent, @"\");
            SizeTextBox.Text = $"{ ViewHelper.ParseSize(File.GetSize()) } { ViewHelper.ParseFormat(File.GetSize()) }";

            TypeTextBox.Text = ViewHelper.GetTypeDescription(Manager, File);
            string ext = Path.GetExtension(File.Name);
            if (ext != "") {
                TypeTextBox.Text += $" ({ ext })";
            }

            CreatedTextBox.Text = ViewHelper.ParseDateReadable(File.CreationDate);
            LastModifiedTextBox.Text = ViewHelper.ParseDateReadable(File.LastModified);
        }

        private void SetFileType() {
            Manager.AllFileTypes.TryGetValue(ViewHelper.GetExtension(File.Name), out _type);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //SelectProgramDialog dialog = new SelectProgramDialog(Manager, _type);
            //dialog.ShowDialog();

            FileTypeAndProgramManager manager = new FileTypeAndProgramManager(Manager, _type);

            manager.ShowDialog();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
