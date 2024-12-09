using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Before arr[0]={0}", arr[0]);
            Change(arr);
            Console.WriteLine("After arr[0]={0}", arr[0]);

            Student s1=new Student();
            s1.name = "Alpha";
            Console.WriteLine("Before s1: "+s1.name);
            Change(s1);
            Console.WriteLine("After s1: " + s1.name);
        }

        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

        private static void Change(Student s1)
        {
            s1.name = "Beta";
        }
    }

    class Student
    {
        public string name;
    }
}
