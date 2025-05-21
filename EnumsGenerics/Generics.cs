namespace EnumGenerics; 

using System;
using System.Collections.Generic;

/**
  Theroy: 
    -> Generics allow you to define a class, method, delegate, or interface with a placeholder for the type of data it stores or uses.
    -> Generics provide a way to create reusable code that can work with any data type.
    -> Generics are defined using angle brackets <>.
    -> Generics improve code reusability, type safety, and performance.
    -> Generics are used in collections, LINQ, and many other areas of C#.
    -> We use T to represent a type parameter in generics.
    -> Generics are used to create classes, methods, and interfaces that can work with any data type.
**/

public class Box<T>
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }

    public void DisplayValue()
    {
        Console.WriteLine($"Value: {value}");
        //display the type of the value
        Console.WriteLine($"Type: {value.GetType()}");
    }
}

public class Utility
{
    //generic methods 
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp; 
        temp = a; 
        a = b;
        b = temp;  
    }

}