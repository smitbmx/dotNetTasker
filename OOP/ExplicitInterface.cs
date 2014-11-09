using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// If a class implements two interfaces that contain a member with the same signature, 
    /// then implementing that member on the class will cause both interfaces to use that 
    /// member as their implementation. In the following example, 
    /// all the calls to Paint invoke the same method.
    /// </summary>
    public class ExplicitInterface
    {
        interface IControl
        {
            void Paint();
        }

        interface ISurface
        {
            void Paint();
        }

        class SampleClass : IControl, ISurface
        {
            public void Paint()
            {
                Console.WriteLine("Paint method in SampleClass");
            }

            void IControl.Paint()
            {
                System.Console.WriteLine("IControl.Paint");
            }
            void ISurface.Paint()
            {
                System.Console.WriteLine("ISurface.Paint");
            }
        }

        public void Start()
        {
            SampleClass sc = new SampleClass();
            IControl ctrl = (IControl)sc;
            ISurface srfc = (ISurface)sc;

            sc.Paint();
            ctrl.Paint();
            srfc.Paint();
        }
    }





}
