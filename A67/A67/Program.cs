using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A67
{
    class Date
    {
        public int year, month, day;

        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public int DayOfYear()
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Date xmas=new Date();
            xmas.year = 2024;
            xmas.month = 12;
            xmas.day = 25;

            Console.WriteLine("xmas: {0}/{1}/{2}는 {3}일째 되는 날입니다.", xmas.year, xmas.month, xmas.day, xmas.DayOfYear());

            if (Date.IsLeapYear(2024) == true)
            {
                Console.WriteLine("2024년은 윤년입니다.");
            }
            else
            {
                Console.WriteLine("2024년은 윤년이 아닙니다.");
            }
        }
    }
}
