using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class LifeAfterYield
    {
        private IEnumerable<int> Foo()
        {
            yield return 1;
            Console.WriteLine("Foo");
        }

        public void Start()
        {
            foreach (var i in Foo())
            {
                Console.WriteLine(i);
            }
        }
    }
}
