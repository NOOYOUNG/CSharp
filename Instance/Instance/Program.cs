using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            name="초기상태";
            Console.WriteLine("이름은 " + name + "입니다");
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine(name + "의 나이는 " + age + "입니다");
        }
        ~Person()
        {
            Console.WriteLine(name + "이 초기화됩니다.");
        }

        public void eat()
        {
            Console.WriteLine(name + "이 식사를 한다.");
        }

        public void born()
        {
            Console.WriteLine("사람이 존재합니다.");
        }
    }

    class studentPerson : Person
    {
        public void introduce()
        {
            Console.WriteLine("저는 학생입니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.name = "서준";
            //p.eat();
            //Person p2 = new Person("코코", 3);

            studentPerson st1 = new studentPerson();
            st1.born();
            st1.introduce();
        }
    }
}
