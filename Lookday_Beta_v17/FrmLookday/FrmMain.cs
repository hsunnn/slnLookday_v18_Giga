using Lookday_Beta.Models;
using Lookday_Beta_v17.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Lookday_Beta_v17
{
    public partial class FrmMain : Form
    {

        public FrmClientCart _Cart;
        private FrmHome _Home;
        public FrmClientWishlist _Wishlist;
        private FrmSearching_v2 _Searching;

        public FrmMain()
        {
            InitializeComponent();
            IsMdiContainer = true;

            InitializeButtonColors();

            ApplyCustomComboBoxStyle(comboBoxWest);
            ApplyCustomComboBoxStyle(comboBoxNorth);
            ApplyCustomComboBoxStyle(comboBoxSouth);
            ApplyCustomComboBoxStyle(comboBoxEast);
        }

        private void InitializeButtonColors()
        {
            // 初始化按鈕顏色
            btnLogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLookday.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLookday.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ApplyCustomComboBoxStyle(ComboBox comboBox)
        {
            // 将ComboBox的DrawMode设置为OwnerDrawFixed，以允许自定义绘制
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            // 添加DrawItem事件处理程序
            comboBox.DrawItem += CustomComboBox_DrawItem;
            // 设置ComboBox的边框颜色为透明
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = SystemColors.Window;
        }

        private void CustomComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (!(sender is ComboBox comboBox))
                return;

            e.DrawBackground();

            if (e.Index >= 0)
            {
                // 检查ComboBox是否具有焦点，以便在绘制时进行不同的颜色处理
                bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

                // 获取要绘制的文本
                string text = comboBox.Items[e.Index].ToString();

                // 创建一个StringFormat对象，使内容居中显示
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                // 绘制文本
                using (Brush brush = new SolidBrush(isSelected ? SystemColors.HighlightText : comboBox.ForeColor))
                {
                    e.Graphics.DrawString(text, comboBox.Font, brush, e.Bounds, stringFormat);
                }
            }

            e.DrawFocusRectangle();
        }

        #region //拖曳 & 放置

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void tableLayoutPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //drag 是拖曳的標誌變數。
            start_point = new Point(e.X, e.Y);
        }

        private void tableLayoutPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void tableLayoutPanel3_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion

        private void btnLookday_Click(object sender, EventArgs e)
        {
            if (_Home == null)
            {
                _Home = new FrmHome();
                _Home.FormClosed += _Home_FormClosed;
                _Home.MdiParent = FrmMain.ActiveForm;
                _Home.Dock = DockStyle.Fill;
                //splitContainer1.Panel2.Controls.Add(_Home);
                _Home.Show();
            }
            else
            {
                _Home.Activate();
            }
        }

        private void _Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Home = null;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (CManager.LoginCheck == 0)
                return;
            (new FrmOpacity()).Show();
            (new FrmService()).ShowDialog();
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            if (CManager.LoginCheck == 0)
                return;
            if (_Wishlist == null)
            {
                _Wishlist = new FrmClientWishlist();
                _Wishlist.FormClosed += _Wishlist_FormClosed;
                _Wishlist.MdiParent = FrmMain.ActiveForm;
                _Wishlist.Dock = DockStyle.Fill;
                //splitContainer1.Panel2.Controls.Add(_Wishlist);
                _Wishlist.Show();
            }
            else
            {
                _Wishlist.Activate();
            }
        }

        private void _Wishlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Wishlist = null;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (CManager.LoginCheck == 0)
                return;
            if (_Cart == null)
            {
                _Cart = new FrmClientCart();
                _Cart.FormClosed += _Cart_FormClosed;
                _Cart.MdiParent = FrmMain.ActiveForm;
                _Cart.Dock = DockStyle.Fill;
                //splitContainer1.Panel2.Controls.Add(_Cart);
                _Cart.Show();
            }
            else
            {
                _Cart.Activate();
            }
        }

        private void _Cart_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Cart = null;
        }

        private int LogInOrNot = 0;
        private FrmClientMain _ClientMain;

        private void _ClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ClientMain = null;
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(CManager.LoginCheck ==0)
            {
                (new FrmOpacity()).Show();
                (new FrmRegister()).ShowDialog();
            }
            else if(CManager.LoginCheck ==1)
            {
                if (_ClientMain == null)
                {
                    _ClientMain = new FrmClientMain();
                    _ClientMain.FormClosed += _ClientMain_FormClosed;
                    _ClientMain.MdiParent = FrmMain.ActiveForm;
                    _ClientMain.Dock = DockStyle.Fill;
                    _ClientMain.Show();
                }
                else
                {
                    _ClientMain.Activate();
                }
            }
        }

        // 定義方法來隱藏 PANEL1 和 PANEL2
        public void HidePanels()
        {
            tableLayoutPanel3.BackColor = Color.FromArgb(0, 126, 249);
            //tableLayoutPanel3.BackColor = Color.FromArgb(24, 30, 54);
            tableLayoutPanel1.Hide();
            tableLayoutPanel2.Hide();
        }

        public void ChangeLightMode()
        {
            //Main
            tableLayoutPanel3.BackColor = Color.FromArgb(244, 144, 44);
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel2.BackColor = Color.White;
            btnService.ForeColor = Color.Black;
            btnWishlist.ForeColor = Color.Black;
            btnCart.ForeColor = Color.Black;
            btnLogIn.ForeColor = Color.Black;
            txtTitleSearchBar.ForeColor = Color.DimGray;
            txtTitleSearchBar.BackColor = Color.WhiteSmoke;
            comboBoxWest.BackColor = Color.White;
            comboBoxWest.ForeColor = Color.Black;
            comboBoxNorth.BackColor = Color.White;
            comboBoxNorth.ForeColor = Color.Black;
            comboBoxSouth.BackColor = Color.White;
            comboBoxSouth.ForeColor = Color.Black;
            comboBoxEast.BackColor = Color.White;
            comboBoxEast.ForeColor = Color.Black;

            ((FrmClientWishlist)Application.OpenForms["FrmClientWishlist"]).WishlistLightMode();
            ((FrmClientCart)Application.OpenForms["FrmClientCart"]).CartLightMode();
            ((FrmClientMain)Application.OpenForms["FrmClientMain"]).ClientLightMode();
        }

        public void ChangeDarkMode()
        {
            //Main
            tableLayoutPanel3.BackColor = Color.FromArgb(60, 60, 60);
            tableLayoutPanel1.BackColor = Color.FromArgb(60, 60, 60);
            tableLayoutPanel2.BackColor = Color.FromArgb(60, 60, 60);
            btnService.ForeColor = Color.FromArgb(255, 255, 255);
            btnWishlist.ForeColor = Color.FromArgb(255, 255, 255);
            btnCart.ForeColor = Color.FromArgb(255, 255, 255);
            btnLogIn.ForeColor = Color.FromArgb(255, 255, 255);
            txtTitleSearchBar.ForeColor = Color.FromArgb(255, 255, 255);
            txtTitleSearchBar.BackColor = Color.Gray;
            comboBoxWest.BackColor = Color.FromArgb(60, 60, 60);
            comboBoxWest.ForeColor = Color.FromArgb(255, 255, 255);
            comboBoxNorth.BackColor = Color.FromArgb(60, 60, 60);
            comboBoxNorth.ForeColor = Color.FromArgb(255, 255, 255);
            comboBoxSouth.BackColor = Color.FromArgb(60, 60, 60);
            comboBoxSouth.ForeColor = Color.FromArgb(255, 255, 255);
            comboBoxEast.BackColor = Color.FromArgb(60, 60, 60);
            comboBoxEast.ForeColor = Color.FromArgb(255, 255, 255);

            ((FrmClientWishlist)Application.OpenForms["FrmClientWishlist"]).WishlistDarkMode();
            ((FrmClientCart)Application.OpenForms["FrmClientCart"]).CartDarkMode();
            ((FrmClientMain)Application.OpenForms["FrmClientMain"]).ClientDarkMode();
        }

            public void VisibleControl()
        {
            this.tableLayoutPanel1.Visible = false;
            this.tableLayoutPanel2.Visible = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CAnimation.FadeIn(this); // 使用 CAnimation 類別的 FadeIn 方法

            this.Size = new Size(1000, 700); // 設定視窗大小

            _Wishlist = new FrmClientWishlist(); // 建立 FrmHomePage 實例
            _Wishlist.MdiParent = this;
            _Wishlist.Dock = DockStyle.Fill;
            _Wishlist.Show(); // 顯示 FrmHomePage

            _Cart = new FrmClientCart(); // 建立 FrmHomePage 實例
            _Cart.MdiParent = this;
            _Cart.Dock = DockStyle.Fill;
            _Cart.Show(); // 顯示 FrmHomePage

            _Home = new FrmHome(); // 建立 FrmHomePage 實例
            _Home.MdiParent = this;
            _Home.Dock = DockStyle.Fill;
            _Home.Show(); // 顯示 FrmHomePage

            comboWest();
            comboNorth();
            comboSouth();
            comboEast();
        }

        private void comboEast()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var side = from r in db.City
                       where r.CitySide.Contains("東部")
                       select r;

            comboBoxEast.Items.Clear();
            comboBoxEast.Items.Add("東部");
            foreach (var x in side)
            {
                comboBoxEast.Items.Add(x.CityName);
            }
            comboBoxEast.SelectedIndex = 0;
        }

        private void comboSouth()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var side = from r in db.City
                       where r.CitySide.Contains("南部")
                       select r;

            comboBoxSouth.Items.Clear();
            comboBoxSouth.Items.Add("南部");
            foreach (var x in side)
            {
                comboBoxSouth.Items.Add(x.CityName);
            }

            comboBoxSouth.SelectedIndex = 0;
        }

        private void comboNorth()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var side = from r in db.City
                       where r.CitySide.Contains("北部")
                       select r;

            comboBoxNorth.Items.Clear();
            comboBoxNorth.Items.Add("北部");
            foreach (var x in side)
            {
                comboBoxNorth.Items.Add(x.CityName);
            }

            comboBoxNorth.SelectedIndex = 0;
        }

        private void comboWest()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var side = from r in db.City
                       where r.CitySide.Contains("西部")
                       select r;

            comboBoxWest.Items.Clear();
            comboBoxWest.Items.Add("西部");

            foreach (var x in side)
            {
                comboBoxWest.Items.Add(x.CityName);
            }

            comboBoxWest.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        

        private void txtTitleSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            // 檢查是否按下了Enter鍵
            if (e.KeyCode == Keys.Enter)
            {
                // 如果搜尋視窗為空且主搜尋欄不為空值或者值為 "Searching....."，則創建一個新的搜尋視窗
                if (_Searching == null && !string.IsNullOrEmpty(txtTitleSearchBar.Text.Trim()) && txtTitleSearchBar.Text.Trim() != "Searching...")
                {
                    _Searching = new FrmSearching_v2(txtTitleSearchBar.Text.Trim());
                    _Searching.FormClosed += _Searching_FormClosed;
                    _Searching.MdiParent = FrmMain.ActiveForm;
                    _Searching.Dock = DockStyle.Fill;
                    _Searching.Show();
                }
                // 如果搜尋視窗已經存在且主搜尋欄不為空值或者值為 "Searching....."，則啟動它
                else if (_Searching != null && !string.IsNullOrEmpty(txtTitleSearchBar.Text.Trim()) && txtTitleSearchBar.Text.Trim() != "Searching...")
                {
                    _Searching.Activate();
                }
                // 如果主搜尋欄為空值或者值為 "Searching....."，顯示提示訊息
                else
                {
                    MessageBox.Show("請輸入搜尋名稱");
                }
            }
        }

        private void _Searching_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Searching = null;
        }

        private void comboBoxWest_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 確認選擇的項目不為空
            if (comboBoxWest.SelectedItem != null)
            {
                // 獲取選擇的城市名稱
                string selectedCity = comboBoxWest.SelectedItem.ToString();

                if (selectedCity != "西部")
                {
                    // 創建新的表單
                    FrmSearching_v2 newForm = new FrmSearching_v2(selectedCity);

                    // 將新的表單設置為 MDI 表單的子表單
                    newForm.MdiParent = FrmMain.ActiveForm;
                    newForm.Dock = DockStyle.Fill;

                    // 顯示新的表單
                    newForm.Show();
                }
            }
            // 選擇完後再將預設選擇改回 "西部"
            comboBoxWest.SelectedIndex = 0;

        }

        private void comboBoxNorth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 確認選擇的項目不為空
            if (comboBoxNorth.SelectedItem != null)
            {
                // 獲取選擇的城市名稱
                string selectedCity = comboBoxNorth.SelectedItem.ToString();
                if (selectedCity != "北部")
                {
                    // 創建新的表單
                    FrmSearching_v2 newForm = new FrmSearching_v2(selectedCity);

                    // 將新的表單設置為 MDI 表單的子表單
                    newForm.MdiParent = FrmMain.ActiveForm;
                    newForm.Dock = DockStyle.Fill;
                    // 顯示新的表單
                    newForm.Show();
                }
            }
            comboBoxNorth.SelectedIndex = 0;
        }

        private void comboBoxSouth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 確認選擇的項目不為空
            if (comboBoxSouth.SelectedItem != null)
            {
                // 獲取選擇的城市名稱
                string selectedCity = comboBoxSouth.SelectedItem.ToString();

                if (selectedCity != "南部")
                {
                    // 創建新的表單
                    FrmSearching_v2 newForm = new FrmSearching_v2(selectedCity);

                    // 將新的表單設置為 MDI 表單的子表單
                    newForm.MdiParent = FrmMain.ActiveForm;
                    newForm.Dock = DockStyle.Fill;
                    // 顯示新的表單
                    newForm.Show();
                }
            }
            // 選擇完後再將預設選擇改回 "西部"
            comboBoxSouth.SelectedIndex = 0;
        }

        private void comboBoxEast_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 確認選擇的項目不為空
            if (comboBoxEast.SelectedItem != null)
            {
                // 獲取選擇的城市名稱
                string selectedCity = comboBoxEast.SelectedItem.ToString();

                if (selectedCity != "東部")
                {
                    // 創建新的表單
                    FrmSearching_v2 newForm = new FrmSearching_v2(selectedCity);

                    // 將新的表單設置為 MDI 表單的子表單
                    newForm.MdiParent = FrmMain.ActiveForm;
                    newForm.Dock = DockStyle.Fill;
                    // 顯示新的表單
                    newForm.Show();
                }
            }

            comboBoxEast.SelectedIndex = 0;
        }

        private void txtTitleSearchBar_MouseEnter(object sender, EventArgs e)
        {
            if (txtTitleSearchBar.Text == "  Searching...")
            {
                txtTitleSearchBar.Text = "";
            }
        }

        private void txtTitleSearchBar_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitleSearchBar.Text))
            {
                txtTitleSearchBar.Text = "  Searching...";
            }
        }
    }
}
