using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 25, 75, 35, 15 };
            PrintArray(a);

            int[] b;
            b = (int[])a.Clone();
            PrintArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3); // 배열 a의 처음 3개의 원소를 배열 c의 인덱스 1부터 복사  >>    0    5   25   75    0    0    0    0    0    0
            /*
             * 첫 번째 인자는 원본 배열 a
             * 두 번째 인자는 원본 배열에서 복사를 시작할 인덱스(여기서는 0)
             * 세 번째 인자는 대상 배열 c
             * 네 번째 인자는 대상 배열에서 복사를 시작할 인덱스(여기서는 1)
             * 마지막 인자는 복사할 원소의 개수(여기서는 3)
            */
            PrintArray(c);

            a.CopyTo(c, 3); // 배열 a의 모든 요소를 배열 c의 인덱스 3부터 복사  >>    0    5   25    5   25   75   35   15    0    0
            PrintArray(c);

            Array.Sort(a); // 오름차순 정렬
            PrintArray(a);

            Array.Reverse(a); // 역순 정렬
            PrintArray(a);

            Array.Clear(a, 0, a.Length); // 배열 a의 모든 원소를 0으로 초기화
            /*
             * 첫 번째 인자는 원본 배열 a
             * 두 번째 인자는 초기화 시작 인덱스(여기서는 0)
             * 세 번째 인자는 초기화할 원소의 개수(여기서는 배열 전체 길이 a.Length
            */
            PrintArray(a);
        }

        private static void PrintArray(int[] a)
        {
            foreach(var i in a){
                Console.Write("{0,5}", i);
            }
            Console.WriteLine();
        }
    }
}
