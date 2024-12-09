using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("글자찍기");
            String str1 = "*";
            Console.WriteLine(str1);

            int num = -5;
            int num2 = 3;
            Console.WriteLine(num+num2);

            long bNum=1000000000000000000L;
            Console.WriteLine(bNum);

            short sNum = 5000;
            Console.WriteLine(sNum);

            byte sByte = 250;
            Console.WriteLine(sByte);

            bool bBool = false;
            bool bBool2 = true;
            Console.WriteLine(bBool+" and bBool2 is "+bBool2);

            char cstr = 'a';
            Console.WriteLine(cstr);

            float fNum = 0.5F;
            Console.WriteLine(fNum);

            double dNum = 0.555555555555555555D;
            Console.WriteLine(dNum); // 반올림되어 출력

            //Int to String
            string c = "";
            c = num.ToString();
            Console.WriteLine(c);
        }
    }
}
