using System;

namespace ConsoleApp1
{
    internal class Operation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"The difference of {a} and {b} is: {a - b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"The product of {a} and {b} is: {a * b}");
        }

        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine($"The quotient of {a} and {b} is: {a / b}");
            else
                Console.WriteLine("❌ Cannot divide by zero!");
        }
    }
}
