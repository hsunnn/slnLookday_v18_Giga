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
    public partial class FrmOrdersSystem : Form
    {
        public FrmOrdersSystem()
        {
            InitializeComponent();
        }
        private void resetDatagridview()
        {
            dataGridView1.Columns[0].HeaderText = "訂單編號";
            dataGridView1.Columns[1].HeaderText = "活動名稱";
            dataGridView1.Columns[2].HeaderText = "會員名稱";
            dataGridView1.Columns[3].HeaderText = "訂單日期";
            dataGridView1.Columns[4].HeaderText = "人數";
            dataGridView1.Columns[5].HeaderText = "價格";
            dataGridView1.Columns[6].HeaderText = "訂單狀態";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 80;

            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.White;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 10);
            }
        }

        private void queryAllOrder()
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var order = from activity in db.Activities
                        join booking in db.Bookings
                        on activity.ActivityID equals booking.ActivityID
                        join user in db.User
                        on booking.UserID equals user.UserID
                        join bstate in db.BookingStates
                        on booking.BookingStatesID equals bstate.BookingStatesID
                        select new
                        { //這裡決定要出現哪些欄位
                            booking.BookingID,
                            activity.Name,
                            user.Username,
                            booking.BookingDate,
                            booking.Member,
                            booking.Price,
                            bstate.States
                        };
            dataGridView1.DataSource = order.ToList();
        }//秀出所有訂單

        private void FrmOrdersSystem_Load(object sender, EventArgs e)
        {
            queryAllOrder();
            resetDatagridview();
        }


        private void btn_SearchbyDate_Click_1(object sender, EventArgs e)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);

            var orders = from r in db.Bookings
                         where r.BookingDate >= startDate && r.BookingDate <= endDate
                         select new
                         {
                             r.BookingID,
                             r.Activities.Name,
                             r.User.Username,
                             r.BookingDate,
                             r.Member,
                             r.Price,
                             r.BookingStates.States
                         };

            dataGridView1.DataSource = orders.ToList();
            //resetDatagridview();
        }//依日期查詢


        private void btn_SearchbyOrderID_Click(object sender, EventArgs e)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var order = from activity in db.Activities
                        join booking in db.Bookings
                        on activity.ActivityID equals booking.ActivityID
                        join user in db.User
                        on booking.UserID equals user.UserID
                        join bstate in db.BookingStates
                        on booking.BookingStatesID equals bstate.BookingStatesID
                        where booking.BookingID.ToString().Contains(txt_SearchbyOrderID.Text.ToString()) //&& booking.BookingStatesID == 3
                        select new
                        {//這裡決定出現哪些欄位
                            booking.BookingID,
                            activity.Name,
                            user.Username,
                            booking.BookingDate,
                            booking.Member,
                            booking.Price,
                            bstate.States
                        };
            dataGridView1.DataSource = order.ToList();
            //resetDatagridview();
        }//依訂單ID查詢

        private void btn_SearchAll_Click_1(object sender, EventArgs e)
        {
            queryAllOrder();
            //resetDatagridview();
        }

        private void Btn_SearchbyName_Click(object sender, EventArgs e)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var order = from activity in db.Activities
                        join booking in db.Bookings
                        on activity.ActivityID equals booking.ActivityID
                        join user in db.User
                        on booking.UserID equals user.UserID
                        join bstate in db.BookingStates
                        on booking.BookingStatesID equals bstate.BookingStatesID
                        where user.Username.Contains(txt_SearchbyName.Text.ToString()) //&& booking.BookingStatesID == 3
                        select new
                        {//這裡決定出現哪些欄位
                            booking.BookingID,
                            activity.Name,
                            user.Username,
                            booking.BookingDate,
                            booking.Member,
                            booking.Price,
                            bstate.States
                        };
            dataGridView1.DataSource = order.ToList();
            //resetDatagridview();
        }//依用戶名稱查詢

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;

            DataGridViewRow r = dataGridView1.SelectedRows[0];

            if (r.Cells.Count <= 0)
                return;

            DataGridViewCell c = r.Cells[0];
            int id = (int)c.Value;

            dblookdaysEntities db = new dblookdaysEntities();
            Bookings bookings = db.Bookings.FirstOrDefault(x => x.BookingID == id);

            if (bookings == null)
                return;
            DialogResult result = MessageBox.Show("將此筆訂單刪除", "Look Day", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                db.Bookings.Remove(bookings);
                db.SaveChanges();
                queryAllOrder();
            }
        }//刪除某筆訂單
    }
}
