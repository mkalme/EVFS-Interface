using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace FileExplorer {
    public partial class FileTypeAndProgramManager : Form {
        private EVFSManager Manager { get; set; }
        private FileType Type { get; set; }

        public FileTypeAndProgramManager(EVFSManager manager, FileType type)
        {
            InitializeComponent();

            Manager = manager;
            Type = type;

            SelectExtension selectExtension = new SelectExtension();
            selectExtension.BorderStyle = BorderStyle.None;
            selectExtension.Dock = DockStyle.Fill;
            SelectExtensionContainer.Controls.Add(selectExtension);

            DisplayFileTypePanel(type);
        }

        private void DisplayFileTypePanel(FileType fileType) {
            FileTypeContainer.Controls.Clear();

            if (fileType == null) return;

            FileTypePanel panel = new FileTypePanel(Manager, fileType);
            panel.Dock = DockStyle.Fill;

            FileTypeContainer.Controls.Add(panel);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
