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
            //Overloading1 overloading1 = new Overloading1();
            //overloading1.Start();

            //Overloading2 overloading2 = new Overloading2();
            //overloading2.Start();

            //Overloading3 overloading3 = new Overloading3();
            //overloading3.Start();

            //InheritanceNestedClass inheritanceNestedClass = new InheritanceNestedClass();
            //inheritanceNestedClass.Start();

            FigureoutNewClass figureoutNewClass = new FigureoutNewClass();
            //figureoutNewClass.Start();

            Inheritance1.Program inheritance1 = new Inheritance1.Program();
            //inheritance1.Start();

            Inheritance2.Program inheritance2 = new Inheritance2.Program();
            inheritance2.Start();


            Console.ReadLine();
        }
    }
}
