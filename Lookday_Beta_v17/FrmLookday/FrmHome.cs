using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookday_Beta_v17
{
    public partial class FrmHome : Form
    {
        private FrmMain _Main;
        private FrmSearching_v2 _Searching;

        public FrmHome()
        {
            InitializeComponent();
        }
        private FrmSearching_v2 secondForm;
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtMainSearchingBar.Text))
        //    {
        //        // 如果第二個表單尚未實例化或已關閉，則創建新實例並顯示
        //        if (secondForm == null || secondForm.IsDisposed)
        //        {
        //            // 取得 TextBox 的值
        //            string valueToPass = txtMainSearchingBar.Text;
        //            // 創建並顯示第二個表單
        //            secondForm = new FrmSearching_v2(valueToPass);
        //            secondForm.FormClosed += SecondForm_FormClosed; // 添加事件處理程序
        //            _Searching.MdiParent = FrmMain.ActiveForm;
        //            _Searching.Dock = DockStyle.Fill;
        //            secondForm.ShowDialog();
        //        }
        //        //else
        //        //{
        //        //    // 如果已經打開，則將其帶到前台
        //        //    secondForm.BringToFront();
        //        //}
        //    }
        //    else
        //    {
        //        MessageBox.Show("請輸入搜索欄");
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)//搜尋
        {
            // 如果主搜尋欄為空值或者值為 "Searching....."，顯示提示訊息
            if (string.IsNullOrEmpty(txtMainSearchingBar.Text) || txtMainSearchingBar.Text.Trim() == "Searching...")
            {
                MessageBox.Show("請輸入搜尋名稱");
                return;
            }

            // 如果沒有已經開啟的搜尋視窗，則創建一個新的搜尋視窗
            if (_Searching == null)
            {
                string valueToPass = txtMainSearchingBar.Text;
                _Searching = new FrmSearching_v2(txtMainSearchingBar.Text);
                _Searching.FormClosed += _Searching_FormClosed;
                _Searching.MdiParent = FrmMain.ActiveForm;
                _Searching.Dock = DockStyle.Fill;
                _Searching.Show();
            }
            // 如果已經存在一個搜尋視窗，則啟動它
            else
            {
                _Searching.Activate();
            }
        }
        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 當第二個表單關閉時，將其實例設置為 null
            secondForm = null;
        }

        private void _Searching_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Searching = null;
        }

        private void showHotSearchSuggestions()
        {
            flowLayoutPanel1.Visible = false;
            // 清除之前的建议
            flowLayoutPanel1.Controls.Clear();


            //// 获取热门搜索建议
            string[] suggestions = { "台北", "宜蘭", "台中", "台東" };

            //// 将热门搜索建议添加到 FlowLayoutPanel 中的 Label 控件中
            foreach (string suggestion in suggestions)
            {
                Label label = new Label();
                label.Text = suggestion;
                label.AutoSize = true;
                label.Padding = new Padding(5);
                label.Margin = new Padding(5);
                label.BackColor = Color.LightGray;
                label.Click += (sender, e) =>
                {
                    // 点击建议时，将建议填充到 TextBox 中
                    txtMainSearchingBar.Text = suggestion;
                    // 清除热门搜索建议
                    flowLayoutPanel1.Controls.Clear();
                };

                // 将 Label 添加到 FlowLayoutPanel 中
                flowLayoutPanel1.Controls.Add(label);
            }

            // 显示 FlowLayoutPanel 中的建议
            flowLayoutPanel1.Visible = true;

        }

        private void txtMainSearchingBar_Click(object sender, EventArgs e)
        {
            showHotSearchSuggestions();
        }

        private void txtMainSearchingBar_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMainSearchingBar.Text))
            {
                txtMainSearchingBar.Text = "Searching...";
            }

        }

        private void txtMainSearchingBar_MouseEnter(object sender, EventArgs e)
        {
            if (txtMainSearchingBar.Text == "Searching...")
            {
                txtMainSearchingBar.Text = "";
            }
        }
    }
}
