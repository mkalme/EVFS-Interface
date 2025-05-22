namespace FileExplorer {
    partial class SelectExtension {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExtensionListView = new System.Windows.Forms.ListView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SelectExtensionLabel = new System.Windows.Forms.Label();
            this.SeperatorSelectExtensionLabel = new System.Windows.Forms.Label();
            this.BodyContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BodyContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExtensionListView
            // 
            this.ExtensionListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExtensionListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExtensionListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtensionListView.HideSelection = false;
            this.ExtensionListView.Location = new System.Drawing.Point(3, 55);
            this.ExtensionListView.Name = "ExtensionListView";
            this.ExtensionListView.Size = new System.Drawing.Size(193, 322);
            this.ExtensionListView.TabIndex = 0;
            this.ExtensionListView.UseCompatibleStateImageBehavior = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchTextBox.Location = new System.Drawing.Point(3, 27);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(193, 21);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.Text = "Search...";
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // SelectExtensionLabel
            // 
            this.SelectExtensionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectExtensionLabel.AutoSize = true;
            this.SelectExtensionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectExtensionLabel.Location = new System.Drawing.Point(0, 3);
            this.SelectExtensionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 4);
            this.SelectExtensionLabel.Name = "SelectExtensionLabel";
            this.SelectExtensionLabel.Size = new System.Drawing.Size(85, 13);
            this.SelectExtensionLabel.TabIndex = 2;
            this.SelectExtensionLabel.Text = "Select extension";
            // 
            // SeperatorSelectExtensionLabel
            // 
            this.SeperatorSelectExtensionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeperatorSelectExtensionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeperatorSelectExtensionLabel.ForeColor = System.Drawing.Color.Silver;
            this.SeperatorSelectExtensionLabel.Location = new System.Drawing.Point(3, 20);
            this.SeperatorSelectExtensionLabel.Name = "SeperatorSelectExtensionLabel";
            this.SeperatorSelectExtensionLabel.Size = new System.Drawing.Size(193, 1);
            this.SeperatorSelectExtensionLabel.TabIndex = 3;
            // 
            // BodyContainer
            // 
            this.BodyContainer.ColumnCount = 1;
            this.BodyContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BodyContainer.Controls.Add(this.SelectExtensionLabel, 0, 0);
            this.BodyContainer.Controls.Add(this.SeperatorSelectExtensionLabel, 0, 1);
            this.BodyContainer.Controls.Add(this.ExtensionListView, 0, 3);
            this.BodyContainer.Controls.Add(this.SearchTextBox, 0, 2);
            this.BodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyContainer.Location = new System.Drawing.Point(3, 3);
            this.BodyContainer.Margin = new System.Windows.Forms.Padding(0);
            this.BodyContainer.Name = "BodyContainer";
            this.BodyContainer.RowCount = 4;
            this.BodyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BodyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.BodyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.BodyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BodyContainer.Size = new System.Drawing.Size(199, 380);
            this.BodyContainer.TabIndex = 4;
            // 
            // SelectExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BodyContainer);
            this.Name = "SelectExtension";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(205, 386);
            this.BodyContainer.ResumeLayout(false);
            this.BodyContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ExtensionListView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SelectExtensionLabel;
        private System.Windows.Forms.Label SeperatorSelectExtensionLabel;
        private System.Windows.Forms.TableLayoutPanel BodyContainer;
    }
}
