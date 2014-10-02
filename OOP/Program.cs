using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Overloading1 overloading1 = new Overloading1();
            overloading1.Start();

            Overloading2 overloading2 = new Overloading2();
            overloading2.Start();

            Console.ReadLine();
        }
    }
}
