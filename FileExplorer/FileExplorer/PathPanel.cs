using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using EncryptedVirtualFileSystem;

namespace FileExplorer {
    class PathPanel : Panel {
        private FileExplorerProfile Profile { get; set; }

        public PathPanel(FileExplorerProfile profile, VDirectory directory, Graphics graphics) {
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Dock = DockStyle.Fill;
            Margin = new Padding(3, 3, 3, 5);

            Profile = profile;
            Controls.AddRange(GetControls(directory, graphics).ToArray());
        }

        private List<Control> GetControls(VDirectory directory, Graphics graphics) {
            List<Control> controls = new List<Control>() 
            { 
                PathButton.FromDirectory(directory, directory.Name, graphics)
            };

            VDirectory dir = directory.Parent;
            while (dir != null){
                controls.Insert(0, new PathLabel(">", graphics));
                controls.Insert(0, PathButton.FromDirectory(dir, dir.Name, graphics));

                dir = dir.Parent;
            }

            int x = 0;
            for(int i = 0; i < controls.Count; i++) {
                controls[i].Location = new Point(x, -1);

                if (controls[i].GetType() == typeof(PathButton)) {
                    if (i < controls.Count - 1) {
                        controls[i].Click += new EventHandler(PathButton_Click);
                    }
                }

                x += controls[i].Width;
            }

            return controls;
        }

        private void PathButton_Click(object sender, EventArgs e) {
            Profile.OpenDirectory(((PathButton)sender).Directory);
        }
    }

    class PathButton : Button {
        public VDirectory Directory { get; set; }
        public PathButton() {
            BackColor = Color.FromArgb(35, 35, 35);
            Font = new Font("Segoe UI", 10);
            ForeColor = SystemColors.HighlightText;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseCompatibleTextRendering = true;
        }

        public static PathButton FromDirectory(VDirectory directory, string text, Graphics graphics) {
            PathButton button = new PathButton();

            button.Directory = directory;
            button.Text = text;
            button.Size = new Size((int)graphics.MeasureString(text, button.Font).Width + 10, 22);

            return button;
        }
    }
    class PathLabel : Label { 
        public PathLabel(string suff, Graphics graphics){
            ForeColor = SystemColors.HighlightText;
            Font = new Font("Segoe UI", 10);
            Width = (int)graphics.MeasureString(suff, Font).Width + 4;

            Text = suff;
        }
    }
}
