using Lookday_Beta.Models;
using Lookday_Beta_v17.Cart;
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
    public partial class FrmClientWishlist : Form
    {
        public FrmClientWishlist()
        {
            InitializeComponent();
        }

        private void confirm(Wishlistbox p)
        {
            DialogResult result = MessageBox.Show("真的要移除收藏嗎(*´･д･)?", "Look Day", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                dblookdaysEntities db = new dblookdaysEntities(); //change
                var cart = (from r in db.Bookings
                            where r.BookingID == p.wishlist.BookingID
                            select r).FirstOrDefault(); //從資料庫刪除這個Button對應到的購物車ID
                db.Bookings.Remove(cart);
                db.SaveChanges();
                flowLayoutPanel1.Controls.Clear();
                queryCart();
            }
        }

        private void queryCart()
        {
            dblookdaysEntities db = new dblookdaysEntities();//change
            var order = from r in db.Bookings
                        where r.BookingStatesID == 2 && r.UserID == CCheckInfo.CurrentUserID
                        select r;
            foreach (var r in order)
            {
                Wishlistbox wb = new Wishlistbox();
                wb.wishlist = r;//讀取資料庫中的資料到usercontrol               
                flowLayoutPanel1.Controls.Add(wb);
                wb.deleteConfirm += this.confirm;  //註冊事件 (去控制項寫delegate
                wb.addtoCar += this.addtocar;
            }
        }

        private void addtocar(Wishlistbox p)
        {
            using (dblookdaysEntities db = new dblookdaysEntities())
            {
                // 根據 p.wishlist 的 BookingID 查詢該筆資料
                var booking = db.Bookings.FirstOrDefault(b => b.BookingID == p.wishlist.BookingID);

                if (booking != null)
                {
                    // 將該筆資料的 BookingStatesID 變為 1
                    booking.BookingStatesID = 1;

                    // 儲存更改到資料庫
                    db.SaveChanges();

                    // 清空流式佈局面板並重新加載資料
                    flowLayoutPanel1.Controls.Clear();
                    queryCart();

                    MessageBox.Show("已加入購物車");
                }
            }
        }





        public void WishlistLightMode()
        {
            panel1.BackColor = Color.Orange;
        }

        public void WishlistDarkMode()
        {
            panel1.BackColor = Color.DimGray;
        }

        private void FrmClientWishlist_Load(object sender, EventArgs e)
        {
            queryCart();

        }

        private void FrmClientWishlist_Activated(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            queryCart();
        }
    }
}
