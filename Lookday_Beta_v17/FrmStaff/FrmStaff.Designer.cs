namespace Lookday_Beta_v17
{
    partial class FrmStaff
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.btnOrderSystem = new System.Windows.Forms.Button();
            this.btnProductSystem = new System.Windows.Forms.Button();
            this.btnCustomerSystem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 650);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.PnlNav);
            this.panel2.Controls.Add(this.btnOrderSystem);
            this.panel2.Controls.Add(this.btnProductSystem);
            this.panel2.Controls.Add(this.btnCustomerSystem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 650);
            this.panel2.TabIndex = 4;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 13;
            // 
            // btnOrderSystem
            // 
            this.btnOrderSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderSystem.FlatAppearance.BorderSize = 0;
            this.btnOrderSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderSystem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOrderSystem.Location = new System.Drawing.Point(0, 292);
            this.btnOrderSystem.Name = "btnOrderSystem";
            this.btnOrderSystem.Size = new System.Drawing.Size(180, 65);
            this.btnOrderSystem.TabIndex = 11;
            this.btnOrderSystem.Text = "Orders System";
            this.btnOrderSystem.UseVisualStyleBackColor = true;
            this.btnOrderSystem.Click += new System.EventHandler(this.btnOrderSystem_Click);
            this.btnOrderSystem.Leave += new System.EventHandler(this.btnOrderSystem_Leave);
            // 
            // btnProductSystem
            // 
            this.btnProductSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductSystem.FlatAppearance.BorderSize = 0;
            this.btnProductSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSystem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProductSystem.Location = new System.Drawing.Point(0, 227);
            this.btnProductSystem.Name = "btnProductSystem";
            this.btnProductSystem.Size = new System.Drawing.Size(180, 65);
            this.btnProductSystem.TabIndex = 10;
            this.btnProductSystem.Text = "Product System";
            this.btnProductSystem.UseVisualStyleBackColor = true;
            this.btnProductSystem.Click += new System.EventHandler(this.btnProductSystem_Click);
            this.btnProductSystem.Leave += new System.EventHandler(this.btnProductSystem_Leave);
            // 
            // btnCustomerSystem
            // 
            this.btnCustomerSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerSystem.FlatAppearance.BorderSize = 0;
            this.btnCustomerSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSystem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustomerSystem.Location = new System.Drawing.Point(0, 162);
            this.btnCustomerSystem.Name = "btnCustomerSystem";
            this.btnCustomerSystem.Size = new System.Drawing.Size(180, 65);
            this.btnCustomerSystem.TabIndex = 9;
            this.btnCustomerSystem.Text = "Customer System";
            this.btnCustomerSystem.UseVisualStyleBackColor = true;
            this.btnCustomerSystem.Click += new System.EventHandler(this.btnCustomerSystem_Click);
            this.btnCustomerSystem.Leave += new System.EventHandler(this.btnCustomerSystem_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblStaffName);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 162);
            this.panel3.TabIndex = 8;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblStaffName.Location = new System.Drawing.Point(0, 120);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(88, 17);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Staff Name";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lookday_Beta_v17.Properties.Resources.Staff_Pic;
            this.pictureBox1.Location = new System.Drawing.Point(58, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogOut.Location = new System.Drawing.Point(0, 585);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(180, 65);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.Leave += new System.EventHandler(this.btnLogOut_Leave);
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStaff";
            this.Text = "FrmStaff";
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Button btnOrderSystem;
        private System.Windows.Forms.Button btnProductSystem;
        private System.Windows.Forms.Button btnCustomerSystem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
    }
}