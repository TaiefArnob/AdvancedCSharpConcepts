using System;
using ConsoleApp1; // Import namespace

class Program
{
    static void Main(string[] args)
    {
        Operation op = new Operation();

        while (true)
        {
            Console.WriteLine("\n===== Simple Calculator Using Switch Case =====");

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("\nEnter your choice (1-5): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    op.Add(a, b);
                    break;

                case 2:
                    op.Subtract(a, b);
                    break;

                case 3:
                    op.Multiply(a, b);
                    break;

                case 4:
                    op.Divide(a, b);
                    break;

                case 5:
                    Console.WriteLine("👋 Exiting program... Goodbye!");
                    return;

                default:
                    Console.WriteLine("❌ Invalid choice! Please select between 1-5.");
                    break;
            }

            // SimpleInterest Example
            SimpleInterest si = new SimpleInterest();
            si.CalculateSimpleInterest(a, 5, 2); // Example with rate=5% and time=2 years

            // Voter Example
            voter v = new voter();
            Console.Write("Enter your age to check voting eligibility: ");
            int ab = Convert.ToInt32(Console.ReadLine());
            v.checkVotingAbility(ab);

            // Static and Instance Methods Example
            A.sayHello();
            A a1 = new A();
            a1.instanceMethod();

            // Constructor Example
            ConstructorExample obj1 = new ConstructorExample();
            ConstructorExample obj2 = new ConstructorExample(10);

            // Getter Setter Example
            GetterSetter ob1 = new GetterSetter();
            ob1.Width = 20; // Using setter
            Console.WriteLine($"Width is: {ob1.Width}"); // Using getter

            // Inheritance Example
            Console.WriteLine("\n=== Inheritance Example ===");
            InheritanceExample.Dog dog = new InheritanceExample.Dog();
            dog.Eat();   // inherited from Animal
            dog.Bark();  // Dog’s own method

            InheritanceExample.Cat cat = new InheritanceExample.Cat();
            cat.Eat();   // inherited from Animal
            cat.Meow();  // Cat’s own method

            // Try-Catch Example
            TryCatchExample.demonstrateTryCatch();

            FileOperations ob2 = new FileOperations();
            ob2.createFile();
            ob2.addContentOnFile();

            NonGenericCollections ob3 = new NonGenericCollections();
            ob3.ArrayListFunc();

            MyDelegate del;
            DelegateExample obj3 = new DelegateExample();
            obj3.SayHello("Taief");
            obj3.SayGoodbye("Taief");
        }
    }
}
