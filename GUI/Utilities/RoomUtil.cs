using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Utilities
{
    static class RoomUtil
    {
        public static int DefaultQuantity(string roomType)
        {
            switch (roomType)
            {
                case "SGL":
                    return 1;
                case "DBL":
                    return 2;
                case "TWN":
                    return 2;
                case "TRPL":
                    return 3;
                case "QUAD":
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
