using Lookday_Beta;
using Lookday_Beta.Product;
using Lookday_Beta.Models;
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
using System.Xml;
using Lookday_Beta_v17;

namespace Insert
{
    public partial class RoomBox : UserControl
    {
        private Activities _room;
        public Activities room
        {
            get { return _room; }
            set
            {
                _room = value;
                lblName.Text = _room.Name;
                lblPrice.Text = _room.Price.ToString("c0"); // 假設 Price 是要顯示的價格屬性
                var firstAlbum = _room.ActivitiesAlbum.FirstOrDefault(); 
                // 從 _room 物件的 ActivitiesAlbum 集合中獲取第一個物件
                if (firstAlbum != null && firstAlbum.Photo != null && firstAlbum.Photo.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(firstAlbum.Photo))
                    //將 firstAlbum 物件的 Photo 屬性資料作為參數傳遞給 MemoryStream 的建構函式。
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // 如果沒有圖片可供顯示，可以設置一個預設圖片或清空 pictureBox1.Image
                    pictureBox1.Image = null;
                }
            }
        }
        public RoomBox(Activities activity)
        {
            // 在這裡初始化 RoomBox 控制項，並使用 activity 中的資料填充控制項的內容
            // 例如：
            InitializeComponent();
            // 假設您的 RoomBox 控制項有一個名為 NameLabel 的 Label 控制項，用於顯示活動名稱
            lblName.Text = activity.Name;
        }

        public RoomBox()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.ActivityID = _room.ActivityID;
            FrmOpacity_Big _Big = new FrmOpacity_Big();
            _Big.Show();
            frmProduct.ShowDialog();
        }
    }
}
