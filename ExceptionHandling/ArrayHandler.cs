using System;
using System.IO; 

namespace ExceptionHandlingExample{
    public static class ArrayHandler{
        public static void HandleArrayException(){
            try{
                //code that may throw an exception
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine("Array element: " + numbers[3]); // This will throw IndexOutOfRangeException
            }
            catch(IndexOutOfRangeException ex){
                //handle the exception
                Console.WriteLine("Error: Index out of range. " + ex.Message);
            }
            finally{
                Console.WriteLine("Array handling completed.");
            }
        }
    }
}
