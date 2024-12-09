using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int year=int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("{0}는 윤년", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년", year);
            }

            if (DateTime.IsLeapYear(year)) // 윤년 판별 메서드
            {
                Console.WriteLine("{0}는 윤년", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년", year);
            }
            

            Console.Write("점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());
            string grade = null;

            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine("학점은 {0}", grade);

            switch (score / 10)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            Console.WriteLine("학점은 {0}", grade);
            

            Console.Write("키를 입력하세요(cm): ");
            double height=double.Parse(Console.ReadLine());
            height /= 100;

            Console.Write("체중을 입력하세요(kg): ");
            double weight=double.Parse(Console.ReadLine());
            double bmi=weight/(height*height);

            string comment = null;
            if (bmi < 20)
                comment = "저체중";
            else if (bmi < 25)
                comment = "정상체중";
            else if (bmi < 30)
                comment = "경도비만";
            else if (bmi < 40)
                comment = "비만";
            else
                comment = "고도비만";

            Console.WriteLine("BMI = {0:F1}, {1}입니다", bmi, comment); // Fixed-point, 소수점 첫째 자리까지 출력
            

            int sum = 0;
            for(int i=1; i<=100; i++)
            {
                sum += i;
            }
            Console.WriteLine("1부터 100까지의 합: {0}", sum);

            int oddS = 0;
            for(int i=1; i<=100; i += 2)
            {
                oddS += i;
            }
            Console.WriteLine("1부터 100까지의 홀수의 합: {0}", oddS);

            int evenS = 0;
            for (int i = 0; i <= 100; i += 2)
            {
                evenS += i;
            }
            Console.WriteLine("1부터 100까지의 짝수의 합: {0}", evenS);
            

            Console.WriteLine("{0,5} {1,8} {2,3} {3,4}", "10진수", "2진수", "8진수", "16진수");
            //{0,5}: "10진수"가 5자리 공간을 차지하며 출력됩니다.
            //{1,8}: "2진수"는 8자리 공간을 차지합니다.
            //{2,3}: "8진수"는 3자리 공간을 차지합니다.
            //{3,4}: "16진수"는 4자리 공간을 차지합니다.

            for (int i=1; i<=128; i++)
            {
                Console.WriteLine("{0,7} {1,10} {2,5} {3,6}", i,
                    Convert.ToString(i, 2).PadLeft(8, '0'),
                    Convert.ToString(i,8),
                    Convert.ToString(i,16));
            }
            //{0,7}: i는 7자리로 정렬되므로, i가 1자리일 경우 앞에 6개의 공백을 추가하여 총 7자리를 채웁니다.
            //{1,10}: 2진수는 10자리로 정렬됩니다. 여기서는 2진수를 PadLeft(8, '0')를 사용하여 8자리로 맞추고 있습니다.
            //{2,5}: 8진수는 5자리로 정렬됩니다.
            //{3,6}: 16진수는 6자리로 정렬됩니다.
            

            Console.Write("구구단의 단수를 입력하세요: ");
            int num=int.Parse(Console.ReadLine());
            for(int i=1; i<=9; i++)
            {
                Console.WriteLine("{0}x{1}={2}", num, i, num*i);
            }
            

            double max=double.MinValue;
            double min=double.MaxValue;
            double sum = 0;

            for(int i=0; i<5; i++)
            {
                Console.Write("키를 입력하세요(cm): ");
                double h=double.Parse(Console.ReadLine());
                if (h > max) max = h;
                if (h < min) min = h;
                sum += h;
            }

            Console.WriteLine("평균:{0}cm, 최대:{1}cm, 최소:{2}cm", sum/5, max, min);
            

            Console.WriteLine("x의 y승을 계산합니다.");
            Console.Write("x를 입력하세요: ");
            int x=int.Parse(Console.ReadLine());
            Console.Write("y를 입력하세요: ");
            int y=int.Parse(Console.ReadLine());

            Console.WriteLine("{0}의 {1}승은 {2}입니다", x, y, Math.Pow(x,y));
            

            Console.Write("정수 n을 입력하세요: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("n!을 계산합니다.");

            int fact = 1;
            for (int i = 1; i <= n; i++) {
                fact *= i;
            }
            Console.WriteLine("{0}!={1}", n, fact);
            

            Console.WriteLine("숫자를 입력하세요: ");
            int num=int.Parse(Console.ReadLine());
            int i;

            for(i=2; i<num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0}는 소수가 아닙니다", num);
                    break;
                }
            }
            if (i == num) // 만약 i가 num과 같다면 = i가 num에 도달했다면 -> num은 어떤 수로도 나누어지지 않았음을 나타냄
            {
                Console.WriteLine("{0}는 소수입니다", num);
            }
            

            bool sign = false;
            double pi = 0;

            for(int i=1; i<=10000; i += 2)
            {
                if (sign == false)
                {
                    pi += 1.0 / i;
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / i;
                    sign = false;
                }
                Console.WriteLine("i={0}, Pi={1}", i, 4*pi);
            

            int sum = 0;
            int days = 1;
            int money = 1000;

            while (true)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum={2,11:C}", days, money, sum);
                if (sum >= 1000000) break;
                days++;
                money *= 2;
            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);

            for (sum = 0, days = 1, money = 1000; ; days++, money *= 2)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum={2,11:C}", days, money, sum);
                if (sum >= 1000000) break;
            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);
           

            int sum = 0;
            for(int i=0; ; i++)
            {
                sum += i;
                if (sum >= 10000)
                {
                    Console.WriteLine("1~{0}의 합: {1}", i, sum);
                    break;
                }
            }

            sum = 0;
            int idx = 1;
            for(; sum<10000; idx++)
            {
                sum += idx;
            }
            Console.WriteLine("1~{0}의 합: {1}", idx - 1, sum);
            

            Console.Write("숫자를 입력하세요: ");
            int n=int.Parse(Console.ReadLine());

            int sum = 0;
            for(int i=1; i<=n; i++)
            {
                int fact = 1;
                for(int j=2; j<=i; j++)
                {
                    fact *= j;
                }
                sum+= fact;
                Console.WriteLine("{0,2}! = {1,10:#,#}", i, fact); // 10자리 출력  &  #,# >> 천단위 구분 형식 지정자
            }
            Console.WriteLine("1! + 2! + ... + {0}! = {1:N0}", n, sum); // N:숫자 형식으로 출력, 천단위 구분 기호  &&  0: 소수점 이하 자릿수 0으로 지정 
            

            for(int y=1; y<=9; y++)
            {
                for(int x=2; x<=9; x++)
                {
                    Console.Write("{0}x{1}={2,2} ", x, y, x * y);
                }
                Console.WriteLine();
            }
            

            int idx;
            int primes = 0;

            for(int i=2; i<1000; i++)
            {
                for (idx = 2; idx < i; idx++)
                {
                    if (i % idx == 0) break; // i가 idx로 나누어지면 소수가 아님 >> 빠져나옴
                }

                if (idx == i) // 소수이면
                {
                    primes++;
                    Console.Write("{0,5}{1}", i, primes % 15 == 0 ? "\n" : ""); // 15번째 소수마다 줄을 바꿈
                }
            }
            Console.WriteLine("\n2부터 1000 사이 소수의 개수: {0}개", primes);
            

            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            

            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            

            for(int i=5; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            

            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=5-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            

            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=5-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            

            for(int i=5; i>=1;  i--)
            {
                for(int j=1; j<=5-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */

            int[] a = { 1, 2, 3 };
            Console.Write("a[]: ");
            foreach(var value in a)
            {
                Console.Write(value+" ");
            }

            int[] b = { 1, 2, 3 };
            Console.Write("\nb[]: ");
            for(int i=0; i<3; i++)
            {
                Console.Write(b[i] + " ");
            }

            int[] c = new int[3] { 1, 2, 3 };
            Console.Write("\nc[]: ");
            for (int i = 0; i < c.Length; i++) 
            {
                Console.Write(c[i] + " ");
            }

            int[] d = new int[3];
            d[0] = 1;
            d[1] = d[0] + 1;
            d[2] = d[1] + 1;
            Console.Write("\nd[]: ");
            foreach(int value in d)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
