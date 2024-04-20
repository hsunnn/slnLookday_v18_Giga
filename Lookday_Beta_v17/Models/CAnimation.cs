using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookday_Beta_v17.Models
{
    public class CAnimation
    {

        private static Timer fadeInTimer;
        private static int opacityIncrement = 10;

        // 实现淡入效果的方法
        public static void FadeIn(Form currentform)
        {
            currentform.Opacity = 0;
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 25;
            fadeInTimer.Tick += (sender, e) => FadeInTimer_Tick(currentform);
            fadeInTimer.Start();
        }

        // 实现淡入效果的计时器事件处理方法
        private static void FadeInTimer_Tick(Form currentform)
        {
            if (currentform.Opacity >= 1)
            {
                fadeInTimer.Stop();
            }
            else
            {
                currentform.Opacity += (double)opacityIncrement / 100;
            }
        }
    }
}
