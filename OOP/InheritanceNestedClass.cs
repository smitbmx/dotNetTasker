using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class InheritanceNestedClass
    {
        class Foo
        {
            protected class Quux
            {
                public Quux()
                {
                    Console.WriteLine("Foo.Quux()");
                }
            }
        }

        class Bar : Foo
        {
            new class Quux
            {
                public Quux()
                {
                    Console.WriteLine("Bar.Quux()");
                }
            }
        }

        class Baz : Bar
        {
            public Baz()
            {
                new Quux();
            }
        }

        public void Start()
        {
            new Baz();
        }
    }
}
