using Lookday_Beta.Models;
using Lookday_Beta.Product;
using Lookday_Beta_v17.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookday_Beta_v17
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
            CAnimation.FadeIn(this);
            InitializeButtonColors();
        }
        private CproductDetails _productDetails = new CproductDetails();
        private Reviews _reviews = new Reviews();
        public int ActivityID { get; set; }

        private void InitializeButtonColors()
        {
            // 初始化按鈕顏色
            //btnPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            //btnPrevious.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            //btnNext.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 關閉透明層
            Form transparentForm = Application.OpenForms["FrmOpacity_Big"];
            transparentForm?.Close();

            // 關閉本 Form
            this.Close();

            // 強制主視窗顯示在最上層
            Form mainForm = Application.OpenForms["FrmMain"];
            mainForm?.Activate();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            //btnPrevious.Hide();
            //btnNext.Hide();
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;

            var activity = _productDetails.GetActivityDetails(ActivityID);
            if (activity != null)
            {
                label1.Text = activity.Name;
                labelBox1.content = activity.Description;
                labelBox2.content = activity.Price.ToString("c0");
                labelBox2.Tag = activity.Price.ToString();//Tag是沙小?
                labelBox3.content = activity.Date.ToString();
                labelBox4.content = activity.City.CityName;
                labelBox5.content = activity.Remaining.ToString();
                labelBox6.content = activity.Hotels.Name;

                byte[] photo = _productDetails.GetActivityPhoto(ActivityID);
                if (photo != null && photo.Length > 0)
                {
                    // 將圖片資料轉換為圖片
                    using (MemoryStream ms = new MemoryStream(photo))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            GetReviews();
        }

        private void GetReviews()
        {
            this.flowLayoutPanel1.Controls.Clear();
            dblookdaysEntities db = new dblookdaysEntities();
            var review = from r in db.Reviews
                         where r.ActivityID == ActivityID
                         select r;
            foreach (var reviews in review)
            {
                ReviewBox r = new ReviewBox();
                r.review = reviews;
                this.flowLayoutPanel1.Controls.Add(r);
            }
        }
        private int userID;

        private void button1_Click(object sender, EventArgs e)
        {
            if (CManager.LoginCheck ==0)
            {
                MessageBox.Show("Please Login first");
                return;
            }
            // 建立新的 Bookings 物件並設置屬性值
            Bookings newBooking = new Bookings
            {
                UserID = CCheckInfo.CurrentUserID, // 替換為獲取當前用戶ID的方法
                ActivityID = ActivityID, // 使用 FrmProduct 中的 ActivityID
                BookingDate = DateTime.Now, // 使用當前日期時間作為預訂日期
                Price = Convert.ToDecimal(labelBox2.Tag), // 使用介面元件上的價格資訊
                BookingStatesID = 1, // 替換為預設的預訂狀態ID
                Member = 1
            };

            // 將新的 Bookings 物件添加到資料庫中
            using (var db = new dblookdaysEntities()) //change
            {
                db.Bookings.Add(newBooking);
                db.SaveChanges();
            }

            // 提示用戶預訂成功或其他操作
            MessageBox.Show("成功加入至購物車");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CManager.LoginCheck == 0)
            {
                MessageBox.Show("Please Login first");
                return;
            }


            using (var db = new dblookdaysEntities()) //change
            {
                var existingBooking = db.Bookings.FirstOrDefault(b =>
                    b.UserID == CCheckInfo.CurrentUserID &&
                    b.ActivityID == ActivityID &&
                    b.BookingStatesID == 2); // 假設 BookingStatesID 為 2 表示待預訂的狀態

                if (existingBooking != null)
                {
                    MessageBox.Show("此行程已在收藏清單");
                    return;
                }
            }


            // 建立新的 Bookings 物件並設置屬性值
            Bookings newBooking = new Bookings
            {
                UserID = CCheckInfo.CurrentUserID, // 替換為獲取當前用戶ID的方法
                ActivityID = ActivityID, // 使用 FrmProduct 中的 ActivityID
                BookingDate = DateTime.Now, // 使用當前日期時間作為預訂日期
                Price = Convert.ToDecimal(labelBox2.Tag), // 使用介面元件上的價格資訊
                BookingStatesID = 2, // 替換為預設的預訂狀態ID
                Member = 1
            };

            // 將新的 Bookings 物件添加到資料庫中
            using (var db = new dblookdaysEntities()) //change
            {
                db.Bookings.Add(newBooking);
                db.SaveChanges();
            }

            // 提示用戶預訂成功或其他操作
            MessageBox.Show("成功加入至願望清單");
        }
    }
}
