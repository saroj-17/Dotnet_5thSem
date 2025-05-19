
/*
//Exception Hanlding 
- It is a mechanism to handle runtime errors in a controlled manner during program execution(run time).
- It allows the program to continue executing or terminate gracefully instead of crashing.
- They are of different types: 
  - SystemException: Base class for all system exceptions.
  - ApplicationException: Base class for application-specific exceptions.
  - DivideByZeroException: Thrown when dividing by zero.
  - NullReferenceException: Thrown when trying to access a null object.
  - IndexOutOfRangeException: Thrown when accessing an invalid index in an array or collection.
  - InvalidOperationException: Thrown when a method call is invalid for the object's current state.
  - FormatException: Thrown when a format is invalid or not supported.
  - ArgumentNullException: Thrown when a null argument is passed to a method that does not accept it.
  -custom exception: User-defined exceptions that inherit from the Exception class.
- Exception Handling Keywords:
    - try: Block of code to be monitored for exceptions.
    - catch: Block of code to handle the exception.
    - finally: Block of code that executes after try/catch, regardless of an exception.
    - throw: Used to raise an exception manually.
    - using: Ensures proper disposal of resources (e.g., file streams).

    Why? 
    - Prevents program crashes.
    - Code rediability and maintainability.
    - Debugging and error tracking.
    - User friendly error messages. 
*/

using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling Example");
            FileHandler.HandleFileException();
            Console.WriteLine("File handling completed.");
            ArithmeticHandler.HandleArithmeticException();
            Console.WriteLine("Arithmetic operation completed.");
            ArrayHandler.HandleArrayException();
            Console.WriteLine("Array handling completed.");
            NullHandler.HandleNullException();
            Console.WriteLine("Null handling completed.");
            VotingExceptionHandler.HandleVotingException();
            Console.WriteLine("Voting exception handling completed.");
            Console.WriteLine("Program completed successfully.");

        }
    }
    
}