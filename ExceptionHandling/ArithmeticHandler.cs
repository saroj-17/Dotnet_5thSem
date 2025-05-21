using System; 
using System.IO;

namespace ExceptionHandlingExample
{
    public static class ArithmeticHandler
    {
        public static void HandleArithmeticException()
        {
            try
            {
                // Code that may throw an exception
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator; // This will throw DivideByZeroException
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                // Handle the exception
                Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Arithmetic operation completed.");
            }
        }
    }
    }