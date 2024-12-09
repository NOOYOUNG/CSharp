using System; // System 네임스페이스
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _241202_1
{
    class Program
    {
        class car
        {
            private string handle = "";

            public void Run()
            {
                Console.WriteLine("자동차를 움직인다");
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("System을 이용한 호출");
            Console.WriteLine("메인글자찍기");

            car myCar = new car();
            myCar.Run();
        }
    }
}
