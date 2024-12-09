using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random r=new Random();
            int[] v = new int[20];

            for(int i=0; i<v.Length; i++)
            {
                v[i] = r.Next(100);
            }
            PrintArray(v);

            int max = v[0];
            for(int i=1; i<v.Length; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                }
            }
            Console.WriteLine("최대값: {0}", max);

            int min = v[0];
            for(int i=1; i<v.Length; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                }
            }
            Console.WriteLine("최소값: {0}", min);

            int sum = 0;
            for(int i=0; i<v.Length; i++)
            {
                sum += v[i];
            }
            Console.WriteLine("합계: {0}\n평균: {1:F2}", sum, (double)sum / v.Length);
            */



            Random r=new Random();
            int[] v = new int[30];

            for(int i=0; i<30; i++)
            {
                v[i]=r.Next(1000);
            }
            PrintArray("정렬 전", v);


            // 정렬
            Array.Sort(v);
            PrintArray("정렬 후", v);


            Console.Write("=> 검색할 숫자를 입력하세요: ");
            int key=int.Parse(Console.ReadLine());
            int cnt = 0;

            // 선형탐색 : 배열의 첫 번째 원소부터 하나씩 차례대로 검색
            for (int i=0; i<v.Length-1; i++)
            {
                cnt++;
                if (v[i] == key)
                {
                    Console.WriteLine("v[{0}]={1}", i, key);
                    Console.WriteLine("선형 탐색의 비교횟수는 {0}회입니다.", cnt);
                    break;
                }
            }

            // 이진탐색 : 정렬된 배열에서만 사용 가능 -> 배열의 중간값을 기준으로 나누어가며, 찾고자 하는 값을 반으로 절반씩 좁혀가며 탐색
            cnt = 0;
            int low = 0;
            int high = v.Length-1;
            while(low <= high)
            {
                cnt++;
                int mid = (low + high) / 2;
                if (key == v[mid])
                {
                    Console.WriteLine("v[{0}]={1}", mid, key);
                    Console.WriteLine("이진탐색의 비교횟수는 {0}회입니다.", cnt);
                    break;
                }
                else if (key > v[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }

        private static void PrintArray(string s, int[] v)
        {
            Console.WriteLine(s);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("{0,5} {1}", v[i], (i % 10 == 9) ? "\n" : "");
                // {0,5}: 배열 v의 현재 원소(v[i])
                // {1}: 조건에 따라 줄 바꿈을 추가
                // 인덱스 i가 9로 나누어 떨어지는(10의 배수일 때) 경우 줄 바꿈 출력, 그렇지 않으면 아무 것도 출력X
            }
        }

        /*
        private static void PrintArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("{0,5} {1}", v[i], (i % 10 == 9) ? "\n" : "");
                // {0,5}: 배열 v의 현재 원소(v[i])
                // {1}: 조건에 따라 줄 바꿈을 추가
                // 인덱스 i가 9로 나누어 떨어지는(10의 배수일 때) 경우 줄 바꿈 출력, 그렇지 않으면 아무 것도 출력X
            }
        }
        */
    }
}
