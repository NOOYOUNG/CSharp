using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cat", "Tiger", "Rabbit", "Dragon", "Snake", "Horse" };
            PrintArray("Before sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);

            Array.Sort(name);
            PrintArray("After Sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);
        }

        private static void PrintArray(string s, string[] name)
        {
            Console.WriteLine(s);
            foreach (var i in name)
            {
                Console.WriteLine("{0} ", i);            
            }
            Console.WriteLine();
        }
    }
}
