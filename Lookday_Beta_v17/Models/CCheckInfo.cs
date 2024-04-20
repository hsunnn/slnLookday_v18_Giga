using Lookday_Beta_v17;
using Register_and_login_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lookday_Beta.Models
{
    public class CCheckInfo
    {
        public static bool CheckUser(string UsernameTextbox)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var username = db.User.FirstOrDefault(p => p.Username == UsernameTextbox);
            if (username != null) return true;
            else return false;
            //var username = from r in db.User
            //               select r;
            //foreach(var r in username)
            //{
            //    if(user.Username == UsernameTextbox)
            //    {
            //        return true;
            //        break;
            //    }
            //}
            //return false;
        }
        public static bool CheckEmail(string EmailTextbox)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var Email = db.User.FirstOrDefault(p => p.Email == EmailTextbox);
            if (Email != null) return true;
            else return false;
            //var Email = from r in db.User
            //               select r;
            //foreach (var r in Email)
            //{
            //    if (user.Email == EmailTextbox)
            //    {
            //        return true;
            //        break;
            //    }
            //}
            //return false;
        }
        public static bool CheckPassword(string PasswordTextbox)
        {
            string HashPassword = CCryptography.HashPasswordWithSalt(PasswordTextbox);
            dblookdaysEntities db = new dblookdaysEntities();
            var Password = db.User.FirstOrDefault(p=>p.Password == HashPassword);
            if (Password != null) return true;
            else return false;
        }
        public static int CheckUserRole(string UsernameTextbox)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var UserRole = db.User.FirstOrDefault(p=>p.Username == UsernameTextbox);
            if (UserRole != null) return UserRole.RoleID;
            else return 0;
        }

        public static int LoginUserID(string UsernameTextbox)
        {
            dblookdaysEntities db = new dblookdaysEntities();
            var UserID = db.User.FirstOrDefault(p => p.Username == UsernameTextbox);
            if (UserID != null) return UserID.UserID;
            else return 0;
        }
        public static int CurrentUserID;
        public static bool StaffMode = false;
    }

}
