using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public class UsersBLL
    {
        public List<user> GetAll()
        {
            HotelManagerDataContext db = new HotelManagerDataContext();
            return db.users.ToList();
        }
    }
}
