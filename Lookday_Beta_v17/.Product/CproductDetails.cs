using Lookday_Beta_v17;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookday_Beta.Product
{
    internal class CproductDetails
    {
        //將RoomBox的點擊的圖片去資料庫做對比 然後將得到的參數傳給FrmProduct的方法
        private dblookdaysEntities db = new dblookdaysEntities();

        public Activities GetActivityDetails(int ActivityID)
        {
            var activity = from r in db.Activities
                           where r.ActivityID == ActivityID
                           select r;
            return activity.FirstOrDefault();
        }

        public byte[] GetActivityPhoto(int ActivityID)
        {
            var photo = from a in db.ActivitiesAlbum
                        where a.ActivityID == ActivityID
                        select a.Photo;
            return photo.FirstOrDefault();
        }
    }
}
