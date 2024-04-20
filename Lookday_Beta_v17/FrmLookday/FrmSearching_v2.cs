using Insert;
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
    public partial class FrmSearching_v2 : Form
    {
        // 定義一個靜態列表來跟踪所有已打開的 FrmSearching_v2 表單
        private static List<FrmSearching_v2> openForms = new List<FrmSearching_v2>();

        public FrmSearching_v2(string value)
        {
            InitializeComponent();
            InitializeButtonColors();
            txtKeyword.Text = value;

            // 在構造函式中將當前表單的引用添加到靜態列表中
            openForms.Add(this);
        }

        private void InitializeButtonColors()
        {
            // 初始化按鈕顏色
            btnFirst.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            btnFirst.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            btnPrevious.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            btnNext.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLast.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            btnLast.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            (new FrmOpacity_Big()).Show();
            (new FrmProduct()).ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Activities> filteredRooms;
        private int currentRoomIndex = 0;
        public void DisplaySearchResultsInFlowLayoutPanel(List<Activities> searchResults)
        {
            // 清除 FlowLayoutPanel 中的所有控制項
            flowLayoutPanel1.Controls.Clear();

            // 將每個搜尋結果添加到 FlowLayoutPanel 中
            foreach (var activity in searchResults)
            {
                // 創建一個新的控制項來顯示活動資訊，這裡假設您有一個自訂的 User Control 來顯示活動資訊
                RoomBox activityControl = new RoomBox(activity);

                // 將控制項添加到 FlowLayoutPanel 中
                flowLayoutPanel1.Controls.Add(activityControl);
            }
        }
        public void button3_Click(object sender, EventArgs e)//搜尋
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var activitiesQuery = from a in db.Activities
                                  where a.Name.ToUpper().Contains(txtKeyword.Text.ToUpper()) //不區分大小寫
                                  select a;

            filteredRooms = activitiesQuery.ToList(); //用於存儲從資料庫中檢索到的活動清單。
                                                      // Show the first three rooms
            ShowFirstThreeRooms();


        }
        private void ShowLastThreeRooms() //顯示最後三筆資料的方法
        {
            // 計算要顯示的起始索引
            int startIndex = Math.Max(0, filteredRooms.Count - 3);

            flowLayoutPanel1.Controls.Clear(); // 清空流式布局面板中的控件

            // 顯示最後四個資料
            for (int i = startIndex; i < filteredRooms.Count; i++)
            {
                RoomBox rb = new RoomBox();
                rb.room = filteredRooms[i];
                flowLayoutPanel1.Controls.Add(rb);
                flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            }

            // 更新當前索引
            currentRoomIndex = startIndex;
        }
        private void ShowFirstThreeRooms() //顯示最前面三筆資料的方法
        {

            // 若數量少於三個，則顯示全部
            int roomsToShow = Math.Min(filteredRooms.Count, 3);

            flowLayoutPanel1.Controls.Clear();

            // 顯示前三個
            for (int i = 0; i < roomsToShow; i++)
            {

                RoomBox rb = new RoomBox();
                rb.room = filteredRooms[i];
                flowLayoutPanel1.Controls.Add(rb);
                flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
                rb.Tag = i + 1;// 設置了每個 RoomBox 控制項的 Tag 屬性為房間的 ID
                this.flowLayoutPanel1.Controls.Add(rb);
            }
        }
        private void txtKeyword_KeyUp(object sender, KeyEventArgs e)//搜尋
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtKeyword.Text))
                {
                    dblookdaysEntities db = new dblookdaysEntities();
                    var activitiesQuery = from a in db.Activities
                                          where a.Name.ToUpper().Contains(txtKeyword.Text.ToUpper()) //不區分大小寫
                                          select a;

                    filteredRooms = activitiesQuery.ToList(); //用於存儲從資料庫中檢索到的活動清單。
                                                              // Show the first three rooms
                    ShowFirstThreeRooms();
                }
                else
                {
                    MessageBox.Show("請輸入搜尋欄位");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (filteredRooms != null && filteredRooms.Count > 0)
            {
                // 取得下一組資料
                List<Activities> nextFourRooms = filteredRooms.Skip(currentRoomIndex + 3).Take(3).ToList();

                if (nextFourRooms.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();

                    foreach (var r in nextFourRooms)
                    {
                        RoomBox rb = new RoomBox();
                        rb.room = r;
                        flowLayoutPanel1.Controls.Add(rb);
                    }

                    // 設置 FlowDirection
                    flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;

                    // 更新當前索引
                    currentRoomIndex = filteredRooms.IndexOf(nextFourRooms.First());
                }
                else
                {
                    MessageBox.Show("已經到底了。");
                }
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var rooms = from r in db.Activities
                        where r.Name.ToUpper().Contains(txtKeyword.Text.ToUpper())
                        select r;

            filteredRooms = rooms.ToList();

            if (filteredRooms.Count > 0)
            {
                ShowLastThreeRooms();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // 計算要顯示的起始索引
            int startIndex = Math.Max(0, currentRoomIndex - 3);

            List<Activities> previousThreeRooms = filteredRooms.Skip(startIndex).Take(3).ToList();

            if (previousThreeRooms.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();

                foreach (var r in previousThreeRooms)
                {
                    RoomBox rb = new RoomBox();
                    rb.room = r;
                    flowLayoutPanel1.Controls.Add(rb);
                    flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; //從左到右的方向進行排列。
                }
                // 更新當前索引
                currentRoomIndex = startIndex;
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            // 計算要顯示的起始索引
            int startIndex = 0;

            List<Activities> firstThreeRooms = filteredRooms.Take(3).ToList();

            if (firstThreeRooms.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();

                foreach (var r in firstThreeRooms)
                {
                    RoomBox rb = new RoomBox();
                    rb.room = r;
                    flowLayoutPanel1.Controls.Add(rb);
                    flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; // 從左到右的方向進行排列。
                }
                // 更新當前索引
                currentRoomIndex = startIndex;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

            // 在任何需要關閉所有 FrmSearching_v2 表單的地方
            foreach (var form in FrmSearching_v2.openForms.ToList())
            {
                form.Close();
            }
        }
    }
}
