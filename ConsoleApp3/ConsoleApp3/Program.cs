using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다");

            do
            {
                LongNameAnimal(animal);
                Console.Write("동물 이름: ");
            } while ((animal = Console.ReadLine()) != ""); // 입력받은 값을 animal 변수에 저장, animal이 빈 문자열이 아니라면 계속해서 반복
        }

        private static void LongNameAnimal(string animal)
        {
            if (animal?.Length >=4) // 널 조건부 연산자
            { // animal이 null인 경우에 null을 반환하고, animal이 null이 아닌 경우에 animal.Length 값을 반환
                Console.WriteLine(animal+" : "+animal.Length);
            }
        }
    }
}
