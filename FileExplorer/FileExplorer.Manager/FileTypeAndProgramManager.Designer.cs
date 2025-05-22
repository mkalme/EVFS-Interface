namespace FileExplorer {
    partial class FileTypeAndProgramManager {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTypeAndProgramManager));
            this.BodyContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SelectExtensionContainer = new System.Windows.Forms.Panel();
            this.FileTypeContainer = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackgroundContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BodyContainer.SuspendLayout();
            this.BackgroundContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyContainer
            // 
            this.BodyContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.BodyContainer.ColumnCount = 2;
            this.BodyContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.BodyContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BodyContainer.Controls.Add(this.SelectExtensionContainer, 0, 0);
            this.BodyContainer.Controls.Add(this.FileTypeContainer, 1, 0);
            this.BodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyContainer.Location = new System.Drawing.Point(2, 2);
            this.BodyContainer.Margin = new System.Windows.Forms.Padding(2);
            this.BodyContainer.Name = "BodyContainer";
            this.BodyContainer.RowCount = 1;
            this.BodyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BodyContainer.Size = new System.Drawing.Size(839, 456);
            this.BodyContainer.TabIndex = 0;
            // 
            // SelectExtensionContainer
            // 
            this.SelectExtensionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectExtensionContainer.Location = new System.Drawing.Point(1, 1);
            this.SelectExtensionContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SelectExtensionContainer.Name = "SelectExtensionContainer";
            this.SelectExtensionContainer.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.SelectExtensionContainer.Size = new System.Drawing.Size(205, 454);
            this.SelectExtensionContainer.TabIndex = 0;
            // 
            // FileTypeContainer
            // 
            this.FileTypeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTypeContainer.Location = new System.Drawing.Point(207, 1);
            this.FileTypeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.FileTypeContainer.Name = "FileTypeContainer";
            this.FileTypeContainer.Padding = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.FileTypeContainer.Size = new System.Drawing.Size(631, 454);
            this.FileTypeContainer.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(2, 465);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(84, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BackgroundContainer
            // 
            this.BackgroundContainer.ColumnCount = 1;
            this.BackgroundContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundContainer.Controls.Add(this.CloseButton, 0, 1);
            this.BackgroundContainer.Controls.Add(this.BodyContainer, 0, 0);
            this.BackgroundContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundContainer.Location = new System.Drawing.Point(5, 5);
            this.BackgroundContainer.Name = "BackgroundContainer";
            this.BackgroundContainer.RowCount = 2;
            this.BackgroundContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.BackgroundContainer.Size = new System.Drawing.Size(843, 491);
            this.BackgroundContainer.TabIndex = 2;
            // 
            // FileTypeAndProgramManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(853, 501);
            this.Controls.Add(this.BackgroundContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileTypeAndProgramManager";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File type and program manager";
            this.BodyContainer.ResumeLayout(false);
            this.BackgroundContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BodyContainer;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel SelectExtensionContainer;
        private System.Windows.Forms.Panel FileTypeContainer;
        private System.Windows.Forms.TableLayoutPanel BackgroundContainer;
    }
}