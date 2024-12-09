using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault()); // 값이 있으면 그 값을 가져오고, null이면 디폴트 값 가져옴 >> 디폴트 값인 0 출력

            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine("Null"); // null 상태이므로 "Null" 출력
            }


            int? x = null;
            /*  int?  ->  널 허용 형식(Nullable type)  
             *  C#에서는 int와 같은 값 타입은 null을 가질 수 없지만, int?와 같은 널 허용 형식을 사용하면 null 값을 할당할 수 있습니다.
             *  int? 는 사실 내부적으로 int와 bool? 와 유사하게 값과 null을 구분할 수 있도록 설계된 타입입니다.
             *  x = null; 은 x에 null 값을 할당합니다. 즉, x는 "값이 없음을 나타내는 상태"입니다. */


            int j = x ?? 0;
            /*  ?? 연산자  ->  널 병합 연산자(Null-coalescing operator)
             *  이 연산자는 왼쪽 값이 null일 경우, 오른쪽 값을 사용하는 방식으로 동작합니다.
             *  예를 들어, x ?? 0은 x가 null이면 0을 대입하고, 그렇지 않으면 x의 값을 대입합니다.
             *  따라서 x가 null이기 때문에, j에는 0이 할당됩니다. */


            Console.WriteLine("x={0}, j={1}", x, j);

            Console.WriteLine("x>=10 ? {0}", x >= 10); // null과 비교할 수 없으므로 항상 False
            Console.WriteLine("x<10 ? {0}", x < 10);


            /* Nullable.Compare<T>(i, j) >> i와 j를 비교
             *  i < j일 경우 : 음수,
             *  i == j일 경우 : 0,
             *  i > j일 경우 : 양수를 반환 */

            if (Nullable.Compare<int>(i, j) < 0)
            {
                Console.WriteLine("i<j");
            }
            else if (Nullable.Compare<int>(i, j) > 0)
            {
                Console.WriteLine("i>j");
            }
            else
            {
                Console.WriteLine("i=j");
            }
        }
    }
}
