namespace FileExplorer {
    partial class SelectProgramPanel {
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
            this.ProgramContainerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ProgramContainerPanel
            // 
            this.ProgramContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ProgramContainerPanel.Name = "ProgramContainerPanel";
            this.ProgramContainerPanel.Size = new System.Drawing.Size(292, 361);
            this.ProgramContainerPanel.TabIndex = 0;
            // 
            // SelectProgramPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.ProgramContainerPanel);
            this.Name = "SelectProgramPanel";
            this.Size = new System.Drawing.Size(292, 361);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProgramContainerPanel;
    }
}
