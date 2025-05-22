using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileExplorer {
    partial class FileExplorerPanel {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorerPanel));
            this.ToolBarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PathPanel = new System.Windows.Forms.Panel();
            this.ExplorerDataGrid = new System.Windows.Forms.DataGridView();
            this.ExplorerGridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.RenameStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiesStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModificationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageCell = new System.Windows.Forms.DataGridViewImageColumn();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolBarTableLayoutPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerDataGrid)).BeginInit();
            this.ExplorerGridMenuStrip.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBarTableLayoutPanel
            // 
            this.ToolBarTableLayoutPanel.AutoSize = true;
            this.ToolBarTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToolBarTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolBarTableLayoutPanel.ColumnCount = 2;
            this.ToolBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.ToolBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolBarTableLayoutPanel.Controls.Add(this.ButtonPanel, 0, 0);
            this.ToolBarTableLayoutPanel.Controls.Add(this.PathPanel, 1, 0);
            this.ToolBarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ToolBarTableLayoutPanel.Name = "ToolBarTableLayoutPanel";
            this.ToolBarTableLayoutPanel.RowCount = 1;
            this.ToolBarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolBarTableLayoutPanel.Size = new System.Drawing.Size(647, 30);
            this.ToolBarTableLayoutPanel.TabIndex = 1;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonPanel.Controls.Add(this.RefreshButton);
            this.ButtonPanel.Controls.Add(this.ForwardButton);
            this.ButtonPanel.Controls.Add(this.BackButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(89, 30);
            this.ButtonPanel.TabIndex = 2;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::FileExplorer.Properties.Resources.Refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RefreshButton.Location = new System.Drawing.Point(64, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 23);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = global::FileExplorer.Properties.Resources.RightArrow;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ForwardButton.Location = new System.Drawing.Point(26, 3);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(23, 23);
            this.ForwardButton.TabIndex = 1;
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::FileExplorer.Properties.Resources.LeftArrow;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackButton.Location = new System.Drawing.Point(1, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PathPanel
            // 
            this.PathPanel.BackColor = System.Drawing.Color.Transparent;
            this.PathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanel.Location = new System.Drawing.Point(92, 3);
            this.PathPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Size = new System.Drawing.Size(552, 22);
            this.PathPanel.TabIndex = 3;
            // 
            // ExplorerDataGrid
            // 
            this.ExplorerDataGrid.AllowUserToAddRows = false;
            this.ExplorerDataGrid.AllowUserToDeleteRows = false;
            this.ExplorerDataGrid.AllowUserToResizeRows = false;
            this.ExplorerDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExplorerDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExplorerDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ExplorerDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExplorerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExplorerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExplorerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColumn,
            this.ImageCell,
            this.NameColumn,
            this.ModificationDateColumn,
            this.TypeColumn,
            this.SizeColumn});
            this.ExplorerDataGrid.ContextMenuStrip = this.ExplorerGridMenuStrip;
            this.ExplorerDataGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExplorerDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.ExplorerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerDataGrid.EnableHeadersVisualStyles = false;
            this.ExplorerDataGrid.Location = new System.Drawing.Point(3, 33);
            this.ExplorerDataGrid.MultiSelect = false;
            this.ExplorerDataGrid.Name = "ExplorerDataGrid";
            this.ExplorerDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExplorerDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ExplorerDataGrid.RowHeadersVisible = false;
            this.ExplorerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExplorerDataGrid.Size = new System.Drawing.Size(641, 373);
            this.ExplorerDataGrid.TabIndex = 0;
            this.ExplorerDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerDataGrid_CellDoubleClick);
            this.ExplorerDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerDataGrid_CellEndEdit);
            this.ExplorerDataGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerDataGrid_CellMouseLeave);
            this.ExplorerDataGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ExplorerDataGrid_CellMouseMove);
            this.ExplorerDataGrid.SelectionChanged += new System.EventHandler(this.ExplorerDataGrid_SelectionChanged);
            this.ExplorerDataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExplorerDataGrid_MouseDown);
            // 
            // ExplorerGridMenuStrip
            // 
            this.ExplorerGridMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.ExplorerGridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewStripItem,
            this.NewStripSeperator,
            this.CopyStripItem,
            this.PasteStripItem,
            this.PasteStripSeperator,
            this.RenameStripItem,
            this.DeleteStripItem,
            this.DeleteStripSeperator,
            this.PropertiesStripItem});
            this.ExplorerGridMenuStrip.Name = "ExplorerGridMenuStrip";
            this.ExplorerGridMenuStrip.Size = new System.Drawing.Size(150, 154);
            this.ExplorerGridMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ExplorerGridMenuStrip_Opening);
            // 
            // NewStripItem
            // 
            this.NewStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderStripItem,
            this.FileStripItem});
            this.NewStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewStripItem.Image = global::FileExplorer.Properties.Resources.Add;
            this.NewStripItem.Name = "NewStripItem";
            this.NewStripItem.Size = new System.Drawing.Size(149, 22);
            this.NewStripItem.Text = "New                 ";
            // 
            // FolderStripItem
            // 
            this.FolderStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderStripItem.Image = global::FileExplorer.Properties.Resources.Folder;
            this.FolderStripItem.Name = "FolderStripItem";
            this.FolderStripItem.Size = new System.Drawing.Size(149, 22);
            this.FolderStripItem.Text = "Folder              ";
            this.FolderStripItem.Click += new System.EventHandler(this.FolderStripItem_Click);
            // 
            // FileStripItem
            // 
            this.FileStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileStripItem.Image = global::FileExplorer.Properties.Resources.File;
            this.FileStripItem.Name = "FileStripItem";
            this.FileStripItem.Size = new System.Drawing.Size(149, 22);
            this.FileStripItem.Text = "File";
            this.FileStripItem.Click += new System.EventHandler(this.FileStripItem_Click);
            // 
            // NewStripSeperator
            // 
            this.NewStripSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewStripSeperator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewStripSeperator.Name = "NewStripSeperator";
            this.NewStripSeperator.Size = new System.Drawing.Size(146, 6);
            // 
            // CopyStripItem
            // 
            this.CopyStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CopyStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyStripItem.Name = "CopyStripItem";
            this.CopyStripItem.Size = new System.Drawing.Size(149, 22);
            this.CopyStripItem.Text = "Copy";
            this.CopyStripItem.Click += new System.EventHandler(this.CopyStripItem_Click);
            // 
            // PasteStripItem
            // 
            this.PasteStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasteStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasteStripItem.Name = "PasteStripItem";
            this.PasteStripItem.Size = new System.Drawing.Size(149, 22);
            this.PasteStripItem.Text = "Paste";
            this.PasteStripItem.Click += new System.EventHandler(this.PasteStripItem_Click);
            // 
            // PasteStripSeperator
            // 
            this.PasteStripSeperator.Name = "PasteStripSeperator";
            this.PasteStripSeperator.Size = new System.Drawing.Size(146, 6);
            // 
            // RenameStripItem
            // 
            this.RenameStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RenameStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RenameStripItem.Image = global::FileExplorer.Properties.Resources.Rename;
            this.RenameStripItem.Name = "RenameStripItem";
            this.RenameStripItem.Size = new System.Drawing.Size(149, 22);
            this.RenameStripItem.Text = "Rename";
            this.RenameStripItem.Click += new System.EventHandler(this.RenameStripItem_Click);
            // 
            // DeleteStripItem
            // 
            this.DeleteStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DeleteStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteStripItem.Image = global::FileExplorer.Properties.Resources.Delete;
            this.DeleteStripItem.Name = "DeleteStripItem";
            this.DeleteStripItem.Size = new System.Drawing.Size(149, 22);
            this.DeleteStripItem.Text = "Delete";
            this.DeleteStripItem.Click += new System.EventHandler(this.DeleteStripItem_Click);
            // 
            // DeleteStripSeperator
            // 
            this.DeleteStripSeperator.Name = "DeleteStripSeperator";
            this.DeleteStripSeperator.Size = new System.Drawing.Size(146, 6);
            // 
            // PropertiesStripItem
            // 
            this.PropertiesStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PropertiesStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PropertiesStripItem.Name = "PropertiesStripItem";
            this.PropertiesStripItem.Size = new System.Drawing.Size(149, 22);
            this.PropertiesStripItem.Text = "Properties";
            this.PropertiesStripItem.Click += new System.EventHandler(this.PropertiesStripItem_Click);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.ExplorerDataGrid, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.ToolBarTableLayoutPanel, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(647, 409);
            this.TableLayoutPanel.TabIndex = 2;
            // 
            // SizeColumn
            // 
            this.SizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.SizeColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.SizeColumn.HeaderText = "Size";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            this.SizeColumn.Width = 80;
            // 
            // TypeColumn
            // 
            this.TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TypeColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Width = 125;
            // 
            // ModificationDateColumn
            // 
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ModificationDateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ModificationDateColumn.HeaderText = "Modification date";
            this.ModificationDateColumn.Name = "ModificationDateColumn";
            this.ModificationDateColumn.ReadOnly = true;
            this.ModificationDateColumn.Width = 150;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 260;
            // 
            // ImageCell
            // 
            this.ImageCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ImageCell.DefaultCellStyle = dataGridViewCellStyle2;
            this.ImageCell.HeaderText = "";
            this.ImageCell.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageCell.Name = "ImageCell";
            this.ImageCell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ImageCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImageCell.Width = 26;
            // 
            // IndexColumn
            // 
            this.IndexColumn.HeaderText = "";
            this.IndexColumn.Name = "IndexColumn";
            this.IndexColumn.ReadOnly = true;
            this.IndexColumn.Visible = false;
            this.IndexColumn.Width = 22;
            // 
            // FileExplorerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.TableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FileExplorerPanel";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(659, 421);
            this.Load += new System.EventHandler(this.FileExplorerPanel_Load);
            this.ToolBarTableLayoutPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerDataGrid)).EndInit();
            this.ExplorerGridMenuStrip.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel ToolBarTableLayoutPanel;
        private Panel ButtonPanel;
        private Button RefreshButton;
        private Button ForwardButton;
        private Button BackButton;
        private DataGridView ExplorerDataGrid;
        private TableLayoutPanel TableLayoutPanel;
        private ContextMenuStrip ExplorerGridMenuStrip;
        private ToolStripMenuItem NewStripItem;
        private ToolStripMenuItem FolderStripItem;
        private ToolStripMenuItem FileStripItem;
        private ToolStripMenuItem RenameStripItem;
        private ToolStripMenuItem CopyStripItem;
        private ToolStripMenuItem PasteStripItem;
        private ToolStripMenuItem DeleteStripItem;
        private ToolStripMenuItem PropertiesStripItem;
        private ToolStripSeparator NewStripSeperator;
        private ToolStripSeparator PasteStripSeperator;
        private ToolStripSeparator DeleteStripSeperator;
        private Panel PathPanel;
        private DataGridViewTextBoxColumn IndexColumn;
        private DataGridViewImageColumn ImageCell;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ModificationDateColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewTextBoxColumn SizeColumn;
    }
}
