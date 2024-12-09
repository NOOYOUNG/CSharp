using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 3, 5, 2, 7, 1 };
            PrintArray(v);

            // 버블정렬 : 배열의 인접한 원소들을 비교하고 교환하여 정렬
            for (int i=4; i>0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        int t = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = t;
                    }
                }
                PrintArray(v);
            }
        }

        private static void PrintArray(int[] v)
        {
            foreach(var i in v)
            {
                Console.Write("{0,5}", i);
            }
            Console.WriteLine();
        }
    }
}
