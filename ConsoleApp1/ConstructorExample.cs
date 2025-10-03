using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConstructorExample
    {
        static ConstructorExample()
        {
            Console.WriteLine("ConstructorExample instance created!");
        }

       internal ConstructorExample()
        {
            Console.WriteLine("This is a private constructor.");
        }

        internal ConstructorExample(int x)
        {
            Console.WriteLine("Parameterized Constructor:"+x);
        }
    }
}
