using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Inheritance1
    {
        public class A
        {
            public string GetName()
            {
                return "My name is: A";
            }
        }

        public class B : A
        {
            public string GetName()
            {
                return "My name is: B";
            }
        }

        public class Program
        {
           public void Start()
            {
                A instance = new B();
                Console.WriteLine(instance.GetName());
            }
        }
    }
}
