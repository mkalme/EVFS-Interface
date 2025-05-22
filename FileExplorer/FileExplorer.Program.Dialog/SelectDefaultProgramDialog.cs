using System;
using System.Drawing;
using System.Windows.Forms;
using EVFS.OS;

namespace FileExplorer {
    public partial class SelectProgramDialog : Form {
        private EVFSManager Manager { get; set; }
        private FileType Type { get; set; }
        public EVFS.OS.Program SelectedProgram { get; set; }

        public SelectProgramDialog(EVFSManager manager, FileType type)
        {
            InitializeComponent();

            Manager = manager;
            Type = type;
            if (Type != null) SelectedProgram = type.DefaultProgram;

            Display();
        }

        private void Display() {
            SetPictureBox();
            SetTextBox();

            SetDefaultProgram(SelectedProgram);
            SetSupportedPrograms();
        }

        private void SetPictureBox() {
            FileTypePictureBox.BackgroundImage = Manager.GetTypeIcon(Type);
        }
        private void SetTextBox() {
            if (Type == null) {
                FileTypeLabel.Text = "Unknown file type";
                return;
            }

            FileTypeLabel.Text = string.Format(".{0} | {1}", Type.Type.ToLower(), Type.Description);
        }
        private void SetDefaultProgram(EVFS.OS.Program program) {
            if (program == null) return;

            ProgramPanel panel = new ProgramPanel(program);
            panel.BackColor = Color.FromArgb(38, 38, 38);

            DefaultProgramContainer.Controls.Clear();
            DefaultProgramContainer.Controls.Add(panel);
        }
        private void SetSupportedPrograms() {
            if (Type == null) {
                SupportedProgramsContainer.BackColor = BackColor;
                return; 
            }

            SelectProgramPanel panel = new SelectProgramPanel(Type.SupportedPrograms, ProgramType.File);
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.FromArgb(38, 38, 38);
            panel.PanelBackColor = panel.BackColor;

            panel.Click += new EventHandler(SelectProgramPanel_Click);

            SupportedProgramsContainer.Controls.Clear();
            SupportedProgramsContainer.Controls.Add(panel);
        }

        private void SelectProgramPanel_Click(object sender, EventArgs e) {
            ProgramPanel panel = (ProgramPanel)sender;

            SelectedProgram = panel.Program;

            SetDefaultProgram(panel.Program);
        }

        private void FileTypeProgramLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileTypeAndProgramManager manager = new FileTypeAndProgramManager(Manager, Type);

            manager.ShowDialog();
        }
    }
}