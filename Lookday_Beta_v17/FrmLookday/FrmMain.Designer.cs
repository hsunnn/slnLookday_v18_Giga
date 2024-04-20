namespace Lookday_Beta_v17
{
    partial class FrmMain
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxWest = new System.Windows.Forms.ComboBox();
            this.comboBoxNorth = new System.Windows.Forms.ComboBox();
            this.comboBoxSouth = new System.Windows.Forms.ComboBox();
            this.comboBoxEast = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.txtTitleSearchBar = new System.Windows.Forms.TextBox();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnLookday = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimal = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxWest, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxNorth, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSouth, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxEast, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 24);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // comboBoxWest
            // 
            this.comboBoxWest.BackColor = System.Drawing.Color.White;
            this.comboBoxWest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxWest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWest.FormattingEnabled = true;
            this.comboBoxWest.Location = new System.Drawing.Point(2, 2);
            this.comboBoxWest.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWest.Name = "comboBoxWest";
            this.comboBoxWest.Size = new System.Drawing.Size(246, 21);
            this.comboBoxWest.TabIndex = 0;
            this.comboBoxWest.SelectedIndexChanged += new System.EventHandler(this.comboBoxWest_SelectedIndexChanged);
            // 
            // comboBoxNorth
            // 
            this.comboBoxNorth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNorth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNorth.FormattingEnabled = true;
            this.comboBoxNorth.Location = new System.Drawing.Point(252, 2);
            this.comboBoxNorth.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNorth.Name = "comboBoxNorth";
            this.comboBoxNorth.Size = new System.Drawing.Size(246, 21);
            this.comboBoxNorth.TabIndex = 1;
            this.comboBoxNorth.SelectedIndexChanged += new System.EventHandler(this.comboBoxNorth_SelectedIndexChanged);
            // 
            // comboBoxSouth
            // 
            this.comboBoxSouth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSouth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSouth.FormattingEnabled = true;
            this.comboBoxSouth.Location = new System.Drawing.Point(502, 2);
            this.comboBoxSouth.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSouth.Name = "comboBoxSouth";
            this.comboBoxSouth.Size = new System.Drawing.Size(246, 21);
            this.comboBoxSouth.TabIndex = 2;
            this.comboBoxSouth.SelectedIndexChanged += new System.EventHandler(this.comboBoxSouth_SelectedIndexChanged);
            // 
            // comboBoxEast
            // 
            this.comboBoxEast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEast.FormattingEnabled = true;
            this.comboBoxEast.Location = new System.Drawing.Point(752, 2);
            this.comboBoxEast.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEast.Name = "comboBoxEast";
            this.comboBoxEast.Size = new System.Drawing.Size(246, 21);
            this.comboBoxEast.TabIndex = 3;
            this.comboBoxEast.SelectedIndexChanged += new System.EventHandler(this.comboBoxEast_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.952381F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.Controls.Add(this.btnLogIn, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCart, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTitleSearchBar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWishlist, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnService, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLookday, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 43);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(904, 2);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(94, 39);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCart
            // 
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnCart.Location = new System.Drawing.Point(809, 2);
            this.btnCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(91, 39);
            this.btnCart.TabIndex = 1;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // txtTitleSearchBar
            // 
            this.txtTitleSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTitleSearchBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitleSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitleSearchBar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTitleSearchBar.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitleSearchBar.Location = new System.Drawing.Point(239, 12);
            this.txtTitleSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitleSearchBar.Name = "txtTitleSearchBar";
            this.txtTitleSearchBar.Size = new System.Drawing.Size(250, 18);
            this.txtTitleSearchBar.TabIndex = 2;
            this.txtTitleSearchBar.Text = "  Searching...";
            this.txtTitleSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitleSearchBar_KeyDown);
            this.txtTitleSearchBar.MouseEnter += new System.EventHandler(this.txtTitleSearchBar_MouseEnter);
            this.txtTitleSearchBar.MouseLeave += new System.EventHandler(this.txtTitleSearchBar_MouseLeave);
            // 
            // btnWishlist
            // 
            this.btnWishlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWishlist.FlatAppearance.BorderSize = 0;
            this.btnWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWishlist.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWishlist.Location = new System.Drawing.Point(714, 2);
            this.btnWishlist.Margin = new System.Windows.Forms.Padding(2);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Size = new System.Drawing.Size(91, 39);
            this.btnWishlist.TabIndex = 2;
            this.btnWishlist.Text = "Wishlist";
            this.btnWishlist.UseVisualStyleBackColor = true;
            this.btnWishlist.Click += new System.EventHandler(this.btnWishlist_Click);
            // 
            // btnService
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnService.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnService.Location = new System.Drawing.Point(619, 2);
            this.btnService.Margin = new System.Windows.Forms.Padding(2);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(91, 39);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnLookday
            // 
            this.btnLookday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLookday.FlatAppearance.BorderSize = 0;
            this.btnLookday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookday.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(132)))), ((int)(((byte)(20)))));
            this.btnLookday.Location = new System.Drawing.Point(61, 2);
            this.btnLookday.Margin = new System.Windows.Forms.Padding(2);
            this.btnLookday.Name = "btnLookday";
            this.btnLookday.Size = new System.Drawing.Size(174, 39);
            this.btnLookday.TabIndex = 4;
            this.btnLookday.Text = "LookDay !";
            this.btnLookday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLookday.UseVisualStyleBackColor = true;
            this.btnLookday.Click += new System.EventHandler(this.btnLookday_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.BackgroundImage = global::Lookday_Beta_v17.Properties.Resources.LogoFrmMain;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogo.Location = new System.Drawing.Point(2, 2);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(55, 39);
            this.btnLogo.TabIndex = 5;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(144)))), ((int)(((byte)(44)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 920F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnMinimal, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1000, 32);
            this.tableLayoutPanel3.TabIndex = 8;
            this.tableLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel3_MouseDown);
            this.tableLayoutPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel3_MouseMove);
            this.tableLayoutPanel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel3_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(963, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimal
            // 
            this.btnMinimal.FlatAppearance.BorderSize = 0;
            this.btnMinimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimal.ForeColor = System.Drawing.Color.White;
            this.btnMinimal.Location = new System.Drawing.Point(923, 3);
            this.btnMinimal.Name = "btnMinimal";
            this.btnMinimal.Size = new System.Drawing.Size(34, 25);
            this.btnMinimal.TabIndex = 7;
            this.btnMinimal.Text = "──";
            this.btnMinimal.UseVisualStyleBackColor = true;
            this.btnMinimal.Click += new System.EventHandler(this.btnMinimal_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 758);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxWest;
        private System.Windows.Forms.ComboBox comboBoxNorth;
        private System.Windows.Forms.ComboBox comboBoxSouth;
        private System.Windows.Forms.ComboBox comboBoxEast;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.TextBox txtTitleSearchBar;
        private System.Windows.Forms.Button btnWishlist;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnLookday;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Button btnLogIn;
    }
}

