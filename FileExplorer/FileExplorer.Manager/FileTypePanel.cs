using System;
using System.Drawing;
using System.Windows.Forms;
using EVFS.OS;

namespace FileExplorer {
    public partial class FileTypePanel : UserControl {
        private EVFSManager Manager { get; set; }
        private FileType Type { get; set; }

        private EVFS.OS.Program DefaultProgram { get; set; }

        public FileTypePanel(EVFSManager manager, FileType type)
        {
            InitializeComponent();

            Manager = manager;
            Type = type;

            if (type != null) {
                DefaultProgram = type.DefaultProgram;
            }

            Display();
        }

        private void Display() {
            SetPictureBox();
            SetTextBoxes();

            SetDefaultProgram(DefaultProgram);
            SetSupportedPrograms();
        }

        private void SetPictureBox() {
            IconPictureBox.BackgroundImage = Manager.GetTypeIcon(Type);
        }
        private void SetTextBoxes() {
            if (Type == null) return;

            TypeTextBox.Text = string.Format(".{0}", Type.Type.ToLower());
            DescriptionTextBox.Text = Type.Description;
        }

        private void SetDefaultProgram(EVFS.OS.Program program) {
            DefaultProgramContainer.Controls.Clear();
            if (program == null) return;

            ProgramPanel panel = new ProgramPanel(program);
            panel.BackColor = BodyContainer.BackColor;
            panel.Dock = DockStyle.Fill;

            DefaultProgramContainer.Controls.Add(panel);
        }
        private void SetSupportedPrograms()
        {
            if (Type == null) {
                SupportedProgramsContainer.BackColor = BackColor;
                return;
            }

            SelectProgramPanel panel = new SelectProgramPanel(Type.SupportedPrograms, ProgramType.File);
            panel.Dock = DockStyle.Fill;
            panel.BackColor = BodyContainer.BackColor;
            panel.PanelBackColor = BodyContainer.BackColor;

            panel.Click += new EventHandler(SelectProgramPanel_Click);

            SupportedProgramsContainer.Controls.Clear();
            SupportedProgramsContainer.Controls.Add(panel);
        }

        private void SelectProgramPanel_Click(object sender, EventArgs e)
        {
            ProgramPanel panel = (ProgramPanel)sender;

            DefaultProgram = panel.Program;

            SetDefaultProgram(panel.Program);
        }

        private void RemoveDefaultProgramLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DefaultProgram = null;

            SetDefaultProgram(null);
        }
    }
}
