using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Utilities
{
    public class DatePersian
    {
        public static DateTime ToMiladi(int y, int m, int d)
        {
            PersianCalendar pc = new PersianCalendar();

            DateTime dt = new DateTime(y, m, d, pc);
            return dt;

        }
        public static string ToJalali(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();

            DateTime dt = new DateTime(date.Year, date.Month, date.Day);

            string PersianDate = string.Format("{0}-{1}-{2}", pc.GetYear(dt), pc.GetMonth(dt), pc.GetDayOfMonth(dt));

            return PersianDate;
        }
        public static string ToJalaliShow(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();

            DateTime dt = new DateTime(date.Year, date.Month, date.Day);

            string PersianDate = string.Format("{0}/{1}/{2}", pc.GetYear(dt), pc.GetMonth(dt), pc.GetDayOfMonth(dt));

            return PersianDate;
        }

    }
}
