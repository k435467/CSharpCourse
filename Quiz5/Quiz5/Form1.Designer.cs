namespace Quiz5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.lblPoint3 = new System.Windows.Forms.Label();
            this.txtP1X = new System.Windows.Forms.TextBox();
            this.txtP1Y = new System.Windows.Forms.TextBox();
            this.txtP2X = new System.Windows.Forms.TextBox();
            this.txtP2Y = new System.Windows.Forms.TextBox();
            this.txtP3X = new System.Windows.Forms.TextBox();
            this.txtP3Y = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbArea = new System.Windows.Forms.CheckBox();
            this.cbPerimeter = new System.Windows.Forms.CheckBox();
            this.cbTriangleType = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtP3Y);
            this.groupBox1.Controls.Add(this.txtP3X);
            this.groupBox1.Controls.Add(this.txtP2Y);
            this.groupBox1.Controls.Add(this.txtP2X);
            this.groupBox1.Controls.Add(this.txtP1Y);
            this.groupBox1.Controls.Add(this.txtP1X);
            this.groupBox1.Controls.Add(this.lblPoint3);
            this.groupBox1.Controls.Add(this.lblPoint2);
            this.groupBox1.Controls.Add(this.lblPoint1);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Location = new System.Drawing.Point(39, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "座標輸入";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(184, 22);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(13, 12);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(311, 22);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(13, 12);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Location = new System.Drawing.Point(27, 43);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(35, 12);
            this.lblPoint1.TabIndex = 2;
            this.lblPoint1.Text = "Point1";
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Location = new System.Drawing.Point(27, 90);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(35, 12);
            this.lblPoint2.TabIndex = 3;
            this.lblPoint2.Text = "Point2";
            // 
            // lblPoint3
            // 
            this.lblPoint3.AutoSize = true;
            this.lblPoint3.Location = new System.Drawing.Point(27, 134);
            this.lblPoint3.Name = "lblPoint3";
            this.lblPoint3.Size = new System.Drawing.Size(35, 12);
            this.lblPoint3.TabIndex = 4;
            this.lblPoint3.Text = "Point3";
            // 
            // txtP1X
            // 
            this.txtP1X.Location = new System.Drawing.Point(144, 40);
            this.txtP1X.Name = "txtP1X";
            this.txtP1X.Size = new System.Drawing.Size(100, 22);
            this.txtP1X.TabIndex = 5;
            // 
            // txtP1Y
            // 
            this.txtP1Y.Location = new System.Drawing.Point(269, 40);
            this.txtP1Y.Name = "txtP1Y";
            this.txtP1Y.Size = new System.Drawing.Size(100, 22);
            this.txtP1Y.TabIndex = 6;
            // 
            // txtP2X
            // 
            this.txtP2X.Location = new System.Drawing.Point(144, 87);
            this.txtP2X.Name = "txtP2X";
            this.txtP2X.Size = new System.Drawing.Size(100, 22);
            this.txtP2X.TabIndex = 7;
            // 
            // txtP2Y
            // 
            this.txtP2Y.Location = new System.Drawing.Point(269, 87);
            this.txtP2Y.Name = "txtP2Y";
            this.txtP2Y.Size = new System.Drawing.Size(100, 22);
            this.txtP2Y.TabIndex = 8;
            // 
            // txtP3X
            // 
            this.txtP3X.Location = new System.Drawing.Point(144, 131);
            this.txtP3X.Name = "txtP3X";
            this.txtP3X.Size = new System.Drawing.Size(100, 22);
            this.txtP3X.TabIndex = 9;
            // 
            // txtP3Y
            // 
            this.txtP3Y.Location = new System.Drawing.Point(269, 131);
            this.txtP3Y.Name = "txtP3Y";
            this.txtP3Y.Size = new System.Drawing.Size(100, 22);
            this.txtP3Y.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTriangleType);
            this.groupBox2.Controls.Add(this.cbPerimeter);
            this.groupBox2.Controls.Add(this.cbArea);
            this.groupBox2.Location = new System.Drawing.Point(39, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選項";
            // 
            // cbArea
            // 
            this.cbArea.AutoSize = true;
            this.cbArea.Location = new System.Drawing.Point(29, 34);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(72, 16);
            this.cbArea.TabIndex = 0;
            this.cbArea.Text = "計算面積";
            this.cbArea.UseVisualStyleBackColor = true;
            // 
            // cbPerimeter
            // 
            this.cbPerimeter.AutoSize = true;
            this.cbPerimeter.Location = new System.Drawing.Point(163, 34);
            this.cbPerimeter.Name = "cbPerimeter";
            this.cbPerimeter.Size = new System.Drawing.Size(72, 16);
            this.cbPerimeter.TabIndex = 1;
            this.cbPerimeter.Text = "計算周長";
            this.cbPerimeter.UseVisualStyleBackColor = true;
            // 
            // cbTriangleType
            // 
            this.cbTriangleType.AutoSize = true;
            this.cbTriangleType.Location = new System.Drawing.Point(279, 34);
            this.cbTriangleType.Name = "cbTriangleType";
            this.cbTriangleType.Size = new System.Drawing.Size(108, 16);
            this.cbTriangleType.TabIndex = 2;
            this.cbTriangleType.Text = "輸出三角形類別";
            this.cbTriangleType.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDisplay);
            this.groupBox3.Controls.Add(this.btnCal);
            this.groupBox3.Location = new System.Drawing.Point(39, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 242);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能鍵與輸出";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(320, 13);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "計算";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(7, 37);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(388, 199);
            this.txtDisplay.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 542);
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
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtP3Y;
        private System.Windows.Forms.TextBox txtP3X;
        private System.Windows.Forms.TextBox txtP2Y;
        private System.Windows.Forms.TextBox txtP2X;
        private System.Windows.Forms.TextBox txtP1Y;
        private System.Windows.Forms.TextBox txtP1X;
        private System.Windows.Forms.Label lblPoint3;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTriangleType;
        private System.Windows.Forms.CheckBox cbPerimeter;
        private System.Windows.Forms.CheckBox cbArea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnCal;
    }
}

