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
                return true; //true - если год високосный, иначе false
            }
            else
            {
                return false;
            }
        }
    }

}
