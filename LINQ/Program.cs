using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //EnumerableToArray enumerableToArray = new EnumerableToArray();
            //enumerableToArray.Start();

            LifeAfterYield lifeAfterYield = new LifeAfterYield();
            lifeAfterYield.Start();

            Console.ReadLine();
        }
    }
}
