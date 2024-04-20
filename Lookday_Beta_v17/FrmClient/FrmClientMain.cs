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

namespace Lookday_Beta_v17
{
    public partial class FrmClientMain : Form
    {

        private FrmClientProfile _profile;
        private FrmClientOrders _orders;
        private FrmClientReview _review;
        private FrmClientSettings _settings;
        private bool isDarkMode = false;

        public FrmClientMain()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            if (form == null)
                return;

            form.FormClosed += (sender, e) => { form = null; };
            form.MdiParent = FrmMain.ActiveForm;
            form.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void CloseForms(params Form[] forms)
        {
            foreach (var form in forms)
            {
                if (form != null)
                    form.Close();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnProfile.BackColor = Color.DimGray; // Dark mode
            }
            else
            {
                btnProfile.BackColor = Color.Orange; // Light mode
            }

            CloseForms(_orders, _review, _settings);
            if (_profile == null)
            {
                _profile = new FrmClientProfile();
                _profile.FormClosed += (s, ev) => { _profile = null; };
            }

            if (isDarkMode)
                _profile.ProfileDarkMode();
            else
                _profile.ProfileLightMode();

            OpenForm(_profile);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnOrder.BackColor = Color.DimGray; // Dark mode
            }
            else
            {
                btnOrder.BackColor = Color.Orange; // Light mode
            }

            CloseForms(_profile, _review, _settings);
            if (_orders == null)
            {
                _orders = new FrmClientOrders();
                _orders.FormClosed += (s, ev) => { _orders = null; };
            }

            if (isDarkMode)
                _orders.OrdersDarkMode();
            else
                _orders.OrdersLightMode();

            OpenForm(_orders);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnReview.BackColor = Color.DimGray; // Dark mode
            }
            else
            {
                btnReview.BackColor = Color.Orange; // Light mode
            }

            CloseForms(_orders, _profile, _settings);
            if (_review == null)
            {
                _review = new FrmClientReview();
                _review.FormClosed += (s, ev) => { _review = null; };
            }

            if (isDarkMode)
                _review.ReviewDarkMode();
            else
                _review.ReviewLightMode();

            OpenForm(_review);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnSettings.BackColor = Color.DimGray; // Dark mode
            }
            else
            {
                btnSettings.BackColor = Color.Orange; // Light mode
            }

            CloseForms(_orders, _profile, _review);
            if (_settings == null)
            {
                _settings = new FrmClientSettings();
                _settings.FormClosed += (s, ev) => { _settings = null; };
            }

            if (isDarkMode)
                _settings.SettingsDarkMode();
            else
                _settings.SettingsLightMode();

            OpenForm(_settings);
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //while (ActiveMdiChild != null)
            //{
            //    this.ActiveMdiChild.Close();
            //}

            string message = "Are you sure want to logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                ((FrmMain)Application.OpenForms["FrmMain"]).btnLogIn.Text = "Log In";
                CManager.LoginCheck = 0;
                this.Close();
            }
            else return;

            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void FrmClientMain_Load(object sender, EventArgs e)
        {
            if (_profile == null)
            {
                _profile = new FrmClientProfile();
                _profile.FormClosed += (s, ev) => { _profile = null; };
            }
            OpenForm(_profile);
        }

        public void ClientLightMode()
        {
            isDarkMode = false;
            splitContainer1.Panel1.BackColor = Color.FromArgb(244, 132, 20);
            btnProfile.BackColor = Color.FromArgb(244, 132, 20);
            btnOrder.BackColor = Color.FromArgb(244, 132, 20);
            btnReview.BackColor = Color.FromArgb(244, 132, 20);
            btnSettings.BackColor = Color.FromArgb(244, 132, 20);
            btnLogOut.BackColor = Color.FromArgb(244, 132, 20);

            //_profile.ProfileLightMode();
            //((FrmClientOrders)Application.OpenForms["FrmClientOrders"]).OrdersLightMode();
            //((FrmClientReview)Application.OpenForms["FrmClientReview"]).ReviewLightMode();
            //((FrmClientSettings)Application.OpenForms["FrmClientSettings"]).SettingsLightMode();
        }

        public void ClientDarkMode()
        {
            isDarkMode = true;

            splitContainer1.Panel1.BackColor = Color.FromArgb(60, 60, 60);
            btnProfile.BackColor = Color.FromArgb(60, 60, 60);
            btnOrder.BackColor = Color.FromArgb(60, 60, 60);
            btnReview.BackColor = Color.FromArgb(60, 60, 60);
            btnSettings.BackColor = Color.FromArgb(60, 60, 60);
            btnLogOut.BackColor = Color.FromArgb(60, 60, 60);

            //((FrmClientProfile)Application.OpenForms["FrmClientProfile"]).ProfileDarkMode();
            //((FrmClientOrders)Application.OpenForms["FrmClientOrders"]).OrdersDarkMode();
            //((FrmClientReview)Application.OpenForms["FrmClientReview"]).ReviewDarkMode();
            //((FrmClientSettings)Application.OpenForms["FrmClientSettings"]).SettingsDarkMode();
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnProfile.BackColor = Color.FromArgb(60, 60, 60); // Dark mode
            }
            else
            {
                btnProfile.BackColor = Color.FromArgb(244, 132, 20); // Light mode
            }
        }

        private void btnOrder_Leave(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnOrder.BackColor = Color.FromArgb(60, 60, 60); // Dark mode
            }
            else
            {
                btnOrder.BackColor = Color.FromArgb(244, 132, 20); // Light mode
            }
        }

        private void btnReview_Leave(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnReview.BackColor = Color.FromArgb(60, 60, 60); // Dark mode
            }
            else
            {
                btnReview.BackColor = Color.FromArgb(244, 132, 20); // Light mode
            }
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnSettings.BackColor = Color.FromArgb(60, 60, 60); // Dark mode
            }
            else
            {
                btnSettings.BackColor = Color.FromArgb(244, 132, 20); // Light mode
            }
        }

        private void btnLogOut_Leave(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                btnLogOut.BackColor = Color.FromArgb(60, 60, 60); // Dark mode
            }
            else
            {
                btnLogOut.BackColor = Color.FromArgb(244, 132, 20); // Light mode
            }
        }
    }
}
