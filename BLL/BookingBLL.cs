using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BookingBLL
    {
        private readonly HotelManagerDataContext DB = new HotelManagerDataContext();

        public bool Insert(
           RichTextBox customerInfo,
           DateTimePicker checkinDate,
           DateTimePicker checkoutDate,
           TextBox quantity
       )
        {
            //TODO: count days between a range of date
            DateTime inDate = Convert.ToDateTime(checkinDate.Text);
            DateTime outDate = Convert.ToDateTime(checkoutDate.Text);
            int stayed_day = outDate.Subtract(inDate).Days;

            //TODO: insert to database
            try
            {
                booking roomBooking = new booking();
                roomBooking.customer = customerInfo.Text;
                roomBooking.checkin = checkinDate.Value.Date;
                roomBooking.checkout = checkoutDate.Value.Date;
                roomBooking.stayed_day = stayed_day;
                roomBooking.quantity = int.Parse(quantity.Text);
                roomBooking.room_id = RoomBLL.SelectingRoomId;
                roomBooking.user_id = AuthBLL.UserId;

                DB.bookings.InsertOnSubmit(roomBooking);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(
            int bookingId,
            RichTextBox customerInfo,
            DateTimePicker checkinDate,
            DateTimePicker checkoutDate,
            TextBox quantity
        )
        {
            DateTime inDate = Convert.ToDateTime(checkinDate.Text);
            DateTime outDate = Convert.ToDateTime(checkoutDate.Text);
            int stayed_day = outDate.Subtract(inDate).Days;

            try
            {
                booking bookingUpdate = DB.bookings.Where(bk => bk.id == bookingId).FirstOrDefault();

                bookingUpdate.customer = customerInfo.Text;
                bookingUpdate.checkin = checkinDate.Value.Date;
                bookingUpdate.checkout = checkoutDate.Value.Date;
                bookingUpdate.quantity = int.Parse(quantity.Text);
                bookingUpdate.stayed_day = stayed_day;
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Checkout(int bookingId, DateTime checkoutDate)
        {
            try
            {
                booking booking = DB.bookings.Where(bk => bk.id == bookingId).FirstOrDefault();
                int stayed_day = (checkoutDate).Subtract(booking.checkin).Days;
                booking.checkout = checkoutDate;
                booking.stayed_day = stayed_day;
                booking.status = "done";
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public booking Get(string roomId, DateTimePicker DPickerSelect)
        {
            booking bookingInfo = DB.bookings.Where(bk => bk.room_id == roomId && DPickerSelect.Value.Date >= bk.checkin && DPickerSelect.Value.Date <= bk.checkout && bk.status == null).FirstOrDefault();
            return bookingInfo;
        }

        public bool Cancel(int bookingId)
        {
            try
            {
            booking bookingInfo = DB.bookings.Where(bk => bk.id == bookingId).FirstOrDefault();
            bookingInfo.status = "canceled";
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
