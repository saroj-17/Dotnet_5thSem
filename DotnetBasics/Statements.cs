namespace DotnetBasics; 

using System;

class Statements
{
    /** 
     Namespace 
        * A namespace is a collection of classes, interfaces, and other namespaces.
        * A namespace is used to organize code and avoid naming conflicts.
        * A namespace can contain other namespaces, classes, interfaces, enums, and structs.
        * A namespace can be declared using the "namespace" keyword.
        * A namespace can be nested inside another namespace.
        * A namespace can be used to group related classes and interfaces together.
        * A namespace can be used to avoid naming conflicts between classes and interfaces.
        * A namespace can be used to create a hierarchy of classes and interfaces.
        * A namespace can be used to create a modular structure for your code.
        * A namespace can be used to create a library of reusable code.
        * A namespace can be used to create a framework for your code.
        * A namespace can be used to create a package for your code.
        * A namespace can be used to create a module for your code.
        * A namespace can be used to create a component for your code.
    
     **/
    public void DemoStatements()
    {
        // Statements in C# 
        /**
         * A statement is a single line of code that performs a specific action.
         * A statement can be an expression, a declaration, or a control flow statement.
         * A statement can be terminated with a semicolon (;).
         **/
        int x = 10; //declaration statement
        Console.WriteLine(x); //expression statement
        if (x > 5) //control flow statement
        {
            Console.WriteLine("x is greater than 5");
        }

        //if-else statement
        if (x > 5)
        {
            Console.WriteLine("x is greater than 5");
        }
        else
        {
            Console.WriteLine("x is less than or equal to 5");
        } 

        //if-else ladder

        int age = 10; 
        if (age < 18)
        {
            Console.WriteLine("You are a minor");
        }
        else if (age >= 18 && age < 60)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are a senior citizen");
        }

        //nested if statement
        if (age < 18)
        {
            Console.WriteLine("You are a minor");
            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else
            {
                Console.WriteLine("You are a teenager");
            }
        }
        else if (age >= 18 && age < 60)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are a senior citizen");
        }

        //switch statement
        int day = 3; //1 for Sunday, 2 for Monday, 3 for Tuesday, 4 for Wednesday, 5 for Thursday, 6 for Friday, 7 for Saturday
        switch(day){
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        //while loop
        int i = 0; //initialization
        while (i < 5) //condition
        {
            Console.WriteLine(i); //body
            i++; //increment
        }

        //do-while loop
        int j = 0; //initialization
        do
        {
            Console.WriteLine(j); //body
            j++; //increment
        } while (j < 5); //condition

        //for loop

        for (int k = 0; k < 5; k++) //initialization, condition, increment
        {
            Console.WriteLine(k); //body
        }

        //foreach loop
        string[] names = { "John", "Jane", "Jack" }; //array
        foreach (string name in names) //collection
        {
            Console.WriteLine(name); //body
        }

        //nested-for loop 
        for (int m = 0; m < 5; m++) //outer loop
        {
            for (int n = 0; n < 5; n++) //inner loop
            {
                Console.WriteLine(m + " " + n); //body
            }
        }

        //break statement
        for (int o = 0; o < 5; o++) //loop
        {
            if (o == 3) //condition
            {
                break; //exit loop
            }
            Console.WriteLine(o); //body
        }

        label: //label
            Console.WriteLine("This is a label"); //label body


        //continue statement
        for (int p = 0; p < 5; p++) //loop
        {
            if (p == 3) //condition
            {
                continue; //skip iteration
            }
            Console.WriteLine(p); //body
        }

        //jump statement
        //jump statement is used to transfer control to another part of the program
        //in C#, jump statements are "goto", "break", "continue", "return", and "throw"
        //goto statement is used to transfer control to a labeled statement
        goto label; //jump to label


    }

}