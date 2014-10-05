using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class FigureoutNewClass
    {
        public class Human
        {
            public string Name;
            public string Sex;

            public Human()
            {
                Name = string.Empty;
                Sex = "unknown";
            }
        }

        public class Man:Human
        {
            public string Strong;

            public Man()
            {
                Strong = "unknown";
            }
        }

        new class Woman:Human
        {
            public string Pretty;

            public Woman()
            {
                Sex = "woman";
                Pretty = "unknown";
            }
        }


        public void Start()
        {
            Human man = new Man();

            Human woman = new Woman();
        }
    }
}
