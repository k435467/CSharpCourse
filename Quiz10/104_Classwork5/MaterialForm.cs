using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz7;

namespace _106_Quiz9
{
    public partial class MaterialForm : Form
    {
        public delegate void SetMaterialHandler(object sender, SetMaterialEventArgs args);
        public event SetMaterialHandler matHandler;
        public MaterialForm()
        {
            InitializeComponent();
        }

        private void btn_AL_Click(object sender, EventArgs e)
        {
            if(matHandler!=null)
            {
                SetMaterialEventArgs matArgs = new SetMaterialEventArgs();
                matArgs.MType = ShapeType.Material.Al;
                matHandler(this, matArgs);
            }
        }

        private void btn_FE_Click(object sender, EventArgs e)
        {
            if (matHandler != null)
            {
                SetMaterialEventArgs matArgs = new SetMaterialEventArgs();
                matArgs.MType = ShapeType.Material.Fe;
                matHandler(this, matArgs);
            }
        }

        private void btn_PB_Click(object sender, EventArgs e)
        {
            if (matHandler != null)
            {
                SetMaterialEventArgs matArgs = new SetMaterialEventArgs();
                matArgs.MType = ShapeType.Material.Pb;
                matHandler(this, matArgs);
            }
        }
    }
}
