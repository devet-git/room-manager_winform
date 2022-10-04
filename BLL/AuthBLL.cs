using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace BLL
{
    public static class AuthBLL
    {
        public static bool IsSignIn = false;
        public static int UserId;
        public static int UserPhone;
        public static string UserFullname;
        public static string UserRole;
        private static readonly HotelManagerDataContext DB = new HotelManagerDataContext();


        public static bool CheckSignIn(string phoneNum, string password)
        {
            user signInUser = DB.users.Where(user => user.phone == phoneNum && user.password == password).FirstOrDefault();
            if (signInUser != null)
            {
                IsSignIn = true;
                UserId = signInUser.id;
                UserFullname = signInUser.fullname;
                UserRole = signInUser.role;
                return true;
            }
            return false;
        }
        public static bool ChangePassword(string oldPassword, string newPassword)
        {
            user targetUser = DB.users.Where(u => u.id == UserId && u.password == oldPassword).FirstOrDefault();
            if (targetUser != null)
            {
                targetUser.password = newPassword;
                DB.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
