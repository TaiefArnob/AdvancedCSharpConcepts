using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InheritanceExample
    {
        internal class Animal
        {
            public void Eat()
            {
                Console.WriteLine("This animal eats food.");
            }
        }

        // Derived Class (Child) inherits from Animal
        internal class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("The dog barks: Woof Woof!");
            }
        }

        // Another Derived Class
        internal class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("The cat meows: Meow Meow!");
            }
        }

    }
}
