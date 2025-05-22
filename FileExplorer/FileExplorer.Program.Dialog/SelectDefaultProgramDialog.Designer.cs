namespace FileExplorer {
    partial class SelectProgramDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProgramDialog));
            this.DefaultFileTypeLabel = new System.Windows.Forms.Label();
            this.FileTypePanel = new System.Windows.Forms.Panel();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.FileTypePictureBox = new System.Windows.Forms.PictureBox();
            this.DefaultProgramContainer = new System.Windows.Forms.Panel();
            this.DefaultProgramLabel = new System.Windows.Forms.Label();
            this.SupportedProgramsLabel = new System.Windows.Forms.Label();
            this.SupportedProgramsContainer = new System.Windows.Forms.Panel();
            this.FileTypeProgramLink = new System.Windows.Forms.LinkLabel();
            this.ClickToSelectLabel = new System.Windows.Forms.Label();
            this.FileTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileTypePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultFileTypeLabel
            // 
            this.DefaultFileTypeLabel.AutoSize = true;
            this.DefaultFileTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DefaultFileTypeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultFileTypeLabel.Location = new System.Drawing.Point(6, 7);
            this.DefaultFileTypeLabel.Name = "DefaultFileTypeLabel";
            this.DefaultFileTypeLabel.Size = new System.Drawing.Size(258, 16);
            this.DefaultFileTypeLabel.TabIndex = 0;
            this.DefaultFileTypeLabel.Text = "Select the default program for the file type: ";
            // 
            // FileTypePanel
            // 
            this.FileTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FileTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileTypePanel.Controls.Add(this.FileTypeLabel);
            this.FileTypePanel.Controls.Add(this.FileTypePictureBox);
            this.FileTypePanel.Controls.Add(this.DefaultFileTypeLabel);
            this.FileTypePanel.Location = new System.Drawing.Point(8, 8);
            this.FileTypePanel.Name = "FileTypePanel";
            this.FileTypePanel.Size = new System.Drawing.Size(335, 71);
            this.FileTypePanel.TabIndex = 2;
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FileTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FileTypeLabel.Location = new System.Drawing.Point(42, 42);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(0, 15);
            this.FileTypeLabel.TabIndex = 4;
            // 
            // FileTypePictureBox
            // 
            this.FileTypePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FileTypePictureBox.Location = new System.Drawing.Point(7, 31);
            this.FileTypePictureBox.Name = "FileTypePictureBox";
            this.FileTypePictureBox.Size = new System.Drawing.Size(30, 30);
            this.FileTypePictureBox.TabIndex = 3;
            this.FileTypePictureBox.TabStop = false;
            // 
            // DefaultProgramContainer
            // 
            this.DefaultProgramContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DefaultProgramContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DefaultProgramContainer.Location = new System.Drawing.Point(8, 109);
            this.DefaultProgramContainer.Name = "DefaultProgramContainer";
            this.DefaultProgramContainer.Size = new System.Drawing.Size(335, 52);
            this.DefaultProgramContainer.TabIndex = 3;
            // 
            // DefaultProgramLabel
            // 
            this.DefaultProgramLabel.AutoSize = true;
            this.DefaultProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DefaultProgramLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultProgramLabel.Location = new System.Drawing.Point(7, 89);
            this.DefaultProgramLabel.Name = "DefaultProgramLabel";
            this.DefaultProgramLabel.Size = new System.Drawing.Size(104, 16);
            this.DefaultProgramLabel.TabIndex = 4;
            this.DefaultProgramLabel.Text = "Default program";
            // 
            // SupportedProgramsLabel
            // 
            this.SupportedProgramsLabel.AutoSize = true;
            this.SupportedProgramsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SupportedProgramsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SupportedProgramsLabel.Location = new System.Drawing.Point(7, 171);
            this.SupportedProgramsLabel.Name = "SupportedProgramsLabel";
            this.SupportedProgramsLabel.Size = new System.Drawing.Size(132, 16);
            this.SupportedProgramsLabel.TabIndex = 5;
            this.SupportedProgramsLabel.Text = "Supported programs";
            // 
            // SupportedProgramsContainer
            // 
            this.SupportedProgramsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SupportedProgramsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupportedProgramsContainer.Location = new System.Drawing.Point(8, 192);
            this.SupportedProgramsContainer.Name = "SupportedProgramsContainer";
            this.SupportedProgramsContainer.Size = new System.Drawing.Size(335, 146);
            this.SupportedProgramsContainer.TabIndex = 6;
            // 
            // FileTypeProgramLink
            // 
            this.FileTypeProgramLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.FileTypeProgramLink.AutoSize = true;
            this.FileTypeProgramLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FileTypeProgramLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.FileTypeProgramLink.Location = new System.Drawing.Point(61, 344);
            this.FileTypeProgramLink.Name = "FileTypeProgramLink";
            this.FileTypeProgramLink.Size = new System.Drawing.Size(227, 16);
            this.FileTypeProgramLink.TabIndex = 7;
            this.FileTypeProgramLink.TabStop = true;
            this.FileTypeProgramLink.Text = "Open file type and program manager";
            this.FileTypeProgramLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.FileTypeProgramLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FileTypeProgramLink_LinkClicked);
            // 
            // ClickToSelectLabel
            // 
            this.ClickToSelectLabel.AutoSize = true;
            this.ClickToSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ClickToSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClickToSelectLabel.Location = new System.Drawing.Point(262, 171);
            this.ClickToSelectLabel.Name = "ClickToSelectLabel";
            this.ClickToSelectLabel.Size = new System.Drawing.Size(81, 15);
            this.ClickToSelectLabel.TabIndex = 8;
            this.ClickToSelectLabel.Text = "Click to select";
            // 
            // SelectProgramDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.ClickToSelectLabel);
            this.Controls.Add(this.FileTypeProgramLink);
            this.Controls.Add(this.SupportedProgramsContainer);
            this.Controls.Add(this.SupportedProgramsLabel);
            this.Controls.Add(this.DefaultProgramLabel);
            this.Controls.Add(this.DefaultProgramContainer);
            this.Controls.Add(this.FileTypePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectProgramDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select default program";
            this.FileTypePanel.ResumeLayout(false);
            this.FileTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileTypePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DefaultFileTypeLabel;
        private System.Windows.Forms.Panel FileTypePanel;
        private System.Windows.Forms.PictureBox FileTypePictureBox;
        private System.Windows.Forms.Panel DefaultProgramContainer;
        private System.Windows.Forms.Label DefaultProgramLabel;
        private System.Windows.Forms.Label SupportedProgramsLabel;
        private System.Windows.Forms.Panel SupportedProgramsContainer;
        private System.Windows.Forms.LinkLabel FileTypeProgramLink;
        private System.Windows.Forms.Label ClickToSelectLabel;
        private System.Windows.Forms.Label FileTypeLabel;
    }
}