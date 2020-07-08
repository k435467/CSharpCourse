using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz4;

namespace Quiz5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle();
            t.CreatePoints();
            t.ptArr[0].xCoord = double.Parse(txtP1X.Text);
            t.ptArr[0].yCoord = double.Parse(txtP1Y.Text);
            t.ptArr[1].xCoord = double.Parse(txtP2X.Text);
            t.ptArr[1].yCoord = double.Parse(txtP2Y.Text);
            t.ptArr[2].xCoord = double.Parse(txtP3X.Text);
            t.ptArr[2].yCoord = double.Parse(txtP3Y.Text);

            string strDisplay = "";
            if (cbArea.Checked)
                if (t.isValid())
                    strDisplay += "Area = " + t.Area() + Environment.NewLine;
            if (cbPerimeter.Checked)
                if (t.isValid())
                    strDisplay += "Perimeter = " + t.Perimeter() + Environment.NewLine;
            if (cbTriangleType.Checked)
            {
                if (t.isValid())
                {
                    string[] strTriangleType = { "", "直角三角形", "銳角三角形", "鈍角三角形" };
                    strDisplay += "此三角形為" + strTriangleType[t.ShapeType()] + Environment.NewLine;
                }
                else
                    strDisplay += "此三點不能形成三角形" + Environment.NewLine;
            }

            txtDisplay.AppendText(strDisplay);
        }
    }
}
