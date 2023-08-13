using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28__Extention__Methods
{
    public static class DateTimeExtentions
    {
        public static bool IsWeekEnd(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }
        public static bool IsWeekDay(this DateTime value)
        {
            return !IsWeekEnd(value);
        }
    }
}
