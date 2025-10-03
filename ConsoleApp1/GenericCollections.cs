using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class GenericCollections
    {
        internal static void ShowExamples()
        {
            // ====== 1. List<T> ======
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");

            Console.WriteLine("List<T> Example:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // ====== 2. Dictionary<TKey, TValue> ======
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "John");
            students.Add(2, "Alice");
            students.Add(3, "Bob");

            Console.WriteLine("\nDictionary<TKey, TValue> Example:");
            foreach (var kvp in students)
            {
                Console.WriteLine($"Roll: {kvp.Key}, Name: {kvp.Value}");
            }

            // ====== 3. Queue<T> (FIFO) ======
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Task 1");
            tasks.Enqueue("Task 2");
            tasks.Enqueue("Task 3");

            Console.WriteLine("\nQueue<T> Example (FIFO):");
            while (tasks.Count > 0)
            {
                Console.WriteLine(tasks.Dequeue());
            }

            // ====== 4. Stack<T> (LIFO) ======
            Stack<int> numbers = new Stack<int>();
            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            Console.WriteLine("\nStack<T> Example (LIFO):");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }

            // ====== 5. HashSet<T> (Unique items) ======
            HashSet<int> uniqueNumbers = new HashSet<int>();
            uniqueNumbers.Add(1);
            uniqueNumbers.Add(2);
            uniqueNumbers.Add(2); // duplicate ignored
            uniqueNumbers.Add(3);

            Console.WriteLine("\nHashSet<T> Example (No Duplicates):");
            foreach (int num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
