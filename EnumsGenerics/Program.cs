

using System.Net;
using System.Xml.Serialization;
using EnumGenerics; // Import the namespace for the enum and generics classes
using System.Collections.Generic;

/**
    Lab 7 :
    Title:  Enums and Generics programming in C# 

    Objective: 

    -> To understand the concept of ENUMS in C# 
    -> To understand the concept of GENERICS in C#

    Theory: 

    -> Enums are a special "class" that represents a group of constants (unchangeable/read-only variables).
    -> Enums are strongly typed constants.
    -> Enums are used when we have a set of related constants that we want to group together.
    -> Enums are declared using the enum keyword.
    -> Enums improves code readability, maintainability and type safety.

    E.G: 
    Order processing system with different order statuses.
    -> Enums can be used to represent a set of related constants.
     enum OrderStatus
    {
        Pending =1,
        Processing =2,
        Shipped =3,
        Delivered =4,
        Cancelled=5
     }

     Use Cases of Enums: 
     -> Representing a days in a week, months in a year, order status, user roles, etc.

     //use enums 
     OrderStatus status = OrderStatus.Pending;
     Console.WriteLine(status); // Output: Pending



**/
public enum StatusCode
{
    Success = 200,
    Created = 201,
    Accepted = 202,
    NoContent = 204,
    BadRequest = 400,
    Unauthorized = 401,
    Forbidden = 403,
    NotFound = 404,
    InternalServerError = 500
}

class Program{
    public static void Main(string[] args)
    {
        //Create an instance of the enum
        StatusCode status = StatusCode.Success;
        //Print the enum value
        Console.WriteLine($"Status Code: {(int)status} - {status}");

        //check if the status code is defined in the enum
        if (Enum.IsDefined(typeof(StatusCode), status))
        {
            Console.WriteLine("The status code is defined in the enum.");
        }
        else
        {
            Console.WriteLine("The status code is not defined in the enum.");
        }

        //generics objects 
        Box<int> intBox = new Box<int>(10);
        intBox.DisplayValue(); // Output: Value: 10, Type: System.Int32
        Box<string> stringBox = new Box<string>("Hello Generics!");
        stringBox.DisplayValue(); // Output: Value: Hello Generics!, Type: System.String
        Box<StatusCode> enumBox = new Box<StatusCode>(StatusCode.Success);
        enumBox.DisplayValue(); // Output: Value: Success, Type: EnumGenerics.StatusCode
        // Create a list of generic type Box
        List<Box<int>> intBoxes = new List<Box<int>>()
        {
            new Box<int>(1),
            new Box<int>(2),
            new Box<int>(3)
        };
        // Display the values in the list of boxes
        foreach (var box in intBoxes)
        {
            box.DisplayValue(); // Output: Value: 1, Type: System.Int32, etc.
        }

        // Create a list of generic type Box with string values
        List<Box<string>> stringBoxes = new List<Box<string>>()
        {
            new Box<string>("One"),
            new Box<string>("Two"),
            new Box<string>("Three")
        };
        // Display the values in the list of boxes
        foreach (var box in stringBoxes)
        {
            box.DisplayValue(); // Output: Value: One, Type: System.String, etc.
        }

        //Generic Methods 

    }

}

