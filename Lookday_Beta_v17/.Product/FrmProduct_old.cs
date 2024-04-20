using Lookday_Beta.Models;
using Lookday_Beta_v17;
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

namespace Lookday_Beta.Product
{
    public partial class FrmProduct_old : Form
    {

        public FrmProduct_old()
        {
            InitializeComponent();
        }

        private CproductDetails _productDetails = new CproductDetails();
        private Reviews _reviews = new Reviews();

        public int ActivityID { get;set;}


        private void FrmProduct_Load(object sender, EventArgs e)
        {

            var activity = _productDetails.GetActivityDetails(ActivityID);
            if (activity != null)
            {
                // 在這裡使用 activity 填充視窗中的資料
                // 例如：
                label1.Text = activity.Name;
                labelBox1.content = activity.Description;
                labelBox2.content = activity.Price.ToString();
                labelBox3.content = activity.Date.ToString();
                labelBox4.content = activity.City.CityName;
                labelBox5.content = activity.Remaining.ToString();
                labelBox6.content = activity.Hotels.Name;

                // 檢查圖片資料是否有效
                // 從 ActivitiesAlbum 資料表中獲取圖片資料
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

        private int userID ;

        private void button1_Click(object sender, EventArgs e)
        {
            // 建立新的 Bookings 物件並設置屬性值
            Bookings newBooking = new Bookings
            {
                UserID = CCheckInfo.CurrentUserID, // 替換為獲取當前用戶ID的方法
                ActivityID = ActivityID, // 使用 FrmProduct 中的 ActivityID
                BookingDate = DateTime.Now, // 使用當前日期時間作為預訂日期
                Price = Convert.ToDecimal(labelBox2.content), // 使用介面元件上的價格資訊
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
    }
}
