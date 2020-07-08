using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Classwork8;
using _106_Quiz7;

namespace _104_Classwork5
{
    public partial class MaterialForm : Form
    {
        public delegate void MFormEventHandler(object sender, MaterialEventArgs args);
        public event MFormEventHandler materialDelegate;
        public MaterialForm ( )
        {
            InitializeComponent( );
        }

        private void btnAl_Click ( object sender, EventArgs e )
        {
            if (materialDelegate != null)
            {
                MaterialEventArgs eArgs = new MaterialEventArgs();
                eArgs.MaterialType = ShapeType.Material.Al;
                eArgs.MaterialName = "鋁";
                materialDelegate(this, eArgs);
            }
        }

        private void btnFe_Click ( object sender, EventArgs e )
        {
            if (materialDelegate != null)
            {
                MaterialEventArgs eArgs = new MaterialEventArgs();
                eArgs.MaterialType = ShapeType.Material.Fe;
                eArgs.MaterialName = "鐵";
                materialDelegate(this, eArgs);
            }
        }

        private void btnPb_Click ( object sender, EventArgs e )
        {
            if (materialDelegate != null)
            {
                MaterialEventArgs eArgs = new MaterialEventArgs();
                eArgs.MaterialType = ShapeType.Material.Pb;
                eArgs.MaterialName = "鉛";
                materialDelegate(this, eArgs);
            }
        }
    }
}
