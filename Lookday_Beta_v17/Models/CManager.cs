using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookday_Beta_v17.Models
{
    public class CManager
    {
        public static void CloseFormsAndActivateMain(Form currentForm)
        {
            // 關閉透明層
            Form transparentForm = Application.OpenForms["FrmOpacity"];
            transparentForm?.Close();

            // 關閉本 Form
            currentForm.Close();

            // 強制主視窗顯示在最上層
            Form mainForm = Application.OpenForms["FrmMain"];
            mainForm?.Activate();
        }

        public static int LoginCheck = 0; //登錄狀態


    }
}
