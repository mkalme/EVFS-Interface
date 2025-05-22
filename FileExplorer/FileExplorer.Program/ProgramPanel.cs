using System;
using System.Windows.Forms;
using System.Drawing;

namespace FileExplorer {
    class ProgramPanel : Panel {
        public EVFS.OS.Program Program { get; set; }

        public new Color BackColor {
            get {
                return base.BackColor;
            }
            set {
                Color color = value;
                base.BackColor = color;
                
                _color = color;
                _hightLightColor = Color.FromArgb(color.R + 20, color.G + 20, color.B + 20);
                _holdColor = Color.FromArgb(color.R + 55, color.G + 55, color.B + 55);
            }
        }

        private Color _color = Color.FromArgb(45, 45, 45);
        private Color _hightLightColor = Color.FromArgb(65, 65, 65);
        private Color _holdColor = Color.FromArgb(100, 100, 100);

        private PanelState _state = PanelState.None;

        private event EventHandler _click;
        public new event EventHandler Click {
            add {
                _click += value;
            }
            remove {
                _click -= value;
            }
        }

        public ProgramPanel(EVFS.OS.Program program)
        {
            InitializeComponent();

            Program = program;
            ProgramPictureBox.BackgroundImage = program.Icon;
            ProgramNameLabel.Text = program.Name;
            ProgramDescriptionLabel.Text = program.Description;
        }

        private void OnClick() {
            if (_click != null) {
                _click(this, EventArgs.Empty);
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e) {
            if (_state != PanelState.OnHold) {
                base.BackColor = _hightLightColor;
                _state = PanelState.OnHover;
            }
        }
        private void Control_MouseLeave(object sender, EventArgs e) {
            if (_state != PanelState.OnHold) {
                base.BackColor = _color;
                _state = PanelState.None;
            }
        }
        private void Control_MouseDown(object sender, MouseEventArgs e) {
            base.BackColor = _holdColor;
            _state = PanelState.OnHold;
        }
        private void Control_MouseUp(object sender, MouseEventArgs e) {
            base.BackColor = _hightLightColor;
            _state = PanelState.None;
        }
        private void Control_Click(object sender, EventArgs e) {
            OnClick();
        }

        private void InitializeComponent()
        {
            //PictureBox
            ProgramPictureBox = new PictureBox();
            ProgramPictureBox.Location = new Point(22, 5);
            ProgramPictureBox.Size = new Size(40, 40);
            ProgramPictureBox.BackgroundImageLayout = ImageLayout.Zoom;

            ProgramPictureBox.MouseEnter += new EventHandler(Control_MouseEnter);
            ProgramPictureBox.MouseLeave += new EventHandler(Control_MouseLeave);
            ProgramPictureBox.MouseDown += new MouseEventHandler(Control_MouseDown);
            ProgramPictureBox.MouseUp += new MouseEventHandler(Control_MouseUp);
            ProgramPictureBox.Click += new EventHandler(Control_Click);

            //ProgramNameLabel
            ProgramNameLabel = new Label();
            ProgramNameLabel.Font = new Font("Microsoft Sans Serif", 11);
            ProgramNameLabel.ForeColor = SystemColors.HighlightText;
            ProgramNameLabel.Location = new Point(68, 6);

            ProgramNameLabel.MouseEnter += new EventHandler(Control_MouseEnter);
            ProgramNameLabel.MouseLeave += new EventHandler(Control_MouseLeave);
            ProgramNameLabel.MouseDown += new MouseEventHandler(Control_MouseDown);
            ProgramNameLabel.MouseUp += new MouseEventHandler(Control_MouseUp);
            ProgramNameLabel.Click += new EventHandler(Control_Click);

            //ProgramDescriptionLabel
            ProgramDescriptionLabel = new Label();
            ProgramDescriptionLabel.Font = new Font("Microsoft Sans Serif", 9);
            ProgramDescriptionLabel.ForeColor = Color.FromArgb(160, 160, 160);
            ProgramDescriptionLabel.Location = new Point(68, 28);
            ProgramDescriptionLabel.AutoSize = true;

            ProgramDescriptionLabel.MouseEnter += new EventHandler(Control_MouseEnter);
            ProgramDescriptionLabel.MouseLeave += new EventHandler(Control_MouseLeave);
            ProgramDescriptionLabel.MouseDown += new MouseEventHandler(Control_MouseDown);
            ProgramDescriptionLabel.MouseUp += new MouseEventHandler(Control_MouseUp);
            ProgramDescriptionLabel.Click += new EventHandler(Control_Click);

            //This
            BackColor = Color.FromArgb(45, 45, 45);
            Size = new Size(350, 50);
            Padding = new Padding(0);
            Margin = new Padding(0);

            MouseEnter += new EventHandler(Control_MouseEnter);
            MouseLeave += new EventHandler(Control_MouseLeave);
            MouseDown += new MouseEventHandler(Control_MouseDown);
            MouseUp += new MouseEventHandler(Control_MouseUp);
            base.Click += new EventHandler(Control_Click);

            Controls.Add(ProgramPictureBox);
            Controls.Add(ProgramNameLabel);
            Controls.Add(ProgramDescriptionLabel);
        }

        private PictureBox ProgramPictureBox;
        private Label ProgramNameLabel;
        private Label ProgramDescriptionLabel;
    }

    enum PanelState { 
        OnHold,
        OnHover,
        None
    }
}
