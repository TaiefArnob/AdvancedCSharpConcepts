using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void MyDelegate(string message);
    internal class DelegateExample
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello: " + name);
        }

        public void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye: " + name);
        }
    }
}
