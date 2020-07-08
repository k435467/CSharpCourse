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
using _106_Quiz7;
using System.Collections;

namespace _106_Quiz6
{
    public partial class Form1 : Form
    {
        //private Shape3D[] shapeArr = new Shape3D[100];
        private ArrayList shapeArr = new ArrayList();
        private delegate bool CompareFunc(Shape3D a, Shape3D b);
        private ShapeType.Material _mType;
        public Form1()
        {
            InitializeComponent();
            cBoxMaterial.SelectedIndex = 0;
            cboxShape.SelectedIndex = 0;
            cboxSortMode.SelectedIndex = 0;
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    shapeArr.Add(new Ball(Double.Parse(txtPara1.Text), _mType));
                    break;
                case "立方體":
                    shapeArr.Add(new Cube(Double.Parse(txtPara1.Text), _mType));
                    break;
                case "圓柱體":
                    shapeArr.Add(new Cylinder(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text), _mType));
                    break;
                case "金字塔":
                    shapeArr.Add(new Pyramid(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text), _mType));
                    break;
                default:
                    break;
            }
            txtAmountOfShape.Text = Shape3D.Amount.ToString();
            txtBallAmount.Text = Ball.Amount.ToString();
            txtCubeAmount.Text = Cube.Amount.ToString();
            txtCylinderAmount.Text = Cylinder.Amount.ToString();
            txtPyramidAmount.Text = Pyramid.Amount.ToString();
            ShowAllShapeInfo(txtMessage);
        }
        private void ShowAllShapeInfo(TextBox msg)
        {
            string info="";
            foreach (Shape3D shape in shapeArr)
            {
                info += (shape.ShapeProperty() + "\r\n");
            }
            msg.Text = info;
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
                    _mType = ShapeType.Material.Al;
                    density = 2.7; 
                    break;
                case "鐵":
                    _mType = ShapeType.Material.Fe;
                    density = 7.87;
                    break;
                case "鉛":
                    _mType = ShapeType.Material.Pb;
                    density = 11.3;
                    break;
               
                default:
                    _mType = ShapeType.Material.UNKNOW;
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
            int index = 0;
            foreach (Shape3D shape in shapeArr)
            {
                if(shape.Weight() > maxWeight)
                {
                    maxWeight = shape.Weight();
                    info = shape.ShapeProperty();
                }
                index++;
            }
            txt_ShowHeaviestShape.Text = info;
        }

        private bool CompareByGeoA(Shape3D a, Shape3D b)
        {
            return a.Geo > b.Geo;
        }
        private bool CompareByGeoD(Shape3D a, Shape3D b)
        {
            return a.Geo < b.Geo;
        }
        private bool CompareByMaterialA(Shape3D a, Shape3D b)
        {
            return a.Material > b.Material;
        }
        private bool CompareByMaterialD(Shape3D a, Shape3D b)
        {
            return a.Material < b.Material;
        }
        private bool CompareByVolumnA(Shape3D a, Shape3D b)
        {
            return a.Volume() > b.Volume();
        }
        private bool CompareByVolumnD(Shape3D a, Shape3D b)
        {
            return a.Volume() < b.Volume();
        }
        private bool CompareByWeightA(Shape3D a, Shape3D b)
        {
            return a.Weight() > b.Weight();
        }
        private bool CompareByWeightD(Shape3D a, Shape3D b)
        {
            return a.Weight() < b.Weight();
        }

        private void BubbleSort(CompareFunc cmp)
        {
            object tmp;
            for (int pass=0; pass<shapeArr.Count; pass++)
            {
                for (int i=0; i<shapeArr.Count-1; i++)
                {
                    if (cmp((Shape3D)shapeArr[i], (Shape3D)shapeArr[i+1]))
                    {
                        tmp = shapeArr[i];
                        shapeArr[i] = shapeArr[i + 1];
                        shapeArr[i + 1] = tmp;
                    }
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            switch (cboxSortMode.SelectedItem.ToString())
            {
                case "形狀":
                    if (rbtnAscent.Checked)
                        BubbleSort(CompareByGeoA);
                    else
                        BubbleSort(CompareByGeoD);
                    break;
                case "材料":
                    if (rbtnAscent.Checked)
                        BubbleSort(CompareByMaterialA);
                    else
                        BubbleSort(CompareByMaterialD);
                    break;
                case "體積":
                    if (rbtnAscent.Checked)
                        BubbleSort(CompareByVolumnA);
                    else
                        BubbleSort(CompareByVolumnD);
                    break;
                case "重量":
                    if (rbtnAscent.Checked)
                        BubbleSort(CompareByWeightA);
                    else
                        BubbleSort(CompareByWeightD);
                    break;
            }
            ShowAllShapeInfo(txtSort);
        }
    }
}
