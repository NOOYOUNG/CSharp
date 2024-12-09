using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("나눌 숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(10 / num);
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
