using Lookday_Beta.Models;
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
    public partial class FrmStaff : Form
    {

        private FrmCustomerSystem _customerSystem;
        private FrmOrdersSystem _ordersSystem;
        private FrmProductSystem _productSystem;

        public FrmStaff()
        {
            InitializeComponent();
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            PnlNav.Height = btnCustomerSystem.Height;
            PnlNav.Top = btnCustomerSystem.Top;
            PnlNav.Left = btnCustomerSystem.Left;
            btnCustomerSystem.BackColor = Color.FromArgb(24, 30, 54);

            dblookdaysEntities db = new dblookdaysEntities();
            var user = db.User.FirstOrDefault(p => p.UserID == CCheckInfo.CurrentUserID);
            lblStaffName.Text = user.Username;

            lblStaffName.Left = (panel3.Width - lblStaffName.Width) / 2;
        }

        private void SetButtonStyle(Button button)
        {
            PnlNav.Height = button.Height;
            PnlNav.Top = button.Top;
            button.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void SetButtonLeaveColor(Button button)
        {
            button.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomerSystem_Click(object sender, EventArgs e)
        {
            SetButtonStyle(btnCustomerSystem);

            if (_ordersSystem != null)
                _ordersSystem.Close();

            if (_productSystem != null)
                _productSystem.Close();

            if (_customerSystem == null)
            {
                _customerSystem = new FrmCustomerSystem();

                _customerSystem.FormClosed += _customerSystem_FormClosed;
                _customerSystem.MdiParent = FrmMain.ActiveForm;
                _customerSystem.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(_customerSystem);
                _customerSystem.Show();
            }
            else
            {
                _customerSystem.Activate();
            }
        }

        private void _customerSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            _customerSystem = null;
        }

        private void btnProductSystem_Click(object sender, EventArgs e)
        {
            SetButtonStyle(btnProductSystem);

            if (_ordersSystem != null)
                _ordersSystem.Close();

            if (_customerSystem != null)
                _customerSystem.Close();

            if (_productSystem == null)
            {
                _productSystem = new FrmProductSystem();

                _productSystem.FormClosed += _productSystem_FormClosed;
                _productSystem.MdiParent = FrmMain.ActiveForm;
                _productSystem.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(_productSystem);
                _productSystem.Show();
            }
            else
            {
                _productSystem.Activate();
            }
        }

        private void _productSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            _productSystem = null;
        }

        private void btnOrderSystem_Click(object sender, EventArgs e)
        {
            SetButtonStyle(btnOrderSystem);


            if (_productSystem != null)
                _productSystem.Close();

            if (_customerSystem != null)
                _customerSystem.Close();

            if (_ordersSystem == null)
            {
                _ordersSystem = new FrmOrdersSystem();

                _ordersSystem.FormClosed += _orderSystem_FormClosed;
                _ordersSystem.MdiParent = FrmMain.ActiveForm;
                _ordersSystem.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(_ordersSystem);
                _ordersSystem.Show();
            }
            else
            {
                _ordersSystem.Activate();
            }
        }

        private void _orderSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ordersSystem = null;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SetButtonStyle(btnLogOut);

            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void btnCustomerSystem_Leave(object sender, EventArgs e)
        {
            SetButtonLeaveColor(btnCustomerSystem);
        }

        private void btnProductSystem_Leave(object sender, EventArgs e)
        {
            SetButtonLeaveColor(btnProductSystem);
        }

        private void btnOrderSystem_Leave(object sender, EventArgs e)
        {
            SetButtonLeaveColor(btnOrderSystem);
        }

        private void btnLogOut_Leave(object sender, EventArgs e)
        {
            SetButtonLeaveColor(btnLogOut);
        }
    }
}
