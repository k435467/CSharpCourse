namespace _104_Classwork5
{
    partial class MaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.btnAl = new System.Windows.Forms.Button();
            this.btnFe = new System.Windows.Forms.Button();
            this.btnPb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(42, 76);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(71, 64);
            this.btnAl.TabIndex = 0;
            this.btnAl.Text = "鋁";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // btnFe
            // 
            this.btnFe.Location = new System.Drawing.Point(159, 76);
            this.btnFe.Name = "btnFe";
            this.btnFe.Size = new System.Drawing.Size(71, 64);
            this.btnFe.TabIndex = 1;
            this.btnFe.Text = "鐵";
            this.btnFe.UseVisualStyleBackColor = true;
            this.btnFe.Click += new System.EventHandler(this.btnFe_Click);
            // 
            // btnPb
            // 
            this.btnPb.Location = new System.Drawing.Point(278, 76);
            this.btnPb.Name = "btnPb";
            this.btnPb.Size = new System.Drawing.Size(71, 64);
            this.btnPb.TabIndex = 2;
            this.btnPb.Text = "鉛";
            this.btnPb.UseVisualStyleBackColor = true;
            this.btnPb.Click += new System.EventHandler(this.btnPb_Click);
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 234);
            this.Controls.Add(this.btnPb);
            this.Controls.Add(this.btnFe);
            this.Controls.Add(this.btnAl);
            this.Name = "MaterialForm";
            this.Text = "MaterialForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btnFe;
        private System.Windows.Forms.Button btnPb;
    }
}