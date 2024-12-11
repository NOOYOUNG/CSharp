using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("생일을 입력하세요(yyyy/mm/dd) : ");
            string birth=Console.ReadLine();
            string[] arr = birth.Split('/');

            int year = int.Parse(arr[0]);
            int month = int.Parse(arr[1]);
            int day = int.Parse(arr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int total = 0;

            total += DayOfYear(tYear, tMonth, tDay);

            int yearDays = IsLeapYear(year) ? 366 : 365;
            total += yearDays - DayOfYear(year, month, day);

            for (int y = year + 1; y < tYear; y++)
            {
                if(IsLeapYear(y))
                {
                    total += 366;
                }
                else
                {
                    total += 365;
                }
            }
            Console.WriteLine("total days from birthday : {0}", total);
        }

        static int[] days = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public  static int DayOfYear(int year, int month, int day)
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

    }

    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int year=2001; year<=2100; year++)
            {
                if(IsLeapYear(year))
                {
                    Console.Write("{0} ", year);
                }    
            }
            Console.WriteLine();
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

    }
    */

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int cnt = 0;

    //        for(int i=2; i<=100; i++)
    //        {
    //            if (IsPrime(i))
    //            {
    //                Console.Write("{0} ", i);
    //                cnt++;
    //            }
    //        }
    //        Console.WriteLine("\n2~100까지 소수는 모두 {0}개 있습니다.", cnt);
    //    }

    //    private static bool IsPrime(int x)
    //    {
    //        for(int i=2; i<x; i++)
    //        {
    //            if (x % i == 0) return false;
    //        }
    //        return true;
    //    }
    //}
}
