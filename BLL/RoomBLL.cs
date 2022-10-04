using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace BLL
{
    public class RoomBLL
    {
        private readonly HotelManagerDataContext DB = new HotelManagerDataContext();
        public static string SelectingRoomId;
        public static int SelectingRoomStatus;
        public static int BookingId;


        public room Get(string roomCode)
        {
            return DB.rooms.Where(r => r.code == roomCode).FirstOrDefault();
        }
        public List<room> GetAll()
        {
            return DB.rooms.ToList();
        }
    }
}
