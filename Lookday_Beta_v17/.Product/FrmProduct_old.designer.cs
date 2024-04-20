namespace Lookday_Beta.Product
{
    partial class FrmProduct_old
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelBox6 = new Lookday_Beta.Product.LabelBox();
            this.labelBox5 = new Lookday_Beta.Product.LabelBox();
            this.labelBox4 = new Lookday_Beta.Product.LabelBox();
            this.labelBox3 = new Lookday_Beta.Product.LabelBox();
            this.labelBox2 = new Lookday_Beta.Product.LabelBox();
            this.labelBox1 = new Lookday_Beta.Product.LabelBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(349, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "活動名稱";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(95, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "加入購物車";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelBox6
            // 
            this.labelBox6.content = "label2";
            this.labelBox6.Location = new System.Drawing.Point(687, 354);
            this.labelBox6.Name = "labelBox6";
            this.labelBox6.Size = new System.Drawing.Size(253, 55);
            this.labelBox6.TabIndex = 7;
            this.labelBox6.title = "飯店";
            // 
            // labelBox5
            // 
            this.labelBox5.content = "label2";
            this.labelBox5.Location = new System.Drawing.Point(687, 226);
            this.labelBox5.Name = "labelBox5";
            this.labelBox5.Size = new System.Drawing.Size(240, 55);
            this.labelBox5.TabIndex = 6;
            this.labelBox5.title = "剩餘數量";
            // 
            // labelBox4
            // 
            this.labelBox4.content = "label2";
            this.labelBox4.Location = new System.Drawing.Point(687, 104);
            this.labelBox4.Name = "labelBox4";
            this.labelBox4.Size = new System.Drawing.Size(240, 55);
            this.labelBox4.TabIndex = 5;
            this.labelBox4.title = "城市";
            // 
            // labelBox3
            // 
            this.labelBox3.content = "label2";
            this.labelBox3.Location = new System.Drawing.Point(355, 355);
            this.labelBox3.Name = "labelBox3";
            this.labelBox3.Size = new System.Drawing.Size(309, 136);
            this.labelBox3.TabIndex = 4;
            this.labelBox3.title = "日期";
            // 
            // labelBox2
            // 
            this.labelBox2.content = "label2";
            this.labelBox2.Location = new System.Drawing.Point(355, 226);
            this.labelBox2.Name = "labelBox2";
            this.labelBox2.Size = new System.Drawing.Size(309, 55);
            this.labelBox2.TabIndex = 3;
            this.labelBox2.title = "價格";
            // 
            // labelBox1
            // 
            this.labelBox1.content = "label2";
            this.labelBox1.Location = new System.Drawing.Point(355, 107);
            this.labelBox1.Name = "labelBox1";
            this.labelBox1.Size = new System.Drawing.Size(309, 52);
            this.labelBox1.TabIndex = 2;
            this.labelBox1.title = "活動內容";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(27, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 415);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(928, 258);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 685);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBox6);
            this.Controls.Add(this.labelBox5);
            this.Controls.Add(this.labelBox4);
            this.Controls.Add(this.labelBox3);
            this.Controls.Add(this.labelBox2);
            this.Controls.Add(this.labelBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private LabelBox labelBox1;
        private LabelBox labelBox2;
        private LabelBox labelBox3;
        private LabelBox labelBox4;
        private LabelBox labelBox5;
        private LabelBox labelBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}