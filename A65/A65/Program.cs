using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A65
{
    struct DateStruct
    {
        public int year, month, day;
    }

    class DateClass
    {
        public int year, month, day;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DateStruct sDay;
            sDay.year = 2018;
            sDay.month = 11;
            sDay.day = 22;
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);

            DateClass cDay=new DateClass();
            cDay.year = 2024;
            cDay.month = 12;
            cDay.day = 9;
            Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);

            DateStruct sDay2=new DateStruct();
            Console.WriteLine("sDay2: {0}/{1}/{2}", sDay2.year, sDay2.month, sDay2.day);

            DateClass cDay2 =new DateClass();
            Console.WriteLine("cDay2: {0}/{1}/{2}", cDay2.year, cDay2.month, cDay2.day);

            DateStruct s = sDay;
            DateClass c = cDay;

            s.year = 2000;
            c.year = 2002;

            Console.WriteLine("s: {0}/{1}/{2}", s.year, s.month, s.day);
            Console.WriteLine("c: {0}/{1}/{2}", c.year, c.month, c.day);
            
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);
            // DateStruct는 구조체로 정의(값 타입) -> s에서 year를 변경해도 원본 sDay에는 영향 X

            Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);
            // DateClass는 클래스이므로 참조 타입 -> 클래스 타입의 객체는 메모리 상에서 객체의 실제 데이터를 참조하는 방식으로 처리
        }
    }
}
