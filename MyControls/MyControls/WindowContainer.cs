using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace MyControls
{
    [Designer(typeof(WindowContainerDesigner))]
    public partial class WindowContainer : UserControl
    {

        private ContextMenuStrip _DropDownMenu;

        /// <summary>
        /// If a contextmenustrip is set in the designer it will enable the arrow button.
        /// </summary>
        public ContextMenuStrip DropDownMenu
        {
            get
            {
                return _DropDownMenu;
            }
            set
            {
                _DropDownMenu = value;

                if (HeaderStrip.Items.ContainsKey("HeaderDropdown"))
                {
                    HeaderStrip.Items["HeaderDropdown"].Dispose();
                }

                if (value != null)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(WindowContainer));
                    HeaderDropdown = new ToolStripButton();
                    HeaderDropdown.Alignment = ToolStripItemAlignment.Right;
                    HeaderDropdown.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    HeaderDropdown.Image = ((Image)(resources.GetObject("HeaderDropdown.Image")));
                    HeaderDropdown.ImageTransparentColor = Color.Magenta;
                    HeaderDropdown.Name = "HeaderDropdown";
                    HeaderDropdown.Size = new Size(23, 22);
                    HeaderDropdown.Text = "HeaderDropdown";
                    HeaderDropdown.Click += new EventHandler(this.HeaderDropdown_Click);
                    HeaderStrip.Items.Add(HeaderDropdown);
                }
            }
        }

        public WindowContainer()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentPanel
        {
            get { return this._ContentPanel; }
        }

        /// <summary>
        /// This sets the contextmenustrip position to where the arrow button is located. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeaderDropdown_Click(object sender, EventArgs e)
        {
            if (_DropDownMenu != null)
            {
                int left = HeaderDropdown.Bounds.Left;
                int bottom = HeaderDropdown.Bounds.Top + HeaderDropdown.Bounds.Height;
                _DropDownMenu.Show(this, new Point { X = left, Y = bottom });
            }
        }

        /// <summary>
        /// This will hide the window instead of disposing of it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeaderClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
	
    /// <summary>
    /// This will enable the designer to allow modifications to the inner controls.
    /// </summary>
    internal class WindowContainerDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            EnableDesignMode((this.Control as WindowContainer).ContentPanel, "ContentPanel");
            EnableDesignMode((this.Control as WindowContainer).HeaderStrip, "HeaderStrip");
        }
    }
	
}
