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

namespace Lookday_Beta
{
    public partial class OrderHisbox : UserControl
    {
        private Bookings _booking;//Lookday購物車
        //private DateTime _bookDate;
        //public DateTime BookDate
        //{
        //    get { return _bookDate; }
        //    set
        //    {
        //        _bookDate = value;
        //        lblBookDate.Text = "訂單成立日期："+ _bookDate.ToString("yyyy-MM-dd HH:mm:ss"); // 使用所需的日期格式
        //    }
        //}

        public Bookings booking
        {
            get { return _booking; }
            set
            {
                _booking = value;
                lblNameo.Text = _booking.Activities.Name;
                lblDateo.Text = _booking.Activities.Date.ToString();
                lblMemoo.Text = _booking.Activities.Description;
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
        public OrderHisbox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
