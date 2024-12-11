using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A74
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Power(x, y)를 계산합니다.");
            Console.Write(" x를 입력하세요: ");
            double x=double.Parse(Console.ReadLine());

            Console.Write(" y를 입력하세요: ");
            double y=double.Parse(Console.ReadLine());

            Console.WriteLine(" {0}^{1} = {2}", x, y, Power(x, y));
        }

        private static double Power(double x, double y)
        {
            if (y == 0)
            {
                return 1;
            }
            else
            {
                return x * Power(x, y - 1);
            }
        }
    }

    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            for(double r=1; r<=10; r++)
            {
                Console.WriteLine("Area of circle with radius {0,2} = {1,7:F2}", r, AreaOfCircle(r));
            }
        }

        private static double  AreaOfCircle(double r)
        {
            return Math.PI * r * r;
        }
    }
    */

    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=20; i++)
            {
                Console.WriteLine("2^{0,2}={1,7}", i, Power(2, i));
            }
        }

        private static int Power(int v, int i)
        {
            int p = 1;
            for(int j=1; j<=i; j++)
            {
                p *= v;
            }
            return p;
        }
    }
    */

    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  1~100까지의 합: {0,8}", Add(1, 100));
            Console.WriteLine("101~200까지의 합: {0,8}", Add(101, 200));
        }

        private static int Add(int x, int y)
        {
            int sum = 0;
            for(int i=x; i<=y; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
    */

    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1; i<=10; i++)
            {
                sum += Factorial(i);
                Console.WriteLine("{0,2}! : {1,10:N0}", i, Factorial(i)); // N0: 소수점 없이 3자리마다 콤마 표시
            }
            Console.WriteLine("1! ~ 10! 의 합 = {0,8:N0}", sum);
        }

        private static int Factorial(int n)
        {
            int fact = 1;
            for(int i=1; i<=n; i++)
            {
                fact *= i;
            }
            return fact;
        }

    }
    */

    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawPyramind(3);
            DrawPyramind(5);
            DrawPyramind(7);
        }

        static void DrawPyramind(int n)
        {
            for(int i=1; i<=n; i++)
            {
                for(int j=i; j<n; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    */
}
