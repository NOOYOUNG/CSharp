using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //단항연산자
            int a = 5;
            ++a;
            Console.WriteLine(a);

            //이항연산자
            int b = 3;
            int c = 0;
            c = a - b;
            Console.WriteLine(c);

            c = a + b;
            Console.WriteLine(c);

            //삼항연산자
            int d = (5 > 3) ? 2 : 0; // 조건이 참이면 2, 거짓이면 0
            Console.WriteLine(d);

            //대입연산자
            int a1 = 5;
            int b1 = 3;
            Console.WriteLine("대입전 "+b1);
            b1 = a1;
            Console.WriteLine("대입후 "+b1);
        }
    }
}
