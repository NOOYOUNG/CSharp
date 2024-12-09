using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add(1);
            al.Add("Hello");
            al.Add(3.4);
            al.Add(true);

            foreach(var i in al)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            al.Remove("Hello");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            Queue q=new Queue();
            q.Enqueue(1); // Enqueue 아이템 추가
            q.Enqueue("Hello");
            while (q.Count > 0) {
                Console.WriteLine(q.Dequeue()); // Dequeue 첫 번째 요소를 제거하고 반환 (선입선출)
            };     


            Console.WriteLine();
            Stack st=new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop()); // 후입선출
            }

            Console.WriteLine();
            Hashtable ht=new Hashtable();
            ht["apple"] = "사과";
            ht["banana"] = "바나나";
            ht["orange"] = "오렌지";
            Console.WriteLine(ht["apple"]);
        }
    }
}
