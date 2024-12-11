using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace A70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 30, c= 20;
            Program x= new Program();
            Console.WriteLine("가장 큰 수는 {0}", x.Larger(x.Larger(a, b), c));

            //Console.WriteLine("가장 큰 수는 {0}", Larger(Larger(a, b), c)); <<- 실행하려면 함수 static 선언(정적메소드=객체 만들지 않고 사용 가능)
        }

        private int Larger(int a, int b)
        {
            return (a>=b) ? a : b;
        }
    }
}
