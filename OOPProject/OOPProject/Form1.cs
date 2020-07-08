using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sweet_shavedice.Checked = true;
            main_peanut.Checked = true;
            temp_iced.Checked = true;
        }

        List<Sweet> SweetList = new List<Sweet>();
        FoodType.SweetType SweetType;
        FoodType.TemperatureType TemperatureType;
        FoodType.MainIngredientType MainIngredientType;
        List<FoodType.SideIngredientType> SideIngredientList = new List<FoodType.SideIngredientType>();
        int TotalPrice = 0;
        

        private void sweet_shavedice_CheckedChanged(object sender, EventArgs e)
        {
            if (sweet_douhua.Checked)
            {
                SweetType = FoodType.SweetType.Douhua;
                gbx_temp.Visible = true;
                temp_iced.Visible = true;
                temp_warm.Visible = true;
            }
            else
            {
                SweetType = FoodType.SweetType.ShavedIce;
                gbx_temp.Visible = false;
                temp_iced.Visible = false;
                temp_warm.Visible = false;
            }
        }

        private void main_peanut_CheckedChanged ( object sender, EventArgs e )
        {
            if (main_bianren.Checked)
                MainIngredientType = FoodType.MainIngredientType.Bianren;
            else if (main_fenguo.Checked)
                MainIngredientType = FoodType.MainIngredientType.FenGuo;
            else if (main_greenbean.Checked)
                MainIngredientType = FoodType.MainIngredientType.GreenBean;
            else if (main_peanut.Checked)
                MainIngredientType = FoodType.MainIngredientType.Peanut;
            else if (main_rainbowtangyuan.Checked)
                MainIngredientType = FoodType.MainIngredientType.RanbowTangyan;
            else if (main_redbean.Checked)
                MainIngredientType = FoodType.MainIngredientType.RedBean;
            else if (main_taroball.Checked)
                MainIngredientType = FoodType.MainIngredientType.TaroBall;
        }

        private void side_redbean_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.RedBean);
        }

        private void side_peanut_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.Peanut);
        }

        private void side_greenbean_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.GreenBean);
        }

        private void side_bianren_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.Bianren);
        }

        private void side_pearl_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.Pearl);
        }

        private void side_taroball_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.Taro);
        }

        private void side_condensedmilk_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.CondensedMilk);
        }

        private void side_grassjelly_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.GrassJelly);
        }

        private void side_greenpapaya_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.GreenPapaya);
        }

        private void side_fenguo_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.FenGuo);
        }

        private void side_tangyuan_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.Tangyuan);
        }

        private void side_honeydew_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.Honeydew);
        }

        private void side_taro_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.Taro);
        }

        private void side_rainbowtangyuan_Click ( object sender, EventArgs e )
        {
            if (SideIngredientList.Count < 10)
                SideIngredientList.Add(FoodType.SideIngredientType.TaroBall);
        }

        // Temp 
        private void temp_iced_CheckedChanged ( object sender, EventArgs e )
        {
            if (temp_iced.Checked)
                TemperatureType = FoodType.TemperatureType.Iced;
            else
                TemperatureType = FoodType.TemperatureType.Warm;
        }

        // ADD

        private void btn_add_Click ( object sender, EventArgs e )
        {
            SweetList.Add(SweetFactory.CreateSweet(SweetType, TemperatureType, MainIngredientType, SideIngredientList));

            foreach (var sweet in SweetList)
            {
                txt_msg.AppendText(string.Format("{0:5}\t", sweet.Cost().ToString()));
                txt_msg.AppendText(string.Format("{0}",sweet.Description));
                txt_msg.AppendText(Environment.NewLine);
                TotalPrice += sweet.Cost();
            }
            txt_price.Text = TotalPrice.ToString();
            SideIngredientList.Clear();
            SweetList.Clear();
        }

        private void btn_clear_Click ( object sender, EventArgs e )
        {
            TotalPrice = 0;
            txt_price.Text = TotalPrice.ToString();
            SideIngredientList.Clear();
            SweetList.Clear();
            txt_msg.Clear();
        }
    }
}
