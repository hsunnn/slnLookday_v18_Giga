using Lookday_Beta.Models;
using Lookday_Beta;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lookday_Beta_v17
{
    public partial class FrmClientOrders : Form
    {
        public FrmClientOrders()
        {
            InitializeComponent();
        }

        private void queryHis()
        {
            dblookdaysEntities db = new dblookdaysEntities(); //change
            var order = from r in db.Bookings
                        join user in db.User
                        on r.UserID equals user.UserID
                        where r.BookingStatesID == 3 && user.UserID == CCheckInfo.CurrentUserID//目前暫時把登入者ID寫死
                        //BookingStatesID == 3 (3代表結帳完成)
                        orderby r.BookingDate descending
                        select r;

            foreach (var r in order)
            {
                OrderHisbox oh = new OrderHisbox();
                oh.booking = r;//讀取資料庫中的資料到usercontrol               
                flowLayoutPanel1.Controls.Add(oh);
            }
        }

        private void FrmClientOrders_Load(object sender, EventArgs e)
        {
            queryHis();
        }

        public void OrdersLightMode()
        {
            panel1.BackColor = Color.Orange;
            label2.BackColor = Color.Orange;
            flowLayoutPanel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        public void OrdersDarkMode()
        {
            panel1.BackColor = Color.DimGray;
            label2.BackColor = Color.DimGray;
            flowLayoutPanel1.BackColor = Color.LightGray;
        }
    }
}
