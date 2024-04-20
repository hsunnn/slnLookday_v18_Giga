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

namespace Lookday_Beta_v17.FrmLookday
{
    public partial class FrmWriteReview : Form
    {
        public FrmWriteReview()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CManager.CloseFormsAndActivateMain(this);
        }
    }
}
