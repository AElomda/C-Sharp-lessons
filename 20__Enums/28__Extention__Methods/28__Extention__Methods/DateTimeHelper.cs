using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28__Extention__Methods
{
    //Old styel Helper Class
    public static class DateTimeHelper
    {
        public static bool IsWeekEnd(DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }
        public static bool IsWeekDay(DateTime value)
        {
            return !IsWeekEnd(value);
        }
    }
}
