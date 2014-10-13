using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Inheritance2
    {
        public class A
        {
            public virtual string GetName()
            {
                return "My name is: A";
            }
        }

        public class B : A
        {
            public override string GetName()
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
