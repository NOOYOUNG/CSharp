using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Hello");
            Console.WriteLine(" World!");
            Console.WriteLine("이름을 입력하세요");

            string name=Console.ReadLine();
            Console.Write(name);
            Console.WriteLine("님!");

            Console.WriteLine("나이를 입력하세요");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("키를 입력하세요");
            float height=float.Parse(Console.ReadLine());

            Console.Write("나이는 ");
            Console.WriteLine(age+"세");

            Console.Write("키는 ");
            Console.WriteLine(height+"cm");

            string a = "hello";
            string b = "h";
            b = b + "ello";
            Console.WriteLine(a == b);
            Console.WriteLine("b="+b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c="+ c);
          

            int i;
            double x;

            i = 5;
            x = 3.141592;
            Console.WriteLine("x=" + x+" "+"i="+i);

            x = i;
            i = (int)x;
            Console.WriteLine("x=" + x + " " + "i=" + i);
            

            bool b = true;
            char c = 'A';
            decimal d = 1.234m;
            double e = 1.23456789;
            float f = 1.23456789f;
            int i = 1234;
            string s = "Hello";

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);
            

            Console.WriteLine("10 이하의 소수: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            string primes;
            primes = String.Format("10 이하의 소수: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
            

            int v1 = 100;
            double v2 = 1.234;
            Console.WriteLine(v1.ToString() + v2.ToString());
            Console.WriteLine("v1=" + v1 + " v2=" + v2);
            Console.WriteLine("v1={0}, v2={1}", v1, v2);
            Console.WriteLine($"v1={v1} v2={v2}"); //앞에 $ 쓰면 { } 안에 변수명 직접 쓸 수 있다
            

            decimal value = 123456.789m;
            Console.WriteLine("잔액은 {0:C2}원 입니다", value); // 통화형식, 소수점 아래 두자리 반올림
            Console.WriteLine("잔액은 {0,20:C2}원 입니다", value); // 통화형식, 전체 20자리 중 사용하지 않는 부분은 빈칸, 소수점 아래 두자리 반올림
            

            //암시적형변환
            int num = 21439808;
            long bNum = num;
            Console.WriteLine(bNum);

            //명시적형변환
            double x = 1234.5;
            int a;
            a=(int)x;
            Console.WriteLine(a);
            

            string input;
            int val;
            Console.Write("1. int로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            bool result=Int32.TryParse(input, out val);

            if (!result) {
                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n", input);
            }
            else
            {
                Console.WriteLine("int는 '{0}'으로 변환되었습니다.\n", val);
            }

            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input= Console.ReadLine();
            try
            {
                //double m = Double.Parse(input);
                double m=Convert.ToDouble(input);
                Console.WriteLine("double '{0}'으로 변환되었습니다.\n", m);
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
            

            short val = short.MaxValue;
            // 2진수
            int baseNum = 2;
            string s=Convert.ToString(val, baseNum); // val 값을 2진수로 변환한 문자열
            int i=Convert.ToInt32(s, baseNum); // 변환된 2진수 문자열 s를 10진수로 다시 변환
            Console.WriteLine("i={0} {1,2}진수={2,16}", i, baseNum, s) ;
            // {1,2}는 baseNum을 2칸의 공간에 출력
            // {2,16}은 s를 16칸의 공간에 맞춰 출력

            baseNum = 8;
            s= Convert.ToString(val, baseNum);
            i=Convert.ToInt32(s, baseNum);
            Console.WriteLine("i={0} {1,2}진수={2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(val, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i={0} {1,2}진수={2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(val, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i={0} {1,2}진수={2,16}", i, baseNum, s);
            */

        }
    }
}
