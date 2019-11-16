using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYears
{
    static class DateFunctions
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                {
                    return false; //true - если год високосный, иначе false
                }
                return true;
            }
            return false;
        }
    }

}
