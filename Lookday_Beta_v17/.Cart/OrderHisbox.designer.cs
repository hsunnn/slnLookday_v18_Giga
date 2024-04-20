namespace Lookday_Beta
{
    partial class OrderHisbox
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxo = new System.Windows.Forms.PictureBox();
            this.lblNameo = new System.Windows.Forms.Label();
            this.lblDateo = new System.Windows.Forms.Label();
            this.lblMemoo = new System.Windows.Forms.Label();
            this.lblMembero = new System.Windows.Forms.Label();
            this.lblPriceo = new System.Windows.Forms.Label();
            this.lblBookDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxo
            // 
            this.pictureBoxo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxo.Name = "pictureBoxo";
            this.pictureBoxo.Size = new System.Drawing.Size(125, 145);
            this.pictureBoxo.TabIndex = 0;
            this.pictureBoxo.TabStop = false;
            // 
            // lblNameo
            // 
            this.lblNameo.BackColor = System.Drawing.Color.Transparent;
            this.lblNameo.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.lblNameo.Location = new System.Drawing.Point(130, 0);
            this.lblNameo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameo.Name = "lblNameo";
            this.lblNameo.Size = new System.Drawing.Size(307, 28);
            this.lblNameo.TabIndex = 1;
            this.lblNameo.Text = "Title";
            this.lblNameo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDateo
            // 
            this.lblDateo.AutoSize = true;
            this.lblDateo.BackColor = System.Drawing.Color.Transparent;
            this.lblDateo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDateo.Location = new System.Drawing.Point(135, 63);
            this.lblDateo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateo.Name = "lblDateo";
            this.lblDateo.Size = new System.Drawing.Size(36, 16);
            this.lblDateo.TabIndex = 2;
            this.lblDateo.Text = "Date";
            // 
            // lblMemoo
            // 
            this.lblMemoo.AutoSize = true;
            this.lblMemoo.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMemoo.Location = new System.Drawing.Point(135, 35);
            this.lblMemoo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemoo.Name = "lblMemoo";
            this.lblMemoo.Size = new System.Drawing.Size(32, 16);
            this.lblMemoo.TabIndex = 3;
            this.lblMemoo.Text = "Intro";
            // 
            // lblMembero
            // 
            this.lblMembero.AutoSize = true;
            this.lblMembero.BackColor = System.Drawing.Color.Transparent;
            this.lblMembero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMembero.Location = new System.Drawing.Point(135, 93);
            this.lblMembero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMembero.Name = "lblMembero";
            this.lblMembero.Size = new System.Drawing.Size(57, 16);
            this.lblMembero.TabIndex = 4;
            this.lblMembero.Text = "Member";
            // 
            // lblPriceo
            // 
            this.lblPriceo.AutoSize = true;
            this.lblPriceo.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPriceo.Location = new System.Drawing.Point(135, 120);
            this.lblPriceo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceo.Name = "lblPriceo";
            this.lblPriceo.Size = new System.Drawing.Size(38, 16);
            this.lblPriceo.TabIndex = 5;
            this.lblPriceo.Text = "Price";
            // 
            // lblBookDate
            // 
            this.lblBookDate.AutoSize = true;
            this.lblBookDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBookDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblBookDate.Location = new System.Drawing.Point(345, 120);
            this.lblBookDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookDate.Name = "lblBookDate";
            this.lblBookDate.Size = new System.Drawing.Size(73, 16);
            this.lblBookDate.TabIndex = 6;
            this.lblBookDate.Text = "Order Date";
            // 
            // OrderHisbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBookDate);
            this.Controls.Add(this.lblPriceo);
            this.Controls.Add(this.lblMembero);
            this.Controls.Add(this.lblMemoo);
            this.Controls.Add(this.lblDateo);
            this.Controls.Add(this.lblNameo);
            this.Controls.Add(this.pictureBoxo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderHisbox";
            this.Size = new System.Drawing.Size(725, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxo;
        private System.Windows.Forms.Label lblNameo;
        private System.Windows.Forms.Label lblDateo;
        private System.Windows.Forms.Label lblMemoo;
        private System.Windows.Forms.Label lblMembero;
        private System.Windows.Forms.Label lblPriceo;
        private System.Windows.Forms.Label lblBookDate;
    }
}
