using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A37
{
    internal class Program
    {
        enum E { Red, Green, Blue };

        static void Main(string[] args)
        {
            int a = default; // 디폴트 할당 -> 0으로 초기화
            string s = default; // 디폴트 할당 -> null로 초기화
            Console.WriteLine("a=" + a);
            Console.WriteLine("s=" + s);

            Console.WriteLine("E="+default(E)); // 열거형의 디폴트 값인 Red
            Console.WriteLine("E=" + (E)0); // (E)0에 해당하는 Red

            MyList<int> iList = new MyList<int>();
            Console.WriteLine("iList: " + iList.GetLast());

            MyList<string> sList=new MyList<string>();
            Console.WriteLine("sList: "+sList.GetLast());

            // AddNode 메서드는 호출되지 않아서 head는 여전히 null 상태
            // 따라서 GetLast 메서드는 default(T) 값 반환(int 타입의 경우 0 & string 타입의 경우 null)
        }
    }

    public class MyList<T> {
        private class Node
        {
            public T data;
            public Node next;
        }

        private Node head = default;

        public void AddNode(T t)
        {
            Node newNode=new Node();
            newNode.next = head;
            newNode.data = t;
            head = newNode;
        }

        public T GetLast() { 
            T temp=default(T);

            Node current=head;
            while (current != null)
            {
                temp=current.data;
                current=current.next;
            }
            return temp;
        }
    }
}
