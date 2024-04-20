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
    public delegate void DConfirm(Cartbox p);//委派刪除按鈕
    public delegate void DPlus(Cartbox p);//委派購物車訂單人數增加按鈕
    public delegate void DMinus(Cartbox p);//委派購物車訂單人數減少按鈕
    public partial class Cartbox : UserControl
    {
        public event DConfirm deleteConfirm;
        public event DPlus memberPlus;
        public event DMinus memberMinus;

        private Bookings _booking;//Lookday購物車
        public Bookings booking
        {
            get { return _booking; }
            set
            {
                _booking = value;
                lblName.Text = _booking.Activities.Name;
                lblDate.Text = "活動日期："+_booking.Activities.Date.ToString();
                lblMemo.Text = _booking.Activities.Description;
                lblPrice.Text = "價格："+ (_booking.Activities.Price*_booking.Member).Value.ToString("c0");
                lblMember.Text = "人數："+_booking.Member.ToString();
                SetActivityImage(_booking.ActivityID);
            }
        }
        //以下為C老師寫的從資料庫撈圖片方法
        private void SetActivityImage(int activityId)
        {
            using (var dbLookDays = new dblookdaysEntities()) //todo: change
            {
                var activityAlbum = dbLookDays.ActivitiesAlbum.FirstOrDefault(a => a.ActivityID == activityId);
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
       
        public Cartbox()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(deleteConfirm != null)
            {
                deleteConfirm(this);
            }
        }

        private void btn_Increase_Click(object sender, EventArgs e)
        {
            if(memberPlus != null)
            {
                memberPlus(this);
            }
        }

        private void btn_Decrease_Click(object sender, EventArgs e)
        {
            if(memberMinus != null)
            {
                memberMinus(this);
            }
        }
    }
}
