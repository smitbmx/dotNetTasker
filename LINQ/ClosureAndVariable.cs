using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class ClosureAndVariable
    {
        public void Start()
        {
            var list = new List<string> { "A", "BB", "CCC", "DDDD", "EEEEE" };
            var minLength = 3;
            var query = list.Where(c => c.Length >= minLength);
            minLength = 2;
            query = list.Where(c => c.Length >= minLength);

            Console.WriteLine(query.Count());
        }
    }
}
