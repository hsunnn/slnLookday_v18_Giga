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
    public partial class FrmClientSettings : Form
    {
        public FrmClientSettings()
        {
            InitializeComponent();
        }

        public void SettingsLightMode()
        {
            panel1.BackColor = Color.Orange;
        }

        public void SettingsDarkMode()
        {
            panel1.BackColor = Color.DimGray;
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DimGray;
            ((FrmMain)Application.OpenForms["FrmMain"]).ChangeDarkMode();
        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Orange;
            ((FrmMain)Application.OpenForms["FrmMain"]).ChangeLightMode();
        }
    }
}
