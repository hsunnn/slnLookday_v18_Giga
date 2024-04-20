using Lookday_Beta;
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
    public partial class FrmClientCart : Form
    {

        private FrmHome _Home;

        public FrmClientCart()
        {
            InitializeComponent();
        }
        private void plus(Cartbox p)
        {
            //int currentPanelPosition = flowLayoutPanel1.VerticalScroll.Value;
            dblookdaysEntities db = new dblookdaysEntities(); //change
            //var cart = from r in db.Bookings
            //           where r.BookingID == p.booking.BookingID && p.booking.UserID == CCheckInfo.CurrentUserID
            //           select r;
            //foreach (var item in cart)
            //{
            //    item.Member++;
            //    if (item.Member > item.Activities.Remaining)
            //    {
            //        MessageBox.Show("可選人數已達上限");
            //        return;
            //    }
            //    p.booking = item;
            //}
            var cart1 = db.Bookings.FirstOrDefault(
                b => b.BookingID == p.booking.BookingID
                && p.booking.UserID == CCheckInfo.CurrentUserID);
            cart1.Member++;
            if (cart1.Member > cart1.Activities.Remaining)
            {
                MessageBox.Show("可選人數已達上限");
                return;
            }
            p.booking = cart1;
            db.SaveChanges();
            var bs = db.Bookings.Where(b => b.BookingStatesID == 1 && b.UserID == CCheckInfo.CurrentUserID);
            this.lblTotal.Text = "總金額：" + bs.Select(x=>x.Price*x.Member).Sum().Value.ToString("c0");
            

            //flowLayoutPanel1.Controls.Clear();
            //queryCart();
            //flowLayoutPanel1.VerticalScroll.Value = currentPanelPosition;////固定滾輪位置
        }
        private void minus(Cartbox p)
        {
            //int currentPanelPosition = flowLayoutPanel1.VerticalScroll.Value;
            dblookdaysEntities db = new dblookdaysEntities(); //change
            var cart1 = db.Bookings.FirstOrDefault(b => b.BookingID == p.booking.BookingID && p.booking.UserID == CCheckInfo.CurrentUserID);
            //var cart = from r in db.Bookings
            //           where r.BookingID == p.booking.BookingID && p.booking.UserID == CCheckInfo.CurrentUserID
            //           select r;
            //foreach (var item in cart)
            //{
            //    item.Member--;
            cart1.Member--;
                if (cart1.Member < 1)
                {
                    MessageBox.Show("至少須有一人");
                    return;
                }
                p.booking = cart1;
            //}
            db.SaveChanges();
            var bs = db.Bookings.Where(b => b.BookingStatesID == 1 && b.UserID == CCheckInfo.CurrentUserID);
            this.lblTotal.Text = "總金額：" + bs.Select(x => x.Price * x.Member).Sum().Value.ToString("c0");
            //flowLayoutPanel1.Controls.Clear();
            //queryCart();
            //flowLayoutPanel1.VerticalScroll.Value = currentPanelPosition;//固定滾輪位置
        }
        private void confirm(Cartbox p)
        {
            DialogResult result = MessageBox.Show("再想一下啦，真的很好玩捏(´•༝•`)", "Look Day", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                dblookdaysEntities db = new dblookdaysEntities(); //change
                var cart = (from r in db.Bookings
                            where r.BookingID == p.booking.BookingID && p.booking.UserID == CCheckInfo.CurrentUserID
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
                        where r.BookingStatesID == 1 && r.UserID == CCheckInfo.CurrentUserID
                        select r;
            decimal total = 0;//放迴圈裡的話每次都會初始化=0一次 所以要放外面
            foreach (var r in order)
            {
                Cartbox cb = new Cartbox();
                cb.booking = r;//讀取資料庫中的資料到usercontrol               
                flowLayoutPanel1.Controls.Add(cb);
                cb.deleteConfirm += this.confirm;  //註冊事件 (去控制項寫delegate
                cb.memberPlus += this.plus;
                cb.memberMinus += this.minus;
                total += r.Price * Convert.ToDecimal(r.Member);
            }
            lblTotal.Text = "總金額：" + total.ToString("c0");
        }

        private void FrmClientCart_Load(object sender, EventArgs e)
        {
            queryCart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var order = from r in db.Bookings
                        join user in db.User
                        on r.UserID equals user.UserID
                        join activity in db.Activities
                        on r.ActivityID equals activity.ActivityID
                        where r.BookingStatesID == 1
                        select new
                        {
                            bookingstate = r
                            //這bookingstate我隨便設的變數名稱 我也不知道為什麼要設變數 但設了才能繼續用 ㄏ
                        };

            if (flowLayoutPanel1 == null || flowLayoutPanel1.Controls.Count == 0)//檢查購物車裡有沒有東西
            {
                MessageBox.Show("購物車暫無商品");
            }
            else
            {
                DialogResult result = MessageBox.Show("確定要購買嗎", "Look Day", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    foreach (var item in order)
                    {
                        item.bookingstate.BookingStatesID = 3;
                        //結帳後將訂單狀態改為已完成(StatesID = 3)

                        item.bookingstate.BookingDate = DateTime.Now;
                        //按下結帳按鈕同時修改資料表中bookingDate欄位

                        item.bookingstate.Activities.Remaining -= item.bookingstate.Member;
                        //結帳後將活動表中的剩餘數量減去此筆訂單參加人數
                    }
                    db.SaveChanges();
                    flowLayoutPanel1.Controls.Clear();
                    queryCart();
                    MessageBox.Show("訂單已成立");
                }
            }
        }

        private void FrmClientCart_Activated(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            queryCart();
        }

        public void CartLightMode()
        {
            splitContainer1.Panel1.BackColor = Color.White;
            lblTotal.ForeColor = Color.Black;
            label3.ForeColor = Color.Gray;
        }

        public void CartDarkMode()
        {
            splitContainer1.Panel1.BackColor = Color.DimGray;
            lblTotal.ForeColor = Color.White;
            label3.ForeColor = Color.Gainsboro;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (_Home == null)
            {
                _Home = new FrmHome();
                _Home.FormClosed += _Home_FormClosed;
                _Home.MdiParent = FrmMain.ActiveForm;
                _Home.Dock = DockStyle.Fill;
                //splitContainer1.Panel2.Controls.Add(_Home);
                _Home.Show();
            }
            else
            {
                _Home.Activate();
            }
        }

        private void _Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Home = null;
        }
    }
}
