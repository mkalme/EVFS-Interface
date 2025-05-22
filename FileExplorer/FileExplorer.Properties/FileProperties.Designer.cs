namespace FileExplorer {
    partial class PropertiesWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesWindow));
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SeperatorNameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.InfoSeperatorLabel = new System.Windows.Forms.Label();
            this.DateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.LastModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.LastModifiedTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DateSeperatorLabel = new System.Windows.Forms.Label();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.TypeSeperatorLabel = new System.Windows.Forms.Label();
            this.InfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TypeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OpenWithLabel = new System.Windows.Forms.Label();
            this.OpenWithPanel = new System.Windows.Forms.Panel();
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.ProgramPictureBox = new System.Windows.Forms.PictureBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.DateTableLayoutPanel.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.InfoTableLayoutPanel.SuspendLayout();
            this.TypeTableLayoutPanel.SuspendLayout();
            this.OpenWithPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackgroundImage = global::FileExplorer.Properties.Resources.Folder;
            this.IconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconPictureBox.Location = new System.Drawing.Point(13, 12);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(35, 35);
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(97, 19);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(225, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Text = "Photos 2019.11.13";
            this.NameTextBox.WordWrap = false;
            // 
            // SeperatorNameLabel
            // 
            this.SeperatorNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeperatorNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.SeperatorNameLabel.Location = new System.Drawing.Point(15, 53);
            this.SeperatorNameLabel.Name = "SeperatorNameLabel";
            this.SeperatorNameLabel.Size = new System.Drawing.Size(306, 1);
            this.SeperatorNameLabel.TabIndex = 2;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeLabel.Location = new System.Drawing.Point(1, 7);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationLabel.Location = new System.Drawing.Point(1, 7);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Location:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SizeLabel.Location = new System.Drawing.Point(1, 34);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(30, 13);
            this.SizeLabel.TabIndex = 2;
            this.SizeLabel.Text = "Size:";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TypeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeTextBox.Location = new System.Drawing.Point(87, 7);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.ReadOnly = true;
            this.TypeTextBox.Size = new System.Drawing.Size(220, 13);
            this.TypeTextBox.TabIndex = 4;
            this.TypeTextBox.Text = "Directory";
            this.TypeTextBox.WordWrap = false;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LocationTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationTextBox.Location = new System.Drawing.Point(87, 7);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(220, 13);
            this.LocationTextBox.TabIndex = 5;
            this.LocationTextBox.Text = "Root\\Photos";
            this.LocationTextBox.WordWrap = false;
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SizeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SizeTextBox.Location = new System.Drawing.Point(87, 34);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(220, 13);
            this.SizeTextBox.TabIndex = 6;
            this.SizeTextBox.Text = "65 MB";
            this.SizeTextBox.WordWrap = false;
            // 
            // InfoSeperatorLabel
            // 
            this.InfoSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoSeperatorLabel.ForeColor = System.Drawing.Color.Silver;
            this.InfoSeperatorLabel.Location = new System.Drawing.Point(15, 187);
            this.InfoSeperatorLabel.Name = "InfoSeperatorLabel";
            this.InfoSeperatorLabel.Size = new System.Drawing.Size(306, 1);
            this.InfoSeperatorLabel.TabIndex = 4;
            // 
            // DateTableLayoutPanel
            // 
            this.DateTableLayoutPanel.ColumnCount = 2;
            this.DateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.19547F));
            this.DateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.80453F));
            this.DateTableLayoutPanel.Controls.Add(this.CreatedLabel, 0, 0);
            this.DateTableLayoutPanel.Controls.Add(this.LastModifiedLabel, 0, 1);
            this.DateTableLayoutPanel.Controls.Add(this.CreatedTextBox, 1, 0);
            this.DateTableLayoutPanel.Controls.Add(this.LastModifiedTextBox, 1, 1);
            this.DateTableLayoutPanel.Location = new System.Drawing.Point(12, 192);
            this.DateTableLayoutPanel.Name = "DateTableLayoutPanel";
            this.DateTableLayoutPanel.RowCount = 2;
            this.DateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DateTableLayoutPanel.Size = new System.Drawing.Size(310, 54);
            this.DateTableLayoutPanel.TabIndex = 5;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CreatedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreatedLabel.Location = new System.Drawing.Point(1, 7);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 0;
            this.CreatedLabel.Text = "Created:";
            // 
            // LastModifiedLabel
            // 
            this.LastModifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastModifiedLabel.AutoSize = true;
            this.LastModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LastModifiedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LastModifiedLabel.Location = new System.Drawing.Point(1, 34);
            this.LastModifiedLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.LastModifiedLabel.Name = "LastModifiedLabel";
            this.LastModifiedLabel.Size = new System.Drawing.Size(72, 13);
            this.LastModifiedLabel.TabIndex = 1;
            this.LastModifiedLabel.Text = "Last modified:";
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CreatedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreatedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CreatedTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreatedTextBox.Location = new System.Drawing.Point(87, 7);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(220, 13);
            this.CreatedTextBox.TabIndex = 4;
            this.CreatedTextBox.Text = "Wednesday 2019, 13th of November, ‏‎22:25:42";
            this.CreatedTextBox.WordWrap = false;
            // 
            // LastModifiedTextBox
            // 
            this.LastModifiedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastModifiedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LastModifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastModifiedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LastModifiedTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LastModifiedTextBox.Location = new System.Drawing.Point(87, 34);
            this.LastModifiedTextBox.Name = "LastModifiedTextBox";
            this.LastModifiedTextBox.ReadOnly = true;
            this.LastModifiedTextBox.Size = new System.Drawing.Size(220, 13);
            this.LastModifiedTextBox.TabIndex = 5;
            this.LastModifiedTextBox.Text = "Today";
            this.LastModifiedTextBox.WordWrap = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(268, 338);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DateSeperatorLabel
            // 
            this.DateSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateSeperatorLabel.ForeColor = System.Drawing.Color.Silver;
            this.DateSeperatorLabel.Location = new System.Drawing.Point(15, 253);
            this.DateSeperatorLabel.Name = "DateSeperatorLabel";
            this.DateSeperatorLabel.Size = new System.Drawing.Size(306, 1);
            this.DateSeperatorLabel.TabIndex = 7;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundPanel.Controls.Add(this.TypeSeperatorLabel);
            this.BackgroundPanel.Controls.Add(this.InfoTableLayoutPanel);
            this.BackgroundPanel.Controls.Add(this.TypeTableLayoutPanel);
            this.BackgroundPanel.Controls.Add(this.IconPictureBox);
            this.BackgroundPanel.Controls.Add(this.DateSeperatorLabel);
            this.BackgroundPanel.Controls.Add(this.NameTextBox);
            this.BackgroundPanel.Controls.Add(this.SeperatorNameLabel);
            this.BackgroundPanel.Controls.Add(this.DateTableLayoutPanel);
            this.BackgroundPanel.Controls.Add(this.InfoSeperatorLabel);
            this.BackgroundPanel.Location = new System.Drawing.Point(8, 8);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(335, 321);
            this.BackgroundPanel.TabIndex = 8;
            // 
            // TypeSeperatorLabel
            // 
            this.TypeSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeSeperatorLabel.ForeColor = System.Drawing.Color.Silver;
            this.TypeSeperatorLabel.Location = new System.Drawing.Point(15, 121);
            this.TypeSeperatorLabel.Name = "TypeSeperatorLabel";
            this.TypeSeperatorLabel.Size = new System.Drawing.Size(306, 1);
            this.TypeSeperatorLabel.TabIndex = 10;
            // 
            // InfoTableLayoutPanel
            // 
            this.InfoTableLayoutPanel.ColumnCount = 2;
            this.InfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.2F));
            this.InfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.8F));
            this.InfoTableLayoutPanel.Controls.Add(this.SizeTextBox, 1, 1);
            this.InfoTableLayoutPanel.Controls.Add(this.SizeLabel, 0, 1);
            this.InfoTableLayoutPanel.Controls.Add(this.LocationLabel, 0, 0);
            this.InfoTableLayoutPanel.Controls.Add(this.LocationTextBox, 1, 0);
            this.InfoTableLayoutPanel.Location = new System.Drawing.Point(12, 126);
            this.InfoTableLayoutPanel.Name = "InfoTableLayoutPanel";
            this.InfoTableLayoutPanel.RowCount = 2;
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoTableLayoutPanel.Size = new System.Drawing.Size(310, 54);
            this.InfoTableLayoutPanel.TabIndex = 9;
            // 
            // TypeTableLayoutPanel
            // 
            this.TypeTableLayoutPanel.ColumnCount = 2;
            this.TypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.2F));
            this.TypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.8F));
            this.TypeTableLayoutPanel.Controls.Add(this.OpenWithLabel, 0, 1);
            this.TypeTableLayoutPanel.Controls.Add(this.TypeLabel, 0, 0);
            this.TypeTableLayoutPanel.Controls.Add(this.TypeTextBox, 1, 0);
            this.TypeTableLayoutPanel.Controls.Add(this.OpenWithPanel, 1, 1);
            this.TypeTableLayoutPanel.Location = new System.Drawing.Point(12, 60);
            this.TypeTableLayoutPanel.Name = "TypeTableLayoutPanel";
            this.TypeTableLayoutPanel.RowCount = 2;
            this.TypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TypeTableLayoutPanel.Size = new System.Drawing.Size(310, 54);
            this.TypeTableLayoutPanel.TabIndex = 8;
            // 
            // OpenWithLabel
            // 
            this.OpenWithLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenWithLabel.AutoSize = true;
            this.OpenWithLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.OpenWithLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenWithLabel.Location = new System.Drawing.Point(1, 34);
            this.OpenWithLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.OpenWithLabel.Name = "OpenWithLabel";
            this.OpenWithLabel.Size = new System.Drawing.Size(58, 13);
            this.OpenWithLabel.TabIndex = 5;
            this.OpenWithLabel.Text = "Open with:";
            // 
            // OpenWithPanel
            // 
            this.OpenWithPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.OpenWithPanel.Controls.Add(this.ProgramNameLabel);
            this.OpenWithPanel.Controls.Add(this.ProgramPictureBox);
            this.OpenWithPanel.Controls.Add(this.ChangeButton);
            this.OpenWithPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenWithPanel.Location = new System.Drawing.Point(84, 27);
            this.OpenWithPanel.Margin = new System.Windows.Forms.Padding(0);
            this.OpenWithPanel.Name = "OpenWithPanel";
            this.OpenWithPanel.Size = new System.Drawing.Size(226, 27);
            this.OpenWithPanel.TabIndex = 6;
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.AutoSize = true;
            this.ProgramNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProgramNameLabel.Location = new System.Drawing.Point(28, 7);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(0, 13);
            this.ProgramNameLabel.TabIndex = 12;
            // 
            // ProgramPictureBox
            // 
            this.ProgramPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProgramPictureBox.Location = new System.Drawing.Point(1, 2);
            this.ProgramPictureBox.Name = "ProgramPictureBox";
            this.ProgramPictureBox.Size = new System.Drawing.Size(23, 23);
            this.ProgramPictureBox.TabIndex = 11;
            this.ProgramPictureBox.TabStop = false;
            // 
            // ChangeButton
            // 
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeButton.Location = new System.Drawing.Point(163, 2);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(61, 23);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // PropertiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PropertiesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.DateTableLayoutPanel.ResumeLayout(false);
            this.DateTableLayoutPanel.PerformLayout();
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.InfoTableLayoutPanel.ResumeLayout(false);
            this.InfoTableLayoutPanel.PerformLayout();
            this.TypeTableLayoutPanel.ResumeLayout(false);
            this.TypeTableLayoutPanel.PerformLayout();
            this.OpenWithPanel.ResumeLayout(false);
            this.OpenWithPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SeperatorNameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label InfoSeperatorLabel;
        private System.Windows.Forms.TableLayoutPanel DateTableLayoutPanel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label LastModifiedLabel;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TextBox LastModifiedTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label DateSeperatorLabel;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.TableLayoutPanel TypeTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel InfoTableLayoutPanel;
        private System.Windows.Forms.Label OpenWithLabel;
        private System.Windows.Forms.Label TypeSeperatorLabel;
        private System.Windows.Forms.Panel OpenWithPanel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.PictureBox ProgramPictureBox;
        private System.Windows.Forms.Label ProgramNameLabel;
    }
}