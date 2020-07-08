using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBoxMaterial.SelectedItem.ToString();
            double tmpDensity = 0;
            switch (str)
            {
                case "鋁":
                    tmpDensity = 2.7;
                    break;
                case "鐵":
                    tmpDensity = 7.87;
                    break;
                case "鉛":
                    tmpDensity = 11.3;
                    break;
                default:
                    break;
            }
            txtDensity.Text = tmpDensity.ToString();
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBoxShape.SelectedItem.ToString();
            string txtArg1Display = "";
            string txtArg2Display = "";
            bool arg2isVisable = false;
            switch (str)
            {
                case "球":
                    txtArg1Display = "半徑";
                    break;
                case "立方體":
                    txtArg1Display = "邊長";
                    break;
                case "圓柱體":
                    txtArg1Display = "半徑";
                    txtArg2Display = "高";
                    arg2isVisable = true;
                    break;
                case "金字塔":
                    txtArg1Display = "邊長";
                    txtArg2Display = "高";
                    arg2isVisable = true;
                    break;
                default:
                    break;
            }
            lblArg1.Text = txtArg1Display;
            lblArg2.Text = txtArg2Display;
            lblArg2.Visible = arg2isVisable;
            txtArg2.Visible = arg2isVisable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str = comboBoxShape.SelectedItem.ToString();
            double arg1 = double.Parse(txtArg1.Text);
            double arg2 = double.Parse(txtArg2.Text);
            double density = double.Parse(txtDensity.Text);
            string strDispay = "";
            switch (str)
            {
                case "球":
                    Ball myBall = new Ball(arg1, density);
                    strDispay = myBall.Info();
                    break;
                case "立方體":
                    Cube myCube = new Cube(arg1, density);
                    strDispay = myCube.Info();
                    break;
                case "圓柱體":
                    Cylinder myCylinder = new Cylinder(arg1, arg2, density);
                    strDispay = myCylinder.Info();
                    break;
                case "金字塔":
                    Pyramid myPyramid = new Pyramid(arg1, arg2, density);
                    strDispay = myPyramid.Info();
                    break;
                default:
                    break;
            }
            txtBallAmount.Text = Ball.Amount.ToString();
            txtCubeAmount.Text = Cube.Amount.ToString();
            txtCylinderAmount.Text = Cylinder.Amount.ToString();
            txtPyramidAmount.Text = Pyramid.Amount.ToString();
            int totalAmount = Ball.Amount + Cube.Amount + Cylinder.Amount + Pyramid.Amount;
            txtTotalAmonut.Text = totalAmount.ToString();
            txtMessage.AppendText(strDispay);
        }
    }
}
