using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Utilities
{
    static class GeneralUtil
    {
        public static int CountDays(string fromDateString, string toDateString)
        {
            DateTime inDate = Convert.ToDateTime(fromDateString);
            DateTime outDate = Convert.ToDateTime(toDateString);
            int res = outDate.Subtract(inDate).Days;
            return res;
        }
        public static int CountDays(DateTime dateFrom, DateTime dateTo)
        {
            int res = dateTo.Subtract(dateFrom).Days;
            return res;
        }
        public static string DevisionUnit(long number, string delimiter, string currency = " VNĐ")
        {
            if (number == 0)
                return "0";
            string res = "";
            while (number >= 1000)
            {
                if (number % 1000 == 0)
                    res += delimiter + "000";
                else
                    res = delimiter + (number % 1000).ToString() + res;
                number /= 1000;
            }
            res = number.ToString() + res + currency;
            return res;
        }
    }
}
