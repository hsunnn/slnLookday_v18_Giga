using Lookday_Beta.Models;
using Lookday_Beta_v17.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lookday_Beta_v17
{
    public partial class FrmLogIn : Form
    {
        private FrmStaff _Staff;
        public string _LogInEmail { get { return textBox1.Text; } }
        public string _LogInPassword { get { return textBox2.Text; } }
        private FrmClientMain _ClientMain;

        public bool UserInputCheck()
        {
            if (textBox1.Text == "")
                return true;
            else if (textBox2.Text == "")
                return true;
            else
                return false;
        }
        public void PasswordTextBox()
        {
            textBox2.MaxLength = 36;
            textBox2.PasswordChar = '*';
            textBox2.CharacterCasing = CharacterCasing.Lower;
        }

        public FrmLogIn()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(LogInForm_FormClosing);
            PasswordTextBox();
        }
        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (_Staff == null)
            {
                _Staff = new FrmStaff();
                _Staff.FormClosed += _Staff_FormClosed;
                _Staff.MdiParent = this.MdiParent as FrmMain;
                _Staff.Dock = DockStyle.Fill;
                _Staff.Show();
            }
            else
            {
                _Staff.Activate();
            }
        }

        private void _Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Staff = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CManager.CloseFormsAndActivateMain(this);
            if (UserInputCheck())
            {
                MessageBox.Show("請輸入完整資料");
                return;
            }
            if (!CCheckInfo.CheckUser(textBox1.Text))
            {
                MessageBox.Show("User not found");
                return;
            }
            if (!CCheckInfo.CheckPassword(textBox2.Text))
            {
                MessageBox.Show("Wrong Password");
                return;
            }
            if (CCheckInfo.CheckUserRole(textBox1.Text) == 2)
            {
                CCheckInfo.StaffMode = true;
                CManager.CloseFormsAndActivateMain(this);
            }
            CManager.LoginCheck = 1;
            CCheckInfo.CurrentUserID = CCheckInfo.LoginUserID(textBox1.Text);
            //MessageBox.Show(CCheckInfo.CurrentUserID.ToString());  //顯示登入者ID
            //MessageBox.Show(CCheckInfo.CheckUserRole(textBox1.Text).ToString());  //顯示登入角色
            ((FrmMain)Application.OpenForms["FrmMain"]).btnLogIn.Text = "PROFILE";
            MessageBox.Show("Log in success");
            //CManager.CloseFormsAndActivateMain(this);

            //if (_ClientMain == null)
            //{
            //    _ClientMain = new FrmClientMain();
            //    _ClientMain.FormClosed += _ClientMain_FormClosed;
            //    _ClientMain.MdiParent = FrmMain.ActiveForm;
            //    _ClientMain.Dock = DockStyle.Fill;
            //    _ClientMain.Show();
            //}
            //else
            //{
            //    _ClientMain.Activate();
            //}

            //dblookdaysEntities db = new dblookdaysEntities();
            //var user = db.User.FirstOrDefault(p => p.UserID == CCheckInfo.CurrentUserID);
            //((FrmMain)Application.OpenForms["FrmMain"]).btnLogIn.Text = user.Username;
            
        }

        private void _ClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ClientMain = null;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // 執行查詢功能
                button1_Click(sender, e);

                // 防止輸入的Enter鍵被TextBox接收，避免換行
                e.Handled = true;
            }
        }

        private void btnClientDemo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "dudubird";
            textBox2.Text = "123456";
        }

        private void btnStaffDemo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "mod";
            textBox2.Text = "123456";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ((FrmRegister)Application.OpenForms["FrmRegister"]).btnSignUp_Click(sender, e);

        }
    }
}

