using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PaymentBLL
    {
        private static readonly HotelManagerDataContext DB = new HotelManagerDataContext();
        public static bool Insert(int amount, int bookingId)
        {
            try
            {
                payment pm = new payment()
                {
                    amount = amount,
                    booking_id = bookingId,
                    user_id = AuthBLL.UserId,
                    date = DateTime.Now.Date
                };
                DB.payments.InsertOnSubmit(pm);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
