using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class QueryAfterRemove
    {
        public void Start()
        {
            var list = new List<string> {"A", "BB", "CCC"};
            var query = list.Where(c => c.Length == 2);
            list.Remove("BB");
            Console.WriteLine(query.Count());
        }
    }
}
