using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Inheritance3DifferentTypes
    {
        public interface IInterface
        {
            void PrintName();
        }

        public abstract class MyAbstractClass
        {
            private void PrintName()
            {
                Console.WriteLine("I am an abstract class");
            }
        }

        public class MyClass : IInterface
        {
            public void PrintName()
            {
                Console.WriteLine("I am a class");
            }
        }

        public struct MyStruct : IInterface
        {
            public void PrintName()
            {
                Console.WriteLine("I am a struct");
            }
        }

        public void Start()
        {
        }
    }
}
