using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace MyControls
{
    [Designer(typeof(WindowContainerDesigner))]
    public partial class WindowContainer : UserControl
    {
        public int FirstRun = 0;

        private ContextMenuStrip _DropDownMenu;

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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentPanel
        {
            get { return this._ContentPanel; }
        }

        public WindowContainer()
        {
            InitializeComponent();
        }

        public void AddControl(Control control)
        {
            Table.Controls.Add(control, 0, 1);
        }

        private void HeaderDropdown_Click(object sender, EventArgs e)
        {
            if (_DropDownMenu != null)
            {
                int left = HeaderDropdown.Bounds.Left;
                int bottom = HeaderDropdown.Bounds.Top + HeaderDropdown.Bounds.Height;
                _DropDownMenu.Show(this, new Point { X = left, Y = bottom });
            }
        }

        private void HeaderClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        protected override void OnControlAdded(ControlEventArgs e)
        {
            

            if (FirstRun != 0)
            {
                Controls.Remove(e.Control);
                
                AddControl(e.Control);
            }
            else
            {
                base.OnControlAdded(e);
            }
            FirstRun++;

        }

    }
	
	
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


