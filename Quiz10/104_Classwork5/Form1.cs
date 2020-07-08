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
using _106_Classwork8;
using _106_Quiz9;
using System.Collections;
using _104_Classwork5;

namespace _106_Quiz6
{
    public partial class Form1 : Form
    {
        private List<Shape3D> shapeArr = new List<Shape3D>();      // 使用 ArrayList 來儲存產生的形狀物件
        private List<IRollable> _mRollShapeList = new List<IRollable>(); 
        private delegate bool CompareFunc(Shape3D a, Shape3D b);    //利用委託來傳函式給另一個函式使用
        private ShapeType.Material _mType;   //紀錄材料類別的欄位, 被兩個事件用到, 故需宣告為類別變數
        public Form1()
        {
            InitializeComponent();
            cboxShape.SelectedIndex = 0;        //初始化 comboBox 避免出問題
            cboxSortType.SelectedIndex = 0;     //初始化 comboBox 避免出問題
            txtDensity.Enabled = false;        //取消自行輸入密度的選項
            txtPara2.Text = "0";
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            Shape3D newShape = null;
            string shape = cboxShape.SelectedItem.ToString();
            try
            {
                newShape = ShapeFactory.Create(shape, _mType, Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text));
            }
            catch ( FormatException ef )
            {
                MessageBox.Show( ef.Message );
            }
            catch (NegativeException en)
            {
                MessageBox.Show(en.Message);
            }
            finally
            {
                if (newShape != null)
                {
                    shapeArr.Add(newShape);
                    txtAmountOfShape.Text = Shape3D.Amount.ToString();
                    txtBallAmount.Text = Ball.Amount.ToString();
                    txtCubeAmount.Text = Cube.Amount.ToString();
                    txtCylinderAmount.Text = Cylinder.Amount.ToString();
                    txtPyramidAmount.Text = Pyramid.Amount.ToString();
                    ShowAllShapeInfo(txtMessage);
                }
            }
            //switch (shape)
            //{
            //    case "球":
            //        shapeArr.Add(new Ball(Double.Parse(txtPara1.Text), _mType));    // new 出 Ball 物件, 並將其加入 shapeArr中
            //        break;
            //    case "立方體":
            //        shapeArr.Add(new Cube(Double.Parse(txtPara1.Text), _mType));
            //        break;
            //    case "圓柱體":
            //        shapeArr.Add(new Cylinder(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text), _mType));
            //        break;
            //    case "金字塔":
            //        shapeArr.Add(new Pyramid(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text), _mType));
            //        break;
            //    default:
            //        break;
            //}
        }
        private void ShowAllShapeInfo(TextBox msg)
        {
            string info="";
            foreach(var shape in shapeArr)
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


        //以下為排序功能所需的函數
        private bool CompareByShapeTypeAscent(Shape3D a, Shape3D b)  //Ascent =true 時遞增 =false 時遞減
        {
            if (a.GeoType > b.GeoType)
                return true;
            else
                return false;

        }
        private bool CompareByShapeTypeDescent(Shape3D a, Shape3D b)  //Ascent =true 時遞增 =false 時遞減
        {
            if (a.GeoType < b.GeoType)
                return true;
            else
                return false;

        }
        private bool CompareByMaterialAscent(Shape3D a, Shape3D b)  //Ascent =true 時遞增 =false 時遞減
        {
            if (a.MaterialType > b.MaterialType)
                return true;
            else
                return false;

        }
        private bool CompareByMaterialDescent(Shape3D a, Shape3D b)  //Ascent =true 時遞增 =false 時遞減
        {
            if (a.MaterialType < b.MaterialType)
                return true;
            else
                return false;

        }
        private bool CompareByVolumnAscent(Shape3D a, Shape3D b)  //Ascent =true 時遞增 =false 時遞減
        {
            if (a.Volume() > b.Volume())
                return true;
            else
                return false;

        }
        private bool CompareByVolumnDescent(Shape3D a, Shape3D b)  //Ascent =true 時遞增 =false 時遞減
        {
            if (a.Volume() < b.Volume())
                return true;
            else
                return false;

        }
        private bool CompareByWeightAscent(Shape3D a, Shape3D b)  //Ascent =true 時遞增 =false 時遞減
        {
            if (a.Weight() > b.Weight())
                return true;
            else
                return false;
        }
        private bool CompareByWeightDescent(Shape3D a, Shape3D b)  //Ascent =true 時遞增 =false 時遞減
        {
            if (a.Weight() < b.Weight())
                return true;
            else
                return false;
        }
        

        private void BubbleSort(CompareFunc cmp)   //利用委託的方式將 比較函式 傳進 排序函式中, 可以精簡程式碼
        {
            Shape3D temp;   
            for (int pass = 0; pass < shapeArr.Count; pass++)
            {
                for (int i = 0; i < shapeArr.Count - 1; i++)
                {
                    if (cmp(shapeArr[i],shapeArr[i + 1]))      
                    {
                        temp = shapeArr[i];
                        shapeArr[i] = shapeArr[i + 1];
                        shapeArr[i + 1] = temp;
                    }
                }
            }
        }

        private void btnCofirmSort_Click(object sender, EventArgs e)
        {
            switch (cboxSortType.SelectedItem.ToString())
            {
                case "形狀":
                    if (rBtnAscent.Checked)
                        BubbleSort(CompareByShapeTypeAscent);
                    else
                        BubbleSort(CompareByShapeTypeDescent);
                    break;
                case "材料":
                    if (rBtnAscent.Checked)
                        BubbleSort(CompareByMaterialAscent);
                    else
                        BubbleSort(CompareByMaterialDescent);
                    break;
                case "體積":
                    if (rBtnAscent.Checked)
                        BubbleSort(CompareByVolumnAscent);
                    else
                        BubbleSort(CompareByVolumnDescent);
                    break;
                case "重量":
                    if (rBtnAscent.Checked)
                        BubbleSort(CompareByWeightAscent);
                    else
                        BubbleSort(CompareByWeightDescent);
                    break;
                default:
                    break;
            }
            ShowAllShapeInfo(txtSortMessage);
        }

        //以下為滾球大賽的程式碼
        private void btn_RollContest_Click(object sender, EventArgs e)
        {
            IRollable rollShape = null;
            _mRollShapeList.Clear();
            //從 shapeArr 中尋找屬於 IRollable 的物件並加入 _mRollShapeList
            foreach (var shape in shapeArr)
            {
                rollShape = shape as IRollable;
                if (null != rollShape)
                    _mRollShapeList.Add(rollShape);
            }
            _mRollShapeList.Sort(CompareByDistance); //使用 List 的內建Sort函式
            ShowRollShapeInfo(txt_RollContest);
        }

        private int CompareByDistance(IRollable a, IRollable b)  //使用List 內定的 Sort時, 回傳型態是整數
        {
            if (a.Distance() > b.Distance())
                return -1;
            else
                return 1;
        }

        private void ShowRollShapeInfo(TextBox msg)
        {
            string info = "";
            foreach (var rollShape in _mRollShapeList)
            {
                info += (rollShape.RollShapeProperty() + "\r\n");
            }
            msg.Text = info;
        }

        private void btn_MaterialSel_Click(object sender, EventArgs e)
        {
            MaterialForm mForm = new MaterialForm();
            mForm.Show();
            mForm.matHandler += new MaterialForm.SetMaterialHandler(setMaterialProperties);

        }
        private void setMaterialProperties(object sender, SetMaterialEventArgs e)
        {
            _mType = e.MType;
            txtMaterial.Text = MaterialTable.Name(e.MType);
            txtDensity.Text = MaterialTable.Density(e.MType).ToString();
        }
    }
}
