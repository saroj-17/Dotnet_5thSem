using System; 
using System.IO;

namespace ExceptionHandlingExample
{
    public static class NullHandler{
        public static void HandleNullException()
        {
            try
            {
                // Code that may throw an exception
                string str = null;
                Console.WriteLine("String length: " + str.Length); // This will throw NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                // Handle the exception
                Console.WriteLine("Error: Null reference encountered. " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Null handling completed.");
            }
        }
    }
    }