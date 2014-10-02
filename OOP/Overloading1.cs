using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Overloading1
    {
        void Foo(object a)
        {
            Console.WriteLine("object");
        }

        void Foo(object a, object b)
        {
            Console.WriteLine("object, object");
        }

        void Foo(params object[] args)
        {
            Console.WriteLine("params object[]");
        }

        void Foo<T>(params T[] args)
        {
            Console.WriteLine("params T[]");
        }

        class Bar
        {

        }

        public void Start()
        {
            Foo();
            Foo(null);
            Foo(new Bar());
            Foo(new Bar(), new Bar());
            Foo(new Bar(), new object());
        }
    }
}
