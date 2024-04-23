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
    public partial class FrmProductSystem : Form
    {
        private int id;
        private Activities _activities;
        public Activities activities
        {
            get
            {
                if (_activities == null)
                {
                    _activities = new Activities();
                }
                //_activities.ActivityID = Convert.ToInt32(txtPDActivityID.Text);
                _activities.Name = txtName.Text;
                _activities.Price = Convert.ToDecimal(txtPDPrice.Text);
                _activities.Remaining = Convert.ToInt32(txtRemaining.Text);
                _activities.HotelID = Convert.ToInt32(txtHotelID.Text);
                _activities.CityID = Convert.ToInt32(txtCityID.Text);
                _activities.Date = dateTimePicker1.Value;
                _activities.Description = txtDescription.Text;
                return _activities;
            }
            set
            {
                _activities = value;
                //txtPDActivityID.Text = _activities.ActivityID.ToString();
                txtName.Text = _activities.Name;
                txtPDPrice.Text = _activities.Price.ToString();
                txtRemaining.Text = _activities.Remaining.ToString();
                txtHotelID.Text = _activities.HotelID.ToString();
                txtCityID.Text = _activities.CityID.ToString();
                txtDescription.Text = _activities.Description;
                dateTimePicker1.Value = Convert.ToDateTime(_activities.Date);
            }
        }
        public FrmProductSystem()
        {
            InitializeComponent();
        }

        private dblookdaysEntities db;

        private void FrmProductSystem_Load(object sender, EventArgs e)
        {
            querryall();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            if (row.Cells.Count <= 0)
                return;

            DataGridViewCell cell = row.Cells[0];
            int id = (int)cell.Value;

            using (dblookdaysEntities db = new dblookdaysEntities())
            {
                var bookings = db.Bookings.Where(b => b.ActivityID == id).ToList();

                bool allBookingsAreConfirmed = bookings.Any(b => b.BookingStatesID == 3);

                if (allBookingsAreConfirmed)
                {
                    MessageBox.Show("此行程已經有人購買付款，不得下架行程。");
                    return;
                }

                db.Bookings.RemoveRange(bookings);

                ActivitiesAlbum album = db.ActivitiesAlbum.FirstOrDefault(a => a.ActivityID == id);
                if (album != null)
                {
                    db.ActivitiesAlbum.Remove(album);
                }

                Activities activity = db.Activities.FirstOrDefault(a => a.ActivityID == id);
                if (activity != null)
                {
                    db.Activities.Remove(activity);
                }
                MessageBox.Show("此行程已下架。");
                db.SaveChanges();
            }

            querryall();
        }

        private void querryall()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var activities = from p in db.Activities select p;
            dataGridView1.DataSource = activities.ToList();
        }

        int cityID;
        decimal price;
        int hotelID;
        int remaining;

        public bool CheckTextboxValue()
        {
            if (//string.IsNullOrWhiteSpace(txtPDActivityID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPDPrice.Text) ||
                string.IsNullOrWhiteSpace(txtCityID.Text) ||
                string.IsNullOrWhiteSpace(txtRemaining.Text) ||
                string.IsNullOrWhiteSpace(txtHotelID.Text))
            {
                MessageBox.Show("所有文本框都必須填寫");
                return false;
            }

            else if (!int.TryParse(txtCityID.Text, out cityID) ||
                !int.TryParse(txtRemaining.Text, out remaining))
            {
                MessageBox.Show("CityID 和 Remaining 必須為數字");
                return false;
            }

            else if (!decimal.TryParse(txtPDPrice.Text, out price))
            {
                MessageBox.Show("Price 必須為數字");
                return false;
            }

            else if (!int.TryParse(txtHotelID.Text, out hotelID))
            {
                MessageBox.Show("請輸入有效的整數值作為 HotelID。");
                return false;
            }
            else return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to save changes?";
            string title = "Data Edit";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No) 
                return;
            if (!CheckTextboxValue()) 
                return;
            dblookdaysEntities db = new dblookdaysEntities();
            Activities activities = db.Activities.FirstOrDefault(p => p.ActivityID == id);
            if (activities == null) 
                return;
            activities.Name = txtName.Text;
            activities.Price = price;
            activities.Remaining = remaining;
            activities.HotelID = hotelID;
            activities.CityID = cityID;
            activities.Date = dateTimePicker1.Value;
            activities.Description = txtDescription.Text;
            db.SaveChanges();
            MessageBox.Show("Save changes");
            querryall();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtPDPrice.Text = "";
            txtCityID.Text = "";
            txtRemaining.Text = "";
            txtHotelID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (!CheckTextboxValue()) return;
                string message = "Are you sure want to add new data?";
                string title = "Data Add";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No) return;
                using (dblookdaysEntities db = new dblookdaysEntities())
                {
                    Activities NewAc = new Activities
                    {
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Price = price,
                        Date = dateTimePicker1.Value,
                        CityID = cityID,
                        Remaining = remaining,
                        HotelID = hotelID
                    };
                    db.Activities.Add(NewAc);
                    db.SaveChanges();

                    ActivitiesAlbum album = new ActivitiesAlbum
                    {
                        ActivityID = NewAc.ActivityID,
                        Photo = ConvertImageToByteArray(pictureBox1.Image)
                    };

                    db.ActivitiesAlbum.Add(album);
                    db.SaveChanges();
                }
                MessageBox.Show("Save changes");
                querryall();
                ClearTextBoxes();        
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                return ms.ToArray();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            displayInfo(id);
        }
        private void displayInfo(int id)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            Activities Activities = db.Activities.FirstOrDefault(p => p.ActivityID == id);
            if (Activities == null) return;
            activities = Activities;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            op.Title = "請選擇行程封面圖";

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image selectedImage = Image.FromFile(op.FileName);
                    pictureBox1.Image = selectedImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}