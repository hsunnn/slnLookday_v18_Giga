using Lookday_Beta.Models;
using Lookday_Beta.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lookday_Beta.FrmClient;
using System.Reflection.Emit;

namespace Lookday_Beta_v17
{
    public partial class FrmClientReview : Form
    {
        public FrmClientReview()
        {
            InitializeComponent();
        }

        private void FrmClientReview_Load(object sender, EventArgs e)
        {
            dblookdaysEntities db = new dblookdaysEntities(); //change
            var order = from r in db.Bookings
                        join user in db.User
                        on r.UserID equals user.UserID
                        where r.BookingStatesID == 3 && user.UserID == CCheckInfo.CurrentUserID
                        orderby r.BookingDate descending
                        select r;

            foreach (var r in order)
            {
                OrderReviewBox oh = new OrderReviewBox();
                oh.booking = r;//讀取資料庫中的資料到usercontrol               
                flowLayoutPanel1.Controls.Add(oh);
            }
        }

        public void ReviewLightMode()
        {
            panel1.BackColor = Color.Orange;
            label2.BackColor = Color.Orange;
            flowLayoutPanel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        public void ReviewDarkMode()
        {
            panel1.BackColor = Color.DimGray;
            label2.BackColor = Color.DimGray;
            flowLayoutPanel1.BackColor = Color.LightGray;
        }
    }
}
