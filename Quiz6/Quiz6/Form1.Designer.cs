namespace Quiz6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBallAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmonut = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBallAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtArg2 = new System.Windows.Forms.TextBox();
            this.lblArg2 = new System.Windows.Forms.Label();
            this.txtArg1 = new System.Windows.Forms.TextBox();
            this.lblArg1 = new System.Windows.Forms.Label();
            this.lblShape = new System.Windows.Forms.Label();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.txtCubeAmount = new System.Windows.Forms.TextBox();
            this.lblCubeAmount = new System.Windows.Forms.Label();
            this.txtCylinderAmount = new System.Windows.Forms.TextBox();
            this.lblCylinderAmount = new System.Windows.Forms.Label();
            this.txtPyramidAmount = new System.Windows.Forms.TextBox();
            this.lblPyramidAmount = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDensity);
            this.groupBox1.Controls.Add(this.lblDensity);
            this.groupBox1.Controls.Add(this.lblMaterial);
            this.groupBox1.Controls.Add(this.comboBoxMaterial);
            this.groupBox1.Location = new System.Drawing.Point(49, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material";
            // 
            // txtDensity
            // 
            this.txtDensity.Location = new System.Drawing.Point(118, 56);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(121, 22);
            this.txtDensity.TabIndex = 3;
            this.txtDensity.Text = "0";
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Location = new System.Drawing.Point(31, 59);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(29, 12);
            this.lblDensity.TabIndex = 2;
            this.lblDensity.Text = "密度";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(31, 24);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(29, 12);
            this.lblMaterial.TabIndex = 1;
            this.lblMaterial.Text = "材質";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(118, 21);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMaterial.TabIndex = 0;
            this.comboBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterial_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPyramidAmount);
            this.groupBox3.Controls.Add(this.lblPyramidAmount);
            this.groupBox3.Controls.Add(this.txtCylinderAmount);
            this.groupBox3.Controls.Add(this.lblCylinderAmount);
            this.groupBox3.Controls.Add(this.txtCubeAmount);
            this.groupBox3.Controls.Add(this.lblCubeAmount);
            this.groupBox3.Controls.Add(this.txtBallAmount);
            this.groupBox3.Controls.Add(this.txtTotalAmonut);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.lblBallAmount);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(49, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount Of Shape";
            // 
            // txtBallAmount
            // 
            this.txtBallAmount.Location = new System.Drawing.Point(15, 115);
            this.txtBallAmount.Name = "txtBallAmount";
            this.txtBallAmount.Size = new System.Drawing.Size(35, 22);
            this.txtBallAmount.TabIndex = 10;
            this.txtBallAmount.Text = "0";
            // 
            // txtTotalAmonut
            // 
            this.txtTotalAmonut.Location = new System.Drawing.Point(118, 39);
            this.txtTotalAmonut.Name = "txtTotalAmonut";
            this.txtTotalAmonut.Size = new System.Drawing.Size(121, 22);
            this.txtTotalAmonut.TabIndex = 6;
            this.txtTotalAmonut.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBallAmount
            // 
            this.lblBallAmount.AutoSize = true;
            this.lblBallAmount.Location = new System.Drawing.Point(22, 87);
            this.lblBallAmount.Name = "lblBallAmount";
            this.lblBallAmount.Size = new System.Drawing.Size(17, 12);
            this.lblBallAmount.TabIndex = 8;
            this.lblBallAmount.Text = "球";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "參數2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblClear);
            this.groupBox4.Controls.Add(this.txtMessage);
            this.groupBox4.Location = new System.Drawing.Point(348, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 411);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtArg2);
            this.groupBox5.Controls.Add(this.lblArg2);
            this.groupBox5.Controls.Add(this.txtArg1);
            this.groupBox5.Controls.Add(this.lblArg1);
            this.groupBox5.Controls.Add(this.lblShape);
            this.groupBox5.Controls.Add(this.comboBoxShape);
            this.groupBox5.Location = new System.Drawing.Point(49, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 144);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Material";
            // 
            // txtArg2
            // 
            this.txtArg2.Location = new System.Drawing.Point(118, 98);
            this.txtArg2.Name = "txtArg2";
            this.txtArg2.Size = new System.Drawing.Size(121, 22);
            this.txtArg2.TabIndex = 5;
            this.txtArg2.Text = "0";
            this.txtArg2.Visible = false;
            // 
            // lblArg2
            // 
            this.lblArg2.Location = new System.Drawing.Point(31, 101);
            this.lblArg2.Name = "lblArg2";
            this.lblArg2.Size = new System.Drawing.Size(35, 12);
            this.lblArg2.TabIndex = 4;
            this.lblArg2.Text = "參數2";
            this.lblArg2.Visible = false;
            // 
            // txtArg1
            // 
            this.txtArg1.Location = new System.Drawing.Point(118, 56);
            this.txtArg1.Name = "txtArg1";
            this.txtArg1.Size = new System.Drawing.Size(121, 22);
            this.txtArg1.TabIndex = 3;
            this.txtArg1.Text = "0";
            // 
            // lblArg1
            // 
            this.lblArg1.AutoSize = true;
            this.lblArg1.Location = new System.Drawing.Point(31, 59);
            this.lblArg1.Name = "lblArg1";
            this.lblArg1.Size = new System.Drawing.Size(35, 12);
            this.lblArg1.TabIndex = 2;
            this.lblArg1.Text = "參數1";
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(31, 24);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(29, 12);
            this.lblShape.TabIndex = 1;
            this.lblShape.Text = "形狀";
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.comboBoxShape.Location = new System.Drawing.Point(118, 21);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(121, 20);
            this.comboBoxShape.TabIndex = 0;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // txtCubeAmount
            // 
            this.txtCubeAmount.Location = new System.Drawing.Point(71, 115);
            this.txtCubeAmount.Name = "txtCubeAmount";
            this.txtCubeAmount.Size = new System.Drawing.Size(35, 22);
            this.txtCubeAmount.TabIndex = 12;
            this.txtCubeAmount.Text = "0";
            // 
            // lblCubeAmount
            // 
            this.lblCubeAmount.AutoSize = true;
            this.lblCubeAmount.Location = new System.Drawing.Point(69, 87);
            this.lblCubeAmount.Name = "lblCubeAmount";
            this.lblCubeAmount.Size = new System.Drawing.Size(41, 12);
            this.lblCubeAmount.TabIndex = 11;
            this.lblCubeAmount.Text = "立方體";
            // 
            // txtCylinderAmount
            // 
            this.txtCylinderAmount.Location = new System.Drawing.Point(125, 115);
            this.txtCylinderAmount.Name = "txtCylinderAmount";
            this.txtCylinderAmount.Size = new System.Drawing.Size(35, 22);
            this.txtCylinderAmount.TabIndex = 14;
            this.txtCylinderAmount.Text = "0";
            // 
            // lblCylinderAmount
            // 
            this.lblCylinderAmount.AutoSize = true;
            this.lblCylinderAmount.Location = new System.Drawing.Point(123, 87);
            this.lblCylinderAmount.Name = "lblCylinderAmount";
            this.lblCylinderAmount.Size = new System.Drawing.Size(41, 12);
            this.lblCylinderAmount.TabIndex = 13;
            this.lblCylinderAmount.Text = "圓柱體";
            // 
            // txtPyramidAmount
            // 
            this.txtPyramidAmount.Location = new System.Drawing.Point(185, 115);
            this.txtPyramidAmount.Name = "txtPyramidAmount";
            this.txtPyramidAmount.Size = new System.Drawing.Size(35, 22);
            this.txtPyramidAmount.TabIndex = 16;
            this.txtPyramidAmount.Text = "0";
            // 
            // lblPyramidAmount
            // 
            this.lblPyramidAmount.AutoSize = true;
            this.lblPyramidAmount.Location = new System.Drawing.Point(183, 87);
            this.lblPyramidAmount.Name = "lblPyramidAmount";
            this.lblPyramidAmount.Size = new System.Drawing.Size(41, 12);
            this.lblPyramidAmount.TabIndex = 15;
            this.lblPyramidAmount.Text = "金字塔";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 24);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(342, 349);
            this.txtMessage.TabIndex = 6;
            // 
            // lblClear
            // 
            this.lblClear.Location = new System.Drawing.Point(282, 382);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(75, 23);
            this.lblClear.TabIndex = 7;
            this.lblClear.Text = "Clear";
            this.lblClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtArg1;
        private System.Windows.Forms.Label lblArg1;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Label lblBallAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArg2;
        private System.Windows.Forms.Label lblArg2;
        private System.Windows.Forms.TextBox txtBallAmount;
        private System.Windows.Forms.TextBox txtTotalAmonut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPyramidAmount;
        private System.Windows.Forms.Label lblPyramidAmount;
        private System.Windows.Forms.TextBox txtCylinderAmount;
        private System.Windows.Forms.Label lblCylinderAmount;
        private System.Windows.Forms.Label lblCubeAmount;
        private System.Windows.Forms.TextBox txtCubeAmount;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button lblClear;
    }
}

