using System; 
using System.IO;

namespace ExceptionHandlingExample
{
    //statc class 
    // static class is a class that cannot be instantiated and can only contain static members.
    // It is used to group related methods and properties together without creating an object.
    // Static classes are often used for utility functions or helper methods that do not require object state.

    public static class FileHandler{
        public static void HandleFileException(){
            try{
                //handle the code that may throw an exception 
                string filePath = "example.txt";

                string content = File.ReadAllText(filePath);
                Console.WriteLine("File content: " + content);
            }
            catch(FileNotFoundException ex)
            {
                //handle the exceptions 
                Console.WriteLine("File not found: " + ex.Message);
            }
            Console.WriteLine("File handling completed.");
        }
    }
}