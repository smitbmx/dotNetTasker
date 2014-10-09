using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Closure
    {
        private void DoSomething(int i)
        {
            Console.WriteLine("Start");
            Console.WriteLine(i);
            Console.WriteLine("Finish");
        }

        public void Start()
        {
            var actions = new List<Action>();

            foreach (var action in Enumerable.Range(1,3))
            {
                actions.Add(() => DoSomething(action));
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
