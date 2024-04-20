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

namespace Lookday_Beta_v17.Cart
{
    public delegate void DConfirm(Wishlistbox p);//委派刪除按鈕
    public delegate void DAdd(Wishlistbox p);

    public partial class Wishlistbox : UserControl
    {
        public event DConfirm deleteConfirm;
        public event DAdd addtoCar;

        public Wishlistbox()
        {
            InitializeComponent();
        }

        private Bookings _wishlist;//Lookday願望清單
        public Bookings wishlist
        {
            get { return _wishlist; }
            set
            {
                _wishlist = value;
                lblName.Text = _wishlist.Activities.Name;
                lblDesc.Text = "活動介紹: " + _wishlist.Activities.Description;
                lblPrice.Text = "價格：" + _wishlist.Activities.Price.ToString("c0");
                lblDate.Text = "活動日期：" + _wishlist.Activities.Date.ToString();
                lblCityName.Text = "地點: " + _wishlist.Activities.City.CityName;
                lblRemaining.Text = "剩餘可參加人數: " + _wishlist.Activities.Remaining.ToString();
                lblHotels.Text = "飯店： " + _wishlist.Activities.Hotels.Name;
                SetActivityImage(_wishlist.ActivityID);
            }
        }

        private void SetActivityImage(int activityID)
        {
            using (var dbLookDays = new dblookdaysEntities()) //todo: change
            {
                var activityAlbum = dbLookDays.ActivitiesAlbum.FirstOrDefault(a => a.ActivityID == activityID);
                if (activityAlbum != null && activityAlbum.Photo != null && activityAlbum.Photo.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(activityAlbum.Photo))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    // 如果沒有相應的圖片，可以設置一個默認的圖片，或者清除 PictureBox 中的圖片
                    pictureBox1.Image = null; // 清除 PictureBox 中的圖片
                    // 或者設置一個默認的圖片
                    //pictureBox1.Image = Properties.Resources.DefaultImage;
                }
            }



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (deleteConfirm != null)
            {
                deleteConfirm(this);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (addtoCar != null)
            {
                addtoCar(this);
            }
        }
    }
}
