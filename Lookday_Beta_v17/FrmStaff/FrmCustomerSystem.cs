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
    public partial class FrmCustomerSystem : Form
    {
        private User _UserData;
        public User UserData
        {
            get
            {
                if (_UserData == null)
                {
                    _UserData = new User();
                }
                _UserData.UserID = Convert.ToInt32(txtUserID.Text);
                _UserData.RoleID = Convert.ToInt32(txtRoleID.Text);
                _UserData.Preferences = Convert.ToInt32(txtPreference.Text);
                _UserData.Username = txtUsername.Text;
                _UserData.Password = CCryptography.HashPasswordWithSalt(txtPassword.Text);
                _UserData.Email = txtEmail.Text;
                return _UserData;
            }
            set
            {
                _UserData = value;
                txtUserID.Text = _UserData.UserID.ToString();
                txtRoleID.Text = _UserData.RoleID.ToString();
                txtPreference.Text = _UserData.Preferences.ToString();
                txtUsername.Text = _UserData.Username;
                txtPassword.Text = _UserData.Password;
                txtEmail.Text = _UserData.Email;
            }
        }
        private void queryAll()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var user = from p in db.User select p;
            dataGridView1.DataSource = user.ToList();
        }

        public FrmCustomerSystem()
        {
            InitializeComponent();
        }

        private void FrmCustomerSystem_Load(object sender, EventArgs e)
        {
            queryAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            displayInfo(id);
        }
        private void displayInfo(int id)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            User user = db.User.FirstOrDefault(p => p.UserID == id);
            if (user == null) return;
            UserData = user;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            int id = Convert.ToInt32(txtUserID.Text);
            User user = db.User.FirstOrDefault(p=>p.UserID == id);
            if (user == null) return;
            user.UserID = Convert.ToInt32(txtUserID.Text);
            user.RoleID = Convert.ToInt32(txtRoleID.Text);
            user.Preferences = Convert.ToInt32(txtPreference.Text);
            user.Username = txtUsername.Text;
            user.Password = CCryptography.HashPasswordWithSalt(txtPassword.Text);
            user.Email = txtEmail.Text;
            db.SaveChanges();
            queryAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (dblookdaysEntities db = new dblookdaysEntities())
            {
                User NewUser = new User
                {
                    UserID = Convert.ToInt32(txtUserID.Text),
                    RoleID = Convert.ToInt32(txtRoleID.Text),
                    Preferences = Convert.ToInt32(txtPreference.Text),
                    Username = txtUsername.Text,
                    Password = CCryptography.HashPasswordWithSalt(txtPassword.Text),
                    Email = txtEmail.Text,
                };
                db.User.Add(NewUser);
                db.SaveChanges();
            }
            queryAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            if(r.Cells.Count <= 0) return;
            DataGridViewCell c = r.Cells[0];
            int id = (int)c.Value;

            dblookdaysEntities db = new dblookdaysEntities();
            User user = db.User.FirstOrDefault(p=>p.UserID == id);
            if(user == null) return;
            db.User.Remove(user);
            db.SaveChanges();
            queryAll();
        }
    }
}
