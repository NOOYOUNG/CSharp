using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A59_61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("2차원 배열: arrA[2,3]");
            int[,] arrA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write("{0,5}", arrA[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("가변 배열: arrB[2][3]");
            int[][] arrB=new int[2][];
            arrB[0] = new int[] { 1, 2 };
            arrB[1] = new int[] { 3, 4, 5 };

            for(int i=0; i<2; i++)
            {
                Console.Write("arrB[{0}]: ", i);
                for(int j=0; j < arrB[i].Length; j++)
                {
                    Console.Write("{0} ", arrB[i][j]);
                }
                Console.WriteLine();
            }
            */

            Random r = new Random(); // 난수 생성하는 객체
            Console.Write("{0,-16}", "Random Bytes");
            Byte[] b = new byte[5];
            r.NextBytes(b); // NextBytes(): 0~255 범위의 난수 바이트를 배열에 채움

            foreach (var x in b)
            {
                Console.Write("{0,12}", x);
            }
            Console.WriteLine();


            Console.Write("{0,-16}", "Random Double");
            double[] d=new double[5];

            for(int i=0; i<5; i++)
            {
                d[i]=r.NextDouble(); // NextDouble(): 0.0과 1.0 사이 double 형식 난수를 생성
            }

            foreach(var x in d)
            {
                Console.Write("{0,12:F8}", x); // double 값을 12자리로 오른쪽 정렬하고, 소수점 이하 8자리까지 출력
            }
            Console.WriteLine();


            Console.Write("{0,-16}", "Random Int32");
            int[] a=new int[5];

            for(int i=0; i<5; i++)
            {
                a[i] = r.Next(); // Next(): int 범위 내에서 무작위 정수를 생성
            }
            PrintArray(a);


            Console.Write("{0,-16}", "Random 0~99");
            int[] v=new int[5];

            for(int i=0; i<5; i++)
            {
                v[i] = r.Next(100); // 0부터 99까지의 무작위 정수 생성
            }
            PrintArray(v);
        }

        private static void PrintArray(int[] a)
        {
            foreach(var i in a)
            {
                Console.Write("{0,12}", i);
            }
            Console.WriteLine();
        }
    }
}
