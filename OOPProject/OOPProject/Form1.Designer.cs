namespace OOPProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sweet_douhua = new System.Windows.Forms.RadioButton();
            this.sweet_shavedice = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.main_rainbowtangyuan = new System.Windows.Forms.RadioButton();
            this.main_bianren = new System.Windows.Forms.RadioButton();
            this.main_taroball = new System.Windows.Forms.RadioButton();
            this.main_greenbean = new System.Windows.Forms.RadioButton();
            this.main_redbean = new System.Windows.Forms.RadioButton();
            this.main_fenguo = new System.Windows.Forms.RadioButton();
            this.main_peanut = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.side_rainbowtangyuan = new System.Windows.Forms.Button();
            this.side_taro = new System.Windows.Forms.Button();
            this.side_fenguo = new System.Windows.Forms.Button();
            this.side_condensedmilk = new System.Windows.Forms.Button();
            this.side_honeydew = new System.Windows.Forms.Button();
            this.side_greenpapaya = new System.Windows.Forms.Button();
            this.side_grassjelly = new System.Windows.Forms.Button();
            this.side_tangyuan = new System.Windows.Forms.Button();
            this.side_taroball = new System.Windows.Forms.Button();
            this.side_pearl = new System.Windows.Forms.Button();
            this.side_bianren = new System.Windows.Forms.Button();
            this.side_greenbean = new System.Windows.Forms.Button();
            this.side_peanut = new System.Windows.Forms.Button();
            this.side_redbean = new System.Windows.Forms.Button();
            this.gbx_temp = new System.Windows.Forms.GroupBox();
            this.temp_warm = new System.Windows.Forms.RadioButton();
            this.temp_iced = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbx_temp.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(6, 21);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_msg.Size = new System.Drawing.Size(513, 293);
            this.txt_msg.TabIndex = 1;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(412, 70);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(107, 22);
            this.txt_price.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sweet_douhua);
            this.groupBox1.Controls.Add(this.sweet_shavedice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "甜品";
            // 
            // sweet_douhua
            // 
            this.sweet_douhua.AutoSize = true;
            this.sweet_douhua.Location = new System.Drawing.Point(115, 21);
            this.sweet_douhua.Name = "sweet_douhua";
            this.sweet_douhua.Size = new System.Drawing.Size(101, 16);
            this.sweet_douhua.TabIndex = 4;
            this.sweet_douhua.TabStop = true;
            this.sweet_douhua.Text = "古早味豆花: 50";
            this.sweet_douhua.UseVisualStyleBackColor = true;
            // 
            // sweet_shavedice
            // 
            this.sweet_shavedice.AutoSize = true;
            this.sweet_shavedice.Location = new System.Drawing.Point(6, 21);
            this.sweet_shavedice.Name = "sweet_shavedice";
            this.sweet_shavedice.Size = new System.Drawing.Size(89, 16);
            this.sweet_shavedice.TabIndex = 4;
            this.sweet_shavedice.TabStop = true;
            this.sweet_shavedice.Text = "黑糖刨冰: 50";
            this.sweet_shavedice.UseVisualStyleBackColor = true;
            this.sweet_shavedice.CheckedChanged += new System.EventHandler(this.sweet_shavedice_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.main_rainbowtangyuan);
            this.groupBox2.Controls.Add(this.main_bianren);
            this.groupBox2.Controls.Add(this.main_taroball);
            this.groupBox2.Controls.Add(this.main_greenbean);
            this.groupBox2.Controls.Add(this.main_redbean);
            this.groupBox2.Controls.Add(this.main_fenguo);
            this.groupBox2.Controls.Add(this.main_peanut);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "主料";
            // 
            // main_rainbowtangyuan
            // 
            this.main_rainbowtangyuan.AutoSize = true;
            this.main_rainbowtangyuan.Location = new System.Drawing.Point(10, 87);
            this.main_rainbowtangyuan.Name = "main_rainbowtangyuan";
            this.main_rainbowtangyuan.Size = new System.Drawing.Size(89, 16);
            this.main_rainbowtangyuan.TabIndex = 5;
            this.main_rainbowtangyuan.TabStop = true;
            this.main_rainbowtangyuan.Text = "彩虹湯圓: 20";
            this.main_rainbowtangyuan.UseVisualStyleBackColor = true;
            // 
            // main_bianren
            // 
            this.main_bianren.AutoSize = true;
            this.main_bianren.Location = new System.Drawing.Point(115, 65);
            this.main_bianren.Name = "main_bianren";
            this.main_bianren.Size = new System.Drawing.Size(65, 16);
            this.main_bianren.TabIndex = 5;
            this.main_bianren.TabStop = true;
            this.main_bianren.Text = "薏仁: 10";
            this.main_bianren.UseVisualStyleBackColor = true;
            // 
            // main_taroball
            // 
            this.main_taroball.AutoSize = true;
            this.main_taroball.Location = new System.Drawing.Point(10, 65);
            this.main_taroball.Name = "main_taroball";
            this.main_taroball.Size = new System.Drawing.Size(65, 16);
            this.main_taroball.TabIndex = 5;
            this.main_taroball.TabStop = true;
            this.main_taroball.Text = "芋圓: 10";
            this.main_taroball.UseVisualStyleBackColor = true;
            // 
            // main_greenbean
            // 
            this.main_greenbean.AutoSize = true;
            this.main_greenbean.Location = new System.Drawing.Point(115, 43);
            this.main_greenbean.Name = "main_greenbean";
            this.main_greenbean.Size = new System.Drawing.Size(65, 16);
            this.main_greenbean.TabIndex = 5;
            this.main_greenbean.TabStop = true;
            this.main_greenbean.Text = "綠豆: 10";
            this.main_greenbean.UseVisualStyleBackColor = true;
            // 
            // main_redbean
            // 
            this.main_redbean.AutoSize = true;
            this.main_redbean.Location = new System.Drawing.Point(10, 43);
            this.main_redbean.Name = "main_redbean";
            this.main_redbean.Size = new System.Drawing.Size(65, 16);
            this.main_redbean.TabIndex = 5;
            this.main_redbean.TabStop = true;
            this.main_redbean.Text = "紅豆: 10";
            this.main_redbean.UseVisualStyleBackColor = true;
            // 
            // main_fenguo
            // 
            this.main_fenguo.AutoSize = true;
            this.main_fenguo.Location = new System.Drawing.Point(115, 21);
            this.main_fenguo.Name = "main_fenguo";
            this.main_fenguo.Size = new System.Drawing.Size(65, 16);
            this.main_fenguo.TabIndex = 5;
            this.main_fenguo.TabStop = true;
            this.main_fenguo.Text = "粉粿: 10";
            this.main_fenguo.UseVisualStyleBackColor = true;
            // 
            // main_peanut
            // 
            this.main_peanut.AutoSize = true;
            this.main_peanut.Location = new System.Drawing.Point(10, 21);
            this.main_peanut.Name = "main_peanut";
            this.main_peanut.Size = new System.Drawing.Size(65, 16);
            this.main_peanut.TabIndex = 5;
            this.main_peanut.TabStop = true;
            this.main_peanut.Text = "花生: 10";
            this.main_peanut.UseVisualStyleBackColor = true;
            this.main_peanut.CheckedChanged += new System.EventHandler(this.main_peanut_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.side_rainbowtangyuan);
            this.groupBox3.Controls.Add(this.side_taro);
            this.groupBox3.Controls.Add(this.side_fenguo);
            this.groupBox3.Controls.Add(this.side_condensedmilk);
            this.groupBox3.Controls.Add(this.side_honeydew);
            this.groupBox3.Controls.Add(this.side_greenpapaya);
            this.groupBox3.Controls.Add(this.side_grassjelly);
            this.groupBox3.Controls.Add(this.side_tangyuan);
            this.groupBox3.Controls.Add(this.side_taroball);
            this.groupBox3.Controls.Add(this.side_pearl);
            this.groupBox3.Controls.Add(this.side_bianren);
            this.groupBox3.Controls.Add(this.side_greenbean);
            this.groupBox3.Controls.Add(this.side_peanut);
            this.groupBox3.Controls.Add(this.side_redbean);
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 179);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "配料";
            // 
            // side_rainbowtangyuan
            // 
            this.side_rainbowtangyuan.Location = new System.Drawing.Point(127, 137);
            this.side_rainbowtangyuan.Name = "side_rainbowtangyuan";
            this.side_rainbowtangyuan.Size = new System.Drawing.Size(116, 23);
            this.side_rainbowtangyuan.TabIndex = 15;
            this.side_rainbowtangyuan.Text = "彩虹小湯圓: 20";
            this.side_rainbowtangyuan.UseVisualStyleBackColor = true;
            this.side_rainbowtangyuan.Click += new System.EventHandler(this.side_rainbowtangyuan_Click);
            // 
            // side_taro
            // 
            this.side_taro.Location = new System.Drawing.Point(6, 137);
            this.side_taro.Name = "side_taro";
            this.side_taro.Size = new System.Drawing.Size(115, 23);
            this.side_taro.TabIndex = 14;
            this.side_taro.Text = "蜜芋頭: 20";
            this.side_taro.UseVisualStyleBackColor = true;
            this.side_taro.Click += new System.EventHandler(this.side_taro_Click);
            // 
            // side_fenguo
            // 
            this.side_fenguo.Location = new System.Drawing.Point(168, 108);
            this.side_fenguo.Name = "side_fenguo";
            this.side_fenguo.Size = new System.Drawing.Size(75, 23);
            this.side_fenguo.TabIndex = 13;
            this.side_fenguo.Text = "粉粿: 10";
            this.side_fenguo.UseVisualStyleBackColor = true;
            this.side_fenguo.Click += new System.EventHandler(this.side_fenguo_Click);
            // 
            // side_condensedmilk
            // 
            this.side_condensedmilk.Location = new System.Drawing.Point(87, 108);
            this.side_condensedmilk.Name = "side_condensedmilk";
            this.side_condensedmilk.Size = new System.Drawing.Size(75, 23);
            this.side_condensedmilk.TabIndex = 12;
            this.side_condensedmilk.Text = "煉乳: 10";
            this.side_condensedmilk.UseVisualStyleBackColor = true;
            this.side_condensedmilk.Click += new System.EventHandler(this.side_condensedmilk_Click);
            // 
            // side_honeydew
            // 
            this.side_honeydew.Location = new System.Drawing.Point(6, 108);
            this.side_honeydew.Name = "side_honeydew";
            this.side_honeydew.Size = new System.Drawing.Size(75, 23);
            this.side_honeydew.TabIndex = 11;
            this.side_honeydew.Text = "蜜地瓜: 10";
            this.side_honeydew.UseVisualStyleBackColor = true;
            this.side_honeydew.Click += new System.EventHandler(this.side_honeydew_Click);
            // 
            // side_greenpapaya
            // 
            this.side_greenpapaya.Location = new System.Drawing.Point(168, 79);
            this.side_greenpapaya.Name = "side_greenpapaya";
            this.side_greenpapaya.Size = new System.Drawing.Size(75, 23);
            this.side_greenpapaya.TabIndex = 10;
            this.side_greenpapaya.Text = "青木瓜: 10";
            this.side_greenpapaya.UseVisualStyleBackColor = true;
            this.side_greenpapaya.Click += new System.EventHandler(this.side_greenpapaya_Click);
            // 
            // side_grassjelly
            // 
            this.side_grassjelly.Location = new System.Drawing.Point(87, 79);
            this.side_grassjelly.Name = "side_grassjelly";
            this.side_grassjelly.Size = new System.Drawing.Size(75, 23);
            this.side_grassjelly.TabIndex = 9;
            this.side_grassjelly.Text = "仙草: 10";
            this.side_grassjelly.UseVisualStyleBackColor = true;
            this.side_grassjelly.Click += new System.EventHandler(this.side_grassjelly_Click);
            // 
            // side_tangyuan
            // 
            this.side_tangyuan.Location = new System.Drawing.Point(6, 79);
            this.side_tangyuan.Name = "side_tangyuan";
            this.side_tangyuan.Size = new System.Drawing.Size(75, 23);
            this.side_tangyuan.TabIndex = 8;
            this.side_tangyuan.Text = "小湯圓: 10";
            this.side_tangyuan.UseVisualStyleBackColor = true;
            this.side_tangyuan.Click += new System.EventHandler(this.side_tangyuan_Click);
            // 
            // side_taroball
            // 
            this.side_taroball.Location = new System.Drawing.Point(168, 50);
            this.side_taroball.Name = "side_taroball";
            this.side_taroball.Size = new System.Drawing.Size(75, 23);
            this.side_taroball.TabIndex = 7;
            this.side_taroball.Text = "芋圓: 10";
            this.side_taroball.UseVisualStyleBackColor = true;
            this.side_taroball.Click += new System.EventHandler(this.side_taroball_Click);
            // 
            // side_pearl
            // 
            this.side_pearl.Location = new System.Drawing.Point(87, 50);
            this.side_pearl.Name = "side_pearl";
            this.side_pearl.Size = new System.Drawing.Size(75, 23);
            this.side_pearl.TabIndex = 6;
            this.side_pearl.Text = "珍珠: 10";
            this.side_pearl.UseVisualStyleBackColor = true;
            this.side_pearl.Click += new System.EventHandler(this.side_pearl_Click);
            // 
            // side_bianren
            // 
            this.side_bianren.Location = new System.Drawing.Point(6, 50);
            this.side_bianren.Name = "side_bianren";
            this.side_bianren.Size = new System.Drawing.Size(75, 23);
            this.side_bianren.TabIndex = 5;
            this.side_bianren.Text = "薏仁: 10";
            this.side_bianren.UseVisualStyleBackColor = true;
            this.side_bianren.Click += new System.EventHandler(this.side_bianren_Click);
            // 
            // side_greenbean
            // 
            this.side_greenbean.Location = new System.Drawing.Point(168, 21);
            this.side_greenbean.Name = "side_greenbean";
            this.side_greenbean.Size = new System.Drawing.Size(75, 23);
            this.side_greenbean.TabIndex = 4;
            this.side_greenbean.Text = "綠豆: 10";
            this.side_greenbean.UseVisualStyleBackColor = true;
            this.side_greenbean.Click += new System.EventHandler(this.side_greenbean_Click);
            // 
            // side_peanut
            // 
            this.side_peanut.Location = new System.Drawing.Point(87, 21);
            this.side_peanut.Name = "side_peanut";
            this.side_peanut.Size = new System.Drawing.Size(75, 23);
            this.side_peanut.TabIndex = 3;
            this.side_peanut.Text = "花生: 10";
            this.side_peanut.UseVisualStyleBackColor = true;
            this.side_peanut.Click += new System.EventHandler(this.side_peanut_Click);
            // 
            // side_redbean
            // 
            this.side_redbean.Location = new System.Drawing.Point(6, 21);
            this.side_redbean.Name = "side_redbean";
            this.side_redbean.Size = new System.Drawing.Size(75, 23);
            this.side_redbean.TabIndex = 2;
            this.side_redbean.Text = "紅豆: 10";
            this.side_redbean.UseVisualStyleBackColor = true;
            this.side_redbean.Click += new System.EventHandler(this.side_redbean_Click);
            // 
            // gbx_temp
            // 
            this.gbx_temp.Controls.Add(this.temp_warm);
            this.gbx_temp.Controls.Add(this.temp_iced);
            this.gbx_temp.Location = new System.Drawing.Point(12, 371);
            this.gbx_temp.Name = "gbx_temp";
            this.gbx_temp.Size = new System.Drawing.Size(249, 67);
            this.gbx_temp.TabIndex = 6;
            this.gbx_temp.TabStop = false;
            this.gbx_temp.Text = "豆花冷熱";
            // 
            // temp_warm
            // 
            this.temp_warm.AutoSize = true;
            this.temp_warm.Location = new System.Drawing.Point(107, 21);
            this.temp_warm.Name = "temp_warm";
            this.temp_warm.Size = new System.Drawing.Size(35, 16);
            this.temp_warm.TabIndex = 7;
            this.temp_warm.TabStop = true;
            this.temp_warm.Text = "熱";
            this.temp_warm.UseVisualStyleBackColor = true;
            // 
            // temp_iced
            // 
            this.temp_iced.AutoSize = true;
            this.temp_iced.Location = new System.Drawing.Point(10, 21);
            this.temp_iced.Name = "temp_iced";
            this.temp_iced.Size = new System.Drawing.Size(35, 16);
            this.temp_iced.TabIndex = 7;
            this.temp_iced.TabStop = true;
            this.temp_iced.Text = "冰";
            this.temp_iced.UseVisualStyleBackColor = true;
            this.temp_iced.CheckedChanged += new System.EventHandler(this.temp_iced_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btn_add);
            this.groupBox5.Controls.Add(this.btn_clear);
            this.groupBox5.Controls.Add(this.txt_price);
            this.groupBox5.Location = new System.Drawing.Point(267, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(525, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "總價:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(143, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 71);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "新增";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(6, 21);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(131, 71);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_msg);
            this.groupBox6.Location = new System.Drawing.Point(267, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(525, 320);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "品項";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbx_temp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbx_temp.ResumeLayout(false);
            this.gbx_temp.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sweet_douhua;
        private System.Windows.Forms.RadioButton sweet_shavedice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton main_rainbowtangyuan;
        private System.Windows.Forms.RadioButton main_bianren;
        private System.Windows.Forms.RadioButton main_taroball;
        private System.Windows.Forms.RadioButton main_greenbean;
        private System.Windows.Forms.RadioButton main_redbean;
        private System.Windows.Forms.RadioButton main_fenguo;
        private System.Windows.Forms.RadioButton main_peanut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbx_temp;
        private System.Windows.Forms.RadioButton temp_warm;
        private System.Windows.Forms.RadioButton temp_iced;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button side_rainbowtangyuan;
        private System.Windows.Forms.Button side_taro;
        private System.Windows.Forms.Button side_fenguo;
        private System.Windows.Forms.Button side_condensedmilk;
        private System.Windows.Forms.Button side_honeydew;
        private System.Windows.Forms.Button side_greenpapaya;
        private System.Windows.Forms.Button side_grassjelly;
        private System.Windows.Forms.Button side_tangyuan;
        private System.Windows.Forms.Button side_taroball;
        private System.Windows.Forms.Button side_pearl;
        private System.Windows.Forms.Button side_bianren;
        private System.Windows.Forms.Button side_greenbean;
        private System.Windows.Forms.Button side_peanut;
        private System.Windows.Forms.Button side_redbean;
    }
}

