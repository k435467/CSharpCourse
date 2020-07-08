using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz6;
using System.Collections;

namespace _106_Quiz6
{
    public partial class Form1 : Form
    {
        //private Ball[] ballArr = new Ball[100];
        //private Cube[] cubeArr = new Cube[100];
        //private Cylinder[] cylinderArr = new Cylinder[100];
        //private Pyramid[] pyramidArr = new Pyramid[100];
        private Shape3D[] shapeArr = new Shape3D[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    shapeArr[Shape3D.Amount] = new Ball(Double.Parse(txtPara1.Text), Double.Parse(txtDensity.Text));
                    //txtMessage.AppendText(ballArr[Ball.Amount-1].ShapeProperty());
                    break;
                case "立方體":
                    shapeArr[Shape3D.Amount] = new Cube(Double.Parse(txtPara1.Text), Double.Parse(txtDensity.Text));
                    //txtMessage.AppendText(cubeArr[Cube.Amount-1].ShapeProperty());
                    break;
                case "圓柱體":
                    shapeArr[Shape3D.Amount] = new Cylinder(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text),Double.Parse(txtDensity.Text));
                    //txtMessage.AppendText(cylinderArr[Cylinder.Amount-1].ShapeProperty());
                    break;
                case "金字塔":
                    shapeArr[Shape3D.Amount] = new Pyramid(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text),Double.Parse(txtDensity.Text));
                    //txtMessage.AppendText(pyramidArr[Pyramid.Amount-1].ShapeProperty());
                    break;
                default:
                    break;
            }
            //txtMessage.AppendText("\r\n");
            //txtAmountOfShape.Text = (Ball.Amount + Cube.Amount + Cylinder.Amount + Pyramid.Amount).ToString();
            txtAmountOfShape.Text = Shape3D.Amount.ToString();
            txtBallAmount.Text = Ball.Amount.ToString();
            txtCubeAmount.Text = Cube.Amount.ToString();
            txtCylinderAmount.Text = Cylinder.Amount.ToString();
            txtPyramidAmount.Text = Pyramid.Amount.ToString();

            txtMessage.Text = ShowAllInfo();
        }

        private string ShowAllInfo()
        {
            string str = "";
            for (int i=0; i<Shape3D.Amount; i++)
            {
                str += shapeArr[i].ShapeProperty() + "\r\n";
            }
            return str;
        }

        private void cboxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    lblPara1.Text = "半徑";
                    lblPara2.Visible= false;
                    txtPara2.Visible = false;
                    break;
                case "立方體":
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = false;
                    txtPara2.Visible = false;
                    break;
                case "圓柱體":
                    lblPara1.Text = "半徑";
                    lblPara2.Visible = true;
                    lblPara2.Text = "高";
                    txtPara2.Visible = true;
                    break;
                case "金字塔":
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = true;
                    lblPara2.Text = "高";
                    txtPara2.Visible = true;
                    break;
                default:
                    break;

            }

        }

        private void cBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = cBoxMaterial.SelectedItem.ToString();
            double density;
            bool canModified = false;
            switch (material)
            {
                case "鋁":
                    density = 2.7; 
                    break;
                case "鐵":
                    density = 7.87;
                    break;
                case "鉛":
                    density = 11.3;
                    break;
               
                default:
                    density = 0;
                    canModified = true;
                    break;
            }
            txtDensity.Text = density.ToString();
            if (!canModified)
                txtDensity.Enabled = false;
        }

        private void btn_FindHeaviestShape_Click(object sender, EventArgs e)
        {
            string info = "";
            double maxWeight = 0;
            for (int i=0; i<Shape3D.Amount; i++)
            {
                if (shapeArr[i].Weight() > maxWeight)
                {
                    maxWeight = shapeArr[i].Weight();
                    info = shapeArr[i].ShapeProperty();
                }
            }
            //int index = 0;
            //while (ballArr[index]!=null)
            //{
            //    if(ballArr[index].Weight() > maxWeight)
            //    {
            //        maxWeight = ballArr[index].Weight();
            //        info = ballArr[index].ShapeProperty();
            //    }
            //    index++;
            //}

            //index = 0;
            //while (cubeArr[index] != null)
            //{
            //    if (cubeArr[index].Weight() > maxWeight)
            //    {
            //        maxWeight = cubeArr[index].Weight();
            //        info = cubeArr[index].ShapeProperty();
            //    }
            //    index++;
            //}

            //index = 0;
            //while (pyramidArr[index] != null)
            //{
            //    if (pyramidArr[index].Weight() > maxWeight)
            //    {
            //        maxWeight = pyramidArr[index].Weight();
            //        info = pyramidArr[index].ShapeProperty();
            //    }
            //    index++;
            //}

            //index = 0;
            //while (cylinderArr[index] != null)
            //{
            //    if (cylinderArr[index].Weight() > maxWeight)
            //    {
            //        maxWeight = cylinderArr[index].Weight();
            //        info = cylinderArr[index].ShapeProperty();
            //    }
            //    index++;
            //}
            txt_ShowHeaviestShape.Text = info;
        }
    }
}
