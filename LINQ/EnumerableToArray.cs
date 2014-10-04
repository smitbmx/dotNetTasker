using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class EnumerableToArray
    {
        public static int CreateNumber(int x)
        {
            Console.WriteLine("CreateNumber: " + x);
            return x;
        }

        public static IEnumerable<int> GetSmallNumbers()
        {
            yield return CreateNumber(1);
            yield return CreateNumber(2);
        }

        public static int[] GetArray()
        {
            var numbers = GetSmallNumbers();

            foreach (var number in numbers)
            {
                Console.WriteLine("GetArray: " + number);
            }

            return numbers.ToArray();
        }


        public void Start()
        {
            GetArray();
        }
    }
}
