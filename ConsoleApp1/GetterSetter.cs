using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GetterSetter
    {
        int width;
        internal int Width
        {
            get { return width; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Width cannot be negative. Setting to 0.");
                }
                else
                {
                    width = value;
                }
            }
        }
    }
}
