using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.Utility
{
    public static class PersianExtensions
    {
        public static string GetDatePersianNumber(this string data)
        {
            if (string.IsNullOrEmpty(data)) return string.Empty;
            data = data.Insert(data.Length - 2, "/");
            data = data.Insert(data.Length - 5, "/");
            for (var i = 48; i < 58; i++)
            {
                data = data.Replace(Convert.ToChar(i), Convert.ToChar(1728 + i));
            }
            return data;
        }

        public static string GetPersianNumber(this string data)
        {
            if (string.IsNullOrEmpty(data)) return string.Empty;
            for (var i = 48; i < 58; i++)
            {
                data = data.Replace(Convert.ToChar(i), Convert.ToChar(1728 + i));
            }
            return data;
        }

        public static string GetEnglishNumber(this string data)
        {
            if (string.IsNullOrEmpty(data)) return string.Empty;
            for (var i = 1777; i < 1786; i++)
            {
                data = data.Replace(Convert.ToChar(i), Convert.ToChar(i - 1728));
            }
            return data;
        }
        public static string GetPersianNumber(this long data)
        {
            return data.ToString(CultureInfo.InvariantCulture).GetPersianNumber();
        }
        public static string GetPersianNumber(this double data)
        {
            return string.Format(CultureInfo.InvariantCulture,"{0:0.00}", data).GetPersianNumber();
        }
        public static string GetPersianNumber(this int data)
        {
            return data.ToString(CultureInfo.InvariantCulture).GetPersianNumber();
        }

        public static string GetPersianNumber(this decimal data)
        {
            return data.ToString(CultureInfo.InvariantCulture).GetPersianNumber();
        }
        public static string GetPersianNumber(this byte data)
        {
            return data.ToString(CultureInfo.InvariantCulture).GetPersianNumber();
        }
        public static string GetPersianMonth(this string data)
        {
            var temp = string.Empty;
            switch (data)
            {
                case ("01"):
                    temp = "فروردین";
                    break;
                case ("02"):
                    temp = "اردیبهشت";
                    break;
                case ("03"):
                    temp = "خرداد";
                    break;
                case ("04"):
                    temp = "مرداد";
                    break;
                case ("05"):
                    temp = "تیر";
                    break;
                case ("06"):
                    temp = "شهریور";
                    break;
                case ("07"):
                    temp = "مهر";
                    break;
                case ("08"):
                    temp = "آبان";
                    break;
                case ("09"):
                    temp = "آذر";
                    break;
                case ("10"):
                    temp = "دی";
                    break;
                case ("11"):
                    temp = "بهمن";
                    break;
                case ("12"):
                    temp = "اسفند";
                    break;
                default:
                    return string.Empty;

            }
            return temp;
        }

        public static string GetPersianMoney(this decimal data)
        {
            var temp = data.GetPersianNumber();
            var arData = temp.Split('.');
            temp = arData[0];
            for (var i = temp.Length-3; i > 0; i -= 3)
                temp = temp.Insert(i, ",");
            return temp;
        }
    }
}

