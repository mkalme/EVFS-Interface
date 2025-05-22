using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using EVFS.OS;

namespace FileExplorer {
    public partial class SelectProgramPanel : UserControl {
        private ProgramType ProgramType { get; set; }
        private List<EVFS.OS.Program> Programs { get; set; }
        public EVFS.OS.Program SelectedProgram { get; set; }

        private Color _panelBackColor;
        public Color PanelBackColor {
            get { return _panelBackColor; }
            set {
                _panelBackColor = value;

                foreach (var panel in Panels) {
                    panel.BackColor = _panelBackColor;
                }
            }
        }

        private List<ProgramPanel> Panels { get; set; }


        private event EventHandler _click;
        public new event EventHandler Click {
            add {
                _click += value;
            }
            remove {
                _click -= value;
            }
        }

        public SelectProgramPanel(List<EVFS.OS.Program> programs, ProgramType type = ProgramType.All)
        {
            InitializeComponent();
            DoubleBuffered = true;

            ProgramType = type;
            Programs = programs;

            SetDisplay();
        }

        private void SetDisplay() {
            ProgramContainerPanel.Controls.Clear();

            List<ProgramPanel> panels = GetPanels();
            SetMouseEvents(panels);

            Panels = panels;

            ProgramContainerPanel.Controls.AddRange(panels.ToArray());
        }
        private List<ProgramPanel> GetPanels()
        {
            List<ProgramPanel> panels = new List<ProgramPanel>();

            for (int i = Programs.Count - 1; i > -1; i--) {
                EVFS.OS.Program program = Programs[i];

                if (ProgramType == ProgramType.Executive) {
                    if (program.GetType() == typeof(FileProgram)) continue;
                } else if (ProgramType == ProgramType.File) {
                    if (program.GetType() == typeof(EVFS.OS.Program)) continue;
                }

                ProgramPanel panel = new ProgramPanel(program);
                panel.Dock = DockStyle.Top;

                panels.Add(panel);
            }

            return panels;
        }
        private void SetMouseEvents(List<ProgramPanel> panels) {
            foreach (var panel in panels) {
                panel.Click += new EventHandler(ProgramPanel_Click);
            }
        }

        private void OnClick(object sender)
        {
            if (_click != null) {
                _click(sender, EventArgs.Empty);
            }
        }

        private void ProgramPanel_Click(object sender, EventArgs e) {
            OnClick(sender);
        }
    }

    public enum ProgramType { 
        Executive,
        File,
        All
    }
}