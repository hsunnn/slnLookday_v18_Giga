using Lookday_Beta.Models;
using Register_and_login_test;
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
    public partial class FrmSignUp : Form
    {
        private User _user;
        public User user
        {
            get
            {
                if (_user == null)
                {
                    _user = new User();
                }
                _user.Username = textBox1.Text;
                _user.Email = textBox2.Text;
                _user.Password = textBox3.Text;
                return _user;
            }
            set
            {
                _user = value;
                textBox1.Text = _user.Username;
                textBox2.Text = _user.Email;
                textBox3.Text = _user.Password;
            }
        }
        public void PasswordTextBox()
        {
            textBox2.MaxLength = 36;
            textBox2.PasswordChar = '*';
            textBox2.CharacterCasing = CharacterCasing.Lower;
        }
        public FrmSignUp()
        {
            InitializeComponent();
            PasswordTextBox();
        }

        public bool UserInputCheck()
        {
            if (textBox1.Text == "")
                return true;
            else if (textBox2.Text == "")
                return true;
            else if (textBox3.Text == "")
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserInputCheck())
            {
                MessageBox.Show("請輸入完整資料");
                return;
            }
            if (CCheckInfo.CheckEmail(textBox1.Text))
            {
                MessageBox.Show("Email allready use");
                return;
            }
            if (CCheckInfo.CheckUser(textBox3.Text))
            {
                MessageBox.Show("Username allready use");
                return;
            }

            CCryptography authenticator = new CCryptography();

            string hashpassword = CCryptography.HashPasswordWithSalt(textBox2.Text);
            dblookdaysEntities ld = new dblookdaysEntities();
            User u = new User
            {
                Email = textBox1.Text,
                Username = textBox3.Text,
                Password = hashpassword,
                RoleID = 1,
            };
            MessageBox.Show("註冊成功");
            ld.User.Add(u);
            ld.SaveChanges();
        }
    }
}
