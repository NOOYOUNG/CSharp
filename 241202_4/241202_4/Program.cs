using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vars = { "apple", "banana", "grape" };
            Console.WriteLine(vars[0]);

            //2차원배열
            int[,] abc = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(abc[0,0]); 
            Console.WriteLine(abc[1,2]);

            //가변배열
            int[][] ab = new int[3][];
            ab[0] = new int[4];
            ab[1] = new int[2];
            ab[2] = new int[3];
        }
    }
}
