using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime xmas = new DateTime(2024, 12, 25);
            DateTime newYearsDay = new DateTime(2025, 1, 1);

            TimeSpan span=newYearsDay- xmas;

            Console.WriteLine("크리스마스와 새해 첫날의 간격");

            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days", span.TotalDays);
            Console.WriteLine("{0,14} hours", span.TotalHours);
            Console.WriteLine("{0,14} minutes", span.TotalMinutes);
            Console.WriteLine("{0,14} seconds", span.TotalSeconds);
            Console.WriteLine("{0,14} milliseconds", span.TotalMilliseconds);
            Console.WriteLine("{0,14} ticks", span.Ticks);

        }
    }
}
