﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumerableToArray enumerableToArray = new EnumerableToArray();
            //enumerableToArray.Start();

            LifeAfterYield lifeAfterYield = new LifeAfterYield();
            //lifeAfterYield.Start();

            Closure  closure = new Closure();
            //closure.Start();

            QueryAfterRemove queryAfterRemove = new QueryAfterRemove();
            //queryAfterRemove.Start();

            ClosureAndVariable closureAndVariable = new ClosureAndVariable();
            closureAndVariable.Start();

            Console.ReadLine();
        }
    }
}
