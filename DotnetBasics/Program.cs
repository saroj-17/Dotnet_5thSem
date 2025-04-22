using System;
using System.Runtime.InteropServices.Marshalling;

namespace DotnetBasics{
    class Program{
        public static void Main(string[] args){
            //identifiers
            /** 
            * Identifiers are the names of variables, methods, classes, etc.
            * Identifiers are case-sensitive and must begin with a letter or an underscore.
            * Identifiers can contain letters, digits, and underscores.
            * Identifiers cannot contain whitespace characters or special characters like !, @, #, %, etc.
            * Identifiers cannot be a keyword.
            **/
            int a = 10; 
            int A = 20;
            int _a = 30;
            int a1 = 40;
            int a_1 = 50;
            int a_ = 60;
            int a__ = 70;
            int a__1 = 80;
            int a__2 = 90;
            int a__3 = 100;

            Console.WriteLine(a);
            Console.WriteLine(A);   
            Console.WriteLine(_a);
            Console.WriteLine(a1);
            Console.WriteLine(a_1);
            Console.WriteLine(a_);
            Console.WriteLine(a__);
            Console.WriteLine(a__1);
            Console.WriteLine(a__2);
            Console.WriteLine(a__3);

            //datatypes in c# 
            /**
            * Data types are used to declare variables before using them in a program.
            * Data types specify the type of data that a valid C# variable can hold.
            * C# is a strongly-typed language. This means that every variable must have a data type associated with it.
            * C# has two categories of data types: Value types and Reference types.
            **/
            int i = 12; //integer
            double d = 12.5;  //double
            char c = 'A'; //character
            string s = "Hello"; //string
            bool b = true; //boolean

            Console.WriteLine(i); 
            Console.WriteLine(d); 
            Console.WriteLine(c); 
            Console.WriteLine(s); 
            Console.WriteLine(b); 

            //Operators in C# 
            /**
            * Operators are symbols that perform operations on variables and values.
            * Operators can be of different type: arithmentic operators, assignment operators, comparison operators, logical operators, bitwise operators, etc.

            **/

            int num1 = 10; 
            int num2 = 30 ; 

            //arithmetic operation 
            Console.WriteLine($"The sum of {num1} + {num2} = {num1+num2}");
            Console.WriteLine($"The difference of {num1} - {num2} = {num1-num2}");
            Console.WriteLine($"The product of {num1} * {num2} = {num1*num2}");
            Console.WriteLine($"The division of {num1} / {num2} = {num1/num2}");
            Console.WriteLine($"The modulus of {num1} % {num2} = {num1%num2}");

            //assignment operation
            int num3 = 10;
            num3 += 10; //num3 = num3 + 10
            Console.WriteLine(num3);

            //comparison operation
            Console.WriteLine(num1 == num2); //false
            Console.WriteLine(num1 != num2); //true
            Console.WriteLine(num1 > num2); //false
            Console.WriteLine(num1 < num2); //true
            Console.WriteLine(num1 >= num2); //false

            //logical operation
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine(isTrue && isFalse); //false
            Console.WriteLine(isTrue || isFalse); //true
            Console.WriteLine(!isTrue); //false

            //bitwise operation
            int num4 = 40; //101000
            int num5 = 50;//110010
            
            //......................
            //            100000
            Console.WriteLine(num4 & num5); 
            Console.WriteLine(num4 | num5);
            Console.WriteLine(num4 ^ num5);
            Console.WriteLine(~num4);
            Console.WriteLine(num4 << 2);
            Console.WriteLine(num4 >> 2);

            //String Operations in C#endregion
            //Important String Operations in C#
            string message = "Hello, Class";
            string response = "Welcome to C# Programming";
            Console.WriteLine(message);
            Console.WriteLine(message.Length);
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());
            Console.WriteLine(message.Contains("Hello Jeevan"));
            Console.WriteLine(message.IndexOf("Class"));
            Console.WriteLine(message.Substring(7));
            Console.WriteLine(message.Substring(7, 3));
            Console.WriteLine(message.Replace("Class", "World"));
            // Console.WriteLine(message.Reverse());
            Console.WriteLine(message + response);

            //Escape Sequences in C#
            //Escape sequences are used to perform various tasks like printing a newline, backspace, tab, etc.

            Console.WriteLine("Hello \t \t World");
            Console.WriteLine("Hello \nWorld");
            Console.WriteLine("Hello \b World");
            Console.WriteLine("Hello \r World");
            Console.WriteLine("Hello \\ World");
            Console.WriteLine("Hello \f World");

            //lab 3 Arrays in c# 
            Console.WriteLine(" \n Arrays in C# \n"); 

            /**
            Arrys are linear datastructure which store values(data) in contigous memory location. 
            Arrays has index. The size of index of an array varies from 0 to size-1
            e.g. 

            int[] array = {10, 20, 30, 40, 50}

                 Index     0    1   2   3   4
                 Values : array[2] = 30 
            **/

            //single dimentional array in C# 

            int[] numbers = {10, 20, 30, 50, 60, 70, 90}; 
            Console.WriteLine($"The size of an array numbers is {numbers.Length}"); 

            foreach (int items in numbers)
            {
                Console.Write(items+"\t"); 
               
            }
             Console.WriteLine();

            string[] fruits = {"Apple", "Banana", "Mango", "Papaya"}; 

            foreach(string items in fruits)
            {
                Console.Write(items+"\t");
            }
            Console.WriteLine("\n"); 

            //access and manupulation of arrays 
            Console.WriteLine(fruits[3]); 
            Console.WriteLine(fruits[0]); 

            fruits[0] = "Grapes"; 
            Console.WriteLine(fruits[0]); 

            //resizing array elements 

            Array.Resize(ref fruits, 3); 
            fruits[2] = "Guva"; 
            Console.WriteLine("Fruits adding element to 3rd index");

            foreach(string fruit in fruits){
                Console.WriteLine(fruit); 
            }

            //searching elements in an array 
            string searchFruit = "Watermelon"; 
            int position = Array.IndexOf(fruits, searchFruit); 
            if(position!= -1)
            {
                Console.WriteLine($"{searchFruit} found at {position} Index"); 
            }
            else
            {
                Console.WriteLine($"{searchFruit} not found in array "); 
            }


            //sorting elements in an array   
            Array.Sort(fruits);
            Console.WriteLine("Fruits after sorting");
            foreach(string fruit in fruits){
                Console.WriteLine(fruit); 
            }


            //reversing elements in an array
            Array.Reverse(fruits);
            Console.WriteLine("Fruits after reversing");
            foreach(string fruit in fruits){
                Console.WriteLine(fruit); 
            }

            //multi-dimentional array in C#
            int[,] matrix = {{1, 2, 3},
                             {4, 5, 6},
                             {7, 8, 9}};
            Console.WriteLine("Matrix is: ");
            for(int k=0; k<matrix.GetLength(0); k++)
            {
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[k,j] + "\t");
                }
                Console.WriteLine();
            }

            //jagged array in C#
            // jagged array is an array of arrays.
            // jagged array can have different number of elements in each row.

            int[][] jaggedArray = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6, 7},
                new int[] {8, 9}
            };

            //displaying jagged array 
            for(int k=0; k<jaggedArray.Length; k++)
            {
                for(int j=0; j<jaggedArray[k].Length; j++)
                {
                    Console.Write(jaggedArray[k][j] + "\t");
                }
                Console.WriteLine();
            }

            //object 
            //object is an instance of a class.

            Statements st = new Statements();
            st.DemoStatements();

            // Define the Statements class with the DemoStatements method
           


        }
    }

}