namespace MyControls
{
    partial class WindowContainer
    {
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowContainer));
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderStrip = new System.Windows.Forms.ToolStrip();
            this.HeaderLabel = new System.Windows.Forms.ToolStripLabel();
            this.HeaderClose = new System.Windows.Forms.ToolStripButton();
            this.HeaderDropdown = new System.Windows.Forms.ToolStripButton();
            this._ContentPanel = new System.Windows.Forms.Panel();
            this.Table.SuspendLayout();
            this.HeaderStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Controls.Add(this.HeaderStrip, 0, 0);
            this.Table.Controls.Add(this._ContentPanel, 0, 1);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Size = new System.Drawing.Size(254, 290);
            this.Table.TabIndex = 0;
            // 
            // HeaderStrip
            // 
            this.HeaderStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeaderLabel,
            this.HeaderClose,
            this.HeaderDropdown});
            this.HeaderStrip.Location = new System.Drawing.Point(2, 2);
            this.HeaderStrip.Name = "HeaderStrip";
            this.HeaderStrip.ShowItemToolTips = false;
            this.HeaderStrip.Size = new System.Drawing.Size(250, 25);
            this.HeaderStrip.TabIndex = 0;
            this.HeaderStrip.Text = "toolStrip1";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(49, 22);
            this.HeaderLabel.Text = "Header";
            // 
            // HeaderClose
            // 
            this.HeaderClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HeaderClose.AutoToolTip = false;
            this.HeaderClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HeaderClose.Image = ((System.Drawing.Image)(resources.GetObject("HeaderClose.Image")));
            this.HeaderClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HeaderClose.Name = "HeaderClose";
            this.HeaderClose.Size = new System.Drawing.Size(23, 22);
            this.HeaderClose.Text = "toolStripButton1";
            this.HeaderClose.Click += new System.EventHandler(this.HeaderClose_Click);
            // 
            // HeaderDropdown
            // 
            this.HeaderDropdown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HeaderDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HeaderDropdown.Image = ((System.Drawing.Image)(resources.GetObject("HeaderDropdown.Image")));
            this.HeaderDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HeaderDropdown.Name = "HeaderDropdown";
            this.HeaderDropdown.Size = new System.Drawing.Size(23, 22);
            this.HeaderDropdown.Text = "toolStripButton2";
            this.HeaderDropdown.Click += new System.EventHandler(this.HeaderDropdown_Click);
            // 
            // _ContentPanel
            // 
            this._ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ContentPanel.Location = new System.Drawing.Point(7, 34);
            this._ContentPanel.Margin = new System.Windows.Forms.Padding(5);
            this._ContentPanel.Name = "_ContentPanel";
            this._ContentPanel.Size = new System.Drawing.Size(240, 249);
            this._ContentPanel.TabIndex = 1;
            // 
            // WindowContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table);
            this.Name = "WindowContainer";
            this.Size = new System.Drawing.Size(254, 290);
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.HeaderStrip.ResumeLayout(false);
            this.HeaderStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        public System.Windows.Forms.ToolStrip HeaderStrip;
        private System.Windows.Forms.ToolStripLabel HeaderLabel;
        private System.Windows.Forms.ToolStripButton HeaderClose;
        private System.Windows.Forms.ToolStripButton HeaderDropdown;
        private System.Windows.Forms.Panel _ContentPanel;
    }
}
