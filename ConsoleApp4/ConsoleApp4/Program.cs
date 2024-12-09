using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i; // i의 값을 박싱하여 o로 복사
            i = i + 10;
            int j = (int)o; // o의 값을 언박싱하여 j로 복사

            Console.WriteLine("The value-type value i={0}", i);
            Console.WriteLine("The object-type value o={0}", o);
            Console.WriteLine("The value-type value j={0}", j);

            object p = o;
            o = 100;
            Console.WriteLine("The object-type value o={0}", o);
            Console.WriteLine("The object-type value p={0}", p);
        }
    }
}
