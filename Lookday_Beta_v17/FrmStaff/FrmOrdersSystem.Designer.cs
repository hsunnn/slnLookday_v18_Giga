namespace Lookday_Beta_v17
{
    partial class FrmOrdersSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdersSystem));
            this.btn_SearchbyDate = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SearchbyOrderID = new System.Windows.Forms.TextBox();
            this.btn_SearchbyOrderID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchbyName = new System.Windows.Forms.TextBox();
            this.Btn_SearchbyName = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductSystemTitle = new System.Windows.Forms.Label();
            this.btn_SearchAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SearchbyDate
            // 
            this.btn_SearchbyDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_SearchbyDate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SearchbyDate.ForeColor = System.Drawing.Color.Transparent;
            this.btn_SearchbyDate.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchbyDate.Image")));
            this.btn_SearchbyDate.Location = new System.Drawing.Point(718, 127);
            this.btn_SearchbyDate.Name = "btn_SearchbyDate";
            this.btn_SearchbyDate.Size = new System.Drawing.Size(32, 32);
            this.btn_SearchbyDate.TabIndex = 100;
            this.btn_SearchbyDate.UseVisualStyleBackColor = false;
            this.btn_SearchbyDate.Click += new System.EventHandler(this.btn_SearchbyDate_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker2.Location = new System.Drawing.Point(410, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 26);
            this.dateTimePicker2.TabIndex = 99;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 26);
            this.dateTimePicker1.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(70, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 96;
            this.label2.Text = "依訂單編號查詢";
            // 
            // txt_SearchbyOrderID
            // 
            this.txt_SearchbyOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_SearchbyOrderID.Location = new System.Drawing.Point(70, 220);
            this.txt_SearchbyOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SearchbyOrderID.Name = "txt_SearchbyOrderID";
            this.txt_SearchbyOrderID.Size = new System.Drawing.Size(260, 26);
            this.txt_SearchbyOrderID.TabIndex = 95;
            // 
            // btn_SearchbyOrderID
            // 
            this.btn_SearchbyOrderID.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SearchbyOrderID.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchbyOrderID.Image")));
            this.btn_SearchbyOrderID.Location = new System.Drawing.Point(338, 217);
            this.btn_SearchbyOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SearchbyOrderID.Name = "btn_SearchbyOrderID";
            this.btn_SearchbyOrderID.Size = new System.Drawing.Size(32, 32);
            this.btn_SearchbyOrderID.TabIndex = 94;
            this.btn_SearchbyOrderID.UseVisualStyleBackColor = true;
            this.btn_SearchbyOrderID.Click += new System.EventHandler(this.btn_SearchbyOrderID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(410, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 92;
            this.label1.Text = "依會員查詢";
            // 
            // txt_SearchbyName
            // 
            this.txt_SearchbyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_SearchbyName.Location = new System.Drawing.Point(410, 220);
            this.txt_SearchbyName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SearchbyName.Name = "txt_SearchbyName";
            this.txt_SearchbyName.Size = new System.Drawing.Size(300, 26);
            this.txt_SearchbyName.TabIndex = 91;
            // 
            // Btn_SearchbyName
            // 
            this.Btn_SearchbyName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SearchbyName.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SearchbyName.Image")));
            this.Btn_SearchbyName.Location = new System.Drawing.Point(718, 217);
            this.Btn_SearchbyName.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SearchbyName.Name = "Btn_SearchbyName";
            this.Btn_SearchbyName.Size = new System.Drawing.Size(32, 32);
            this.Btn_SearchbyName.TabIndex = 90;
            this.Btn_SearchbyName.UseVisualStyleBackColor = true;
            this.Btn_SearchbyName.Click += new System.EventHandler(this.Btn_SearchbyName_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 320);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(680, 325);
            this.dataGridView1.TabIndex = 89;
            // 
            // ProductSystemTitle
            // 
            this.ProductSystemTitle.AutoSize = true;
            this.ProductSystemTitle.BackColor = System.Drawing.Color.Transparent;
            this.ProductSystemTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductSystemTitle.ForeColor = System.Drawing.Color.White;
            this.ProductSystemTitle.Location = new System.Drawing.Point(60, 35);
            this.ProductSystemTitle.Name = "ProductSystemTitle";
            this.ProductSystemTitle.Size = new System.Drawing.Size(408, 44);
            this.ProductSystemTitle.TabIndex = 88;
            this.ProductSystemTitle.Text = "Orders System 訂單系統";
            // 
            // btn_SearchAll
            // 
            this.btn_SearchAll.BackColor = System.Drawing.Color.Orange;
            this.btn_SearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchAll.ForeColor = System.Drawing.Color.White;
            this.btn_SearchAll.Location = new System.Drawing.Point(630, 270);
            this.btn_SearchAll.Name = "btn_SearchAll";
            this.btn_SearchAll.Size = new System.Drawing.Size(120, 32);
            this.btn_SearchAll.TabIndex = 101;
            this.btn_SearchAll.Text = "Search All";
            this.btn_SearchAll.UseVisualStyleBackColor = false;
            this.btn_SearchAll.Click += new System.EventHandler(this.btn_SearchAll_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(630, 660);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 32);
            this.btnDelete.TabIndex = 102;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(70, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "起始日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(410, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 104;
            this.label4.Text = "結束日期";
            // 
            // FrmOrdersSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(820, 726);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_SearchAll);
            this.Controls.Add(this.btn_SearchbyDate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SearchbyOrderID);
            this.Controls.Add(this.btn_SearchbyOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SearchbyName);
            this.Controls.Add(this.Btn_SearchbyName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductSystemTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdersSystem";
            this.Text = "FrmOrdersSystem";
            this.Load += new System.EventHandler(this.FrmOrdersSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchbyDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SearchbyOrderID;
        private System.Windows.Forms.Button btn_SearchbyOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchbyName;
        private System.Windows.Forms.Button Btn_SearchbyName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ProductSystemTitle;
        private System.Windows.Forms.Button btn_SearchAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}