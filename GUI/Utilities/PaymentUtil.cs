using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Utilities
{
    static class PaymentUtil
    {
        public static int CalcTotal(string roomId, DateTime checkinDate, DateTime checkoutDate, int bookingQuantity)
        {
            room chargeRoom = new RoomBLL().Get(roomId);
            int surcharge = CalcSurcharge(roomId, bookingQuantity);
            int total = (chargeRoom.rate + surcharge) * GeneralUtil.CountDays(checkinDate, checkoutDate);
            return total;
        }

        public static int CalcSurcharge(string roomId, int quantity)
        {
            room chargeRoom = new RoomBLL().Get(roomId);
            int res = 0;
            if (quantity > RoomUtil.DefaultQuantity(chargeRoom.type))
                res = chargeRoom.surcharge * (quantity - RoomUtil.DefaultQuantity(chargeRoom.type));
            return res;
        }
    }
}
