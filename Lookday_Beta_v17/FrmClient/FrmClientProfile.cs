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
    public partial class FrmClientProfile : Form
    {
        public FrmClientProfile()
        {
            InitializeComponent();
            PasswordTextBox();
        }

        private void FrmClientProfile_Load(object sender, EventArgs e)
        {
            querryAll();
        }

        private void querryAll()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var user = db.User.FirstOrDefault(p => p.UserID == CCheckInfo.CurrentUserID);
            label1.Text = user.Username;
            textBox1.Text = user.Email;
            textBox2.Text = "";
            textBox3.Text = "";

            label1.Left = (panel1.Width - label1.Width) / 2;
        }

        public void ProfileLightMode()
        {
            panel1.BackColor = Color.Orange;
            pictureBox1.BackColor = Color.Orange;
            label1.BackColor = Color.Orange;
            label2.BackColor = Color.Orange;
            label3.BackColor = Color.Orange;
            label4.BackColor = Color.Orange;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        public void ProfileDarkMode()
        {
            panel1.BackColor = Color.DimGray;
            pictureBox1.BackColor = Color.DimGray;
            label1.BackColor = Color.DimGray;
            label2.BackColor = Color.DimGray;
            label3.BackColor = Color.DimGray;
            label4.BackColor = Color.DimGray;
            textBox1.BackColor = Color.LightGray;
            textBox2.BackColor = Color.LightGray;
            textBox3.BackColor = Color.LightGray;
        }

        public void PasswordTextBox()
        {
            textBox2.MaxLength = textBox2.Text.Length;
            textBox2.PasswordChar = '*';
            textBox2.CharacterCasing = CharacterCasing.Lower;
            textBox3.MaxLength = textBox3.Text.Length;
            textBox3.PasswordChar = '*';
            textBox3.CharacterCasing = CharacterCasing.Lower;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(textBox2.Text =="" && textBox3.Text =="")
            {
                MessageBox.Show("Empty value");
                return;
            }
            else if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Repeat Passwords are wrong");
                return;
            }
            dblookdaysEntities db = new dblookdaysEntities();
            int id = CCheckInfo.CurrentUserID;
            User user = db.User.FirstOrDefault(p => p.UserID == id);
            if (user == null) return;
            var confirm = MessageBox.Show( "Confirm Changes?", "Are you sure you want Change Passwords?", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;
            else if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("Save Changes");
            }
            user.Password = CCryptography.HashPasswordWithSalt(textBox2.Text);
            db.SaveChanges();
            querryAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            int id = CCheckInfo.CurrentUserID;
            User user = db.User.FirstOrDefault(p => p.UserID == id);
            if (user == null) return;
            var confirm = MessageBox.Show( "Confirm Changes?", "Are you sure you want to Change Email?", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;
            else if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("Save Changes");
            }
            user.Email = textBox1.Text;
            db.SaveChanges();
            querryAll();
        }
    }
}
