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

namespace Lookday_Beta.FrmClient
{
    public partial class OrderReviewBox : UserControl
    {
        private Bookings _booking;

        public Bookings booking
        {
            get { return _booking; }
            set
            {
                _booking = value;
                lblNameo.Text = _booking.Activities.Name;
                lblDateo.Text = "活動日期：" + _booking.Activities.Date.ToString();
                lblMemoo.Text = "活動介紹：" + _booking.Activities.Description;
                lblPriceo.Text = "價格：" + (_booking.Activities.Price * _booking.Member).Value.ToString("c0");
                lblMembero.Text = "人數：" + _booking.Member.ToString();
                lblBookDate.Text = "訂單成立日期：" + _booking.BookingDate.ToString(); //按下結帳按鈕取得日期傳到這裡
                SetActivityImage(_booking.ActivityID);
            }
        }
        private void SetActivityImage(int activityId)
        {
            using (var lookdaysEntities = new dblookdaysEntities())//change
            {
                var activityAlbum = lookdaysEntities.ActivitiesAlbum.FirstOrDefault(a => a.ActivityID == activityId);
                if (activityAlbum != null && activityAlbum.Photo != null && activityAlbum.Photo.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(activityAlbum.Photo))
                    {
                        pictureBoxo.Image = Image.FromStream(ms);
                        pictureBoxo.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    // 如果沒有相應的圖片，可以設置一個默認的圖片，或者清除 PictureBox 中的圖片
                    pictureBoxo.Image = null; // 清除 PictureBox 中的圖片
                    // 或者設置一個默認的圖片
                    //pictureBox1.Image = Properties.Resources.DefaultImage;
                }
            }
        }
        public OrderReviewBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dblookdaysEntities db = new dblookdaysEntities();
            //Reviews reviews = db.Reviews.FirstOrDefault(p => p.Activities.Name == lblNameo.Text && p.UserID == CCheckInfo.CurrentUserID);
            //if (reviews != null)



            FrmWritingReview.Aid = booking.ActivityID;
            FrmWritingReview.Aname = this.lblNameo.Text;
            EditReview();
        }
        private void EditReview()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            Reviews reviews = db.Reviews.FirstOrDefault(p => p.Activities.Name == lblNameo.Text && p.UserID == CCheckInfo.CurrentUserID);
            if (reviews == null)
            {
                NewReview();
                return;
            }

            FrmOpacity O = new FrmOpacity();
            FrmWritingReview f = new FrmWritingReview();
            f.reviews = reviews;
            O.Show();
            f.ShowDialog();

            if(f.isOk != DialogResult.OK) return;
            reviews.UserID = f.reviews.UserID;
            reviews.Comment = f.reviews.Comment;
            reviews.ActivityID = f.reviews.ActivityID;
            reviews.Rating = f.reviews.Rating;
            db.SaveChanges();
        }
        private void NewReview()
        {
            FrmWritingReview fr = new FrmWritingReview();
            fr.ShowDialog();
            if(fr.isOk != DialogResult.OK )
                return;
            Reviews x = fr.reviews;

            dblookdaysEntities db = new dblookdaysEntities();
            db.Reviews.Add(x);
            db.SaveChanges();
        }
    }
}
