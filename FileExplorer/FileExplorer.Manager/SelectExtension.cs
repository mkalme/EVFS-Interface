using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileExplorer {
    public partial class SelectExtension : UserControl {
        public SelectExtension()
        {
            InitializeComponent();
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Search...") {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = SystemColors.HighlightText;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text)) {
                SearchTextBox.Text = "Search...";
                SearchTextBox.ForeColor = Color.DarkGray;
            }
        }
    }
}
