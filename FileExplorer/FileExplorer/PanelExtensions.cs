using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace FileExplorer {
    static class ExtensionMethods {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
        public static void StripSeparator_Paint(object sender, PaintEventArgs e)
        {
            ToolStripSeparator stripSeparator = sender as ToolStripSeparator;
            ContextMenuStrip menuStrip = stripSeparator.Owner as ContextMenuStrip;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), new Rectangle(0, 0, stripSeparator.Width, stripSeparator.Height));
            using (Pen pen = new Pen(Color.LightGray, 1)) {
                e.Graphics.DrawLine(pen, new Point(0, stripSeparator.Height / 2), new Point(menuStrip.Width, stripSeparator.Height / 2));
            }
        }
    }

    class MyToolStripRenderer : ToolStripProfessionalRenderer {
        public MyToolStripRenderer() : base(new MyColorTable()) { }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            var tsMenuItem = e.Item as ToolStripMenuItem;
            if (tsMenuItem != null)
                e.ArrowColor = Color.LightGray;
            base.OnRenderArrow(e);
        }
    }
    class MyColorTable : ProfessionalColorTable {
        public override Color MenuItemSelected {
            get { return Color.Gray; }
        }
        public override Color MenuItemBorder {
            get { return Color.Gray; }
        }
    }
}
