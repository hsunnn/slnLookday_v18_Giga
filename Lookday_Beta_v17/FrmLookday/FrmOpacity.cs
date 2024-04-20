using Lookday_Beta_v17.Models;
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
    public partial class FrmOpacity : Form
    {
        private Timer fadeInTimer;
        private int opacityIncrement = 10;

        public FrmOpacity()
        {
            InitializeComponent();
            this.Opacity = 0; // 將表單的透明度設置為0，讓其初始時看不見
            this.fadeInTimer = new Timer();
            this.fadeInTimer.Interval = 50; // 設定計時器的間隔
            this.fadeInTimer.Tick += new EventHandler(fadeInTimer_Tick); // 設定計時器的事件處理方法
            this.fadeInTimer.Start(); // 開始計時器
        }

        private void fadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.5) // 如果透明度已經達到1（完全可見），則停止計時器
            {
                this.fadeInTimer.Stop();
            }
            else
            {
                this.Opacity += (double)opacityIncrement / 100; // 增加透明度，使其漸漸顯示
            }
        }

        private void FrmOpacity_Load(object sender, EventArgs e)
        {
        }
    }
}
