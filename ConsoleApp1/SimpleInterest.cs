using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SimpleInterest
    {
       internal void CalculateSimpleInterest(double principal, double rate, double time)
        {
            double simpleInterest = (principal * rate * time) / 100;
            Console.WriteLine($"The Simple Interest for Principal: {principal}, Rate: {rate}%, Time: {time} years is: {simpleInterest}");
        }
    }
}
