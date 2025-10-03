using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TryCatchExample
    {
        internal static void demonstrateTryCatch()
        {
            try
            {
                Console.WriteLine("Enter a number to divide 100 by:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                // Custom exception for negative numbers
                if (divisor < 0)
                {
                    throw new Exception("Custom Error: Negative numbers are not allowed as a divisor.");
                }

                int result = 100 / divisor;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero. Please enter a non-zero number.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution of try-catch block completed.");
            }
        }
    }
}
