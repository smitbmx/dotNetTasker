using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLst
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            //LinkedList<string> list2 = new LinkedList<string>();
            list.Add("Test1");
            list.Add("Test2");
            list.Add(1, "Test3");
            

            Console.ReadLine();
        }
    }
}
