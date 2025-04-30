//Lab 6: Title Understanding Interfaces in C# Build a simple Notification System
//Lab Objective: 
// 1. Define an interface with properties and methods
// 2. Implement the interface in a class
// 3. Create a list of objects that implement the interface
// 4. Use interface polymorphism to call methods on the objects in the list
// 5. To implement multiple intheritance using interface


/*
    Interface Definition:
    - Interface is a concept in C# that defines set of methods and properties that a class must implement.
    - It specifies what a class can do, but not how it does it.
    - Interfaces are used to achieve abstraction and multiple inheritance in C#.
    - Interface supports loose coupling, which means that the code is more flexible and easier to maintain.
    - Interface donot have any implementation, only the signature of methods and properties.[It doesnot have body]

*/

/*
   Characteristics of Interface:
   - An interface can contain methods, properties, events, and indexers.
   - Declared using the keyword "interface".
   - Methoths and properties in interface are implicitly public and abstract.
    - Cannot contain fields, constructors, destructors, or static members.
    -A class or struct that implements an interface must implement all its members.   
 */

 /**
    Building a simple notification system using interfaces.
    Let's make two classes EmailNotification and SMSNotification that implement the INotification interface.
 **/

using System;

//interface definition
public interface INotification
{
    void send(string message); // method to send notification
}

//multiple interface inheritance 
public interface INotificationWithPriority : INotification
{
    int Priority { get; set; } // property to set notification priority
}

//class implementing the interface


class EmailNotification : INotification,INotificationWithPriority
{
    public int Priority { get; set; } // property implementation
    public EmailNotification()
    {
        Priority = 1; // default priority
    }
    public void send(string message)
    {
        Console.WriteLine("Email Notification: " + message);
    }
}

class SMSNotification : INotification, INotificationWithPriority
{
    public int Priority { get; set; } // property implementation
    public SMSNotification()
    {
        Priority = 2; // default priority
    }


    public void send(string message)
    {
        Console.WriteLine("SMS Notification: " + message);
    }
}

class Program
{
    //main function 
    public static void Main (string[] args)
    {
        //create an object 
        EmailNotification emailNotification = new EmailNotification();
        SMSNotification smsNotification = new SMSNotification();

        //set priority for notifications
        emailNotification.Priority = 1; // setting priority for email notification
        smsNotification.Priority = 2; // setting priority for SMS notification

        //displaying the priority of notifications
        Console.WriteLine("Email Notification Priority: " + emailNotification.Priority);
        Console.WriteLine("SMS Notification Priority: " + smsNotification.Priority);

        //method to send notification 
        emailNotification.send("Hello, this is an email notification!");
        smsNotification.send("Hello, this is an SMS notification!");


        Console.WriteLine("Using polymorphism to send notifications:");

        //using array to demonistrate polymorphism
        INotification[] notifications = { emailNotification, smsNotification };
        foreach(INotification notification in notifications)
        {
            notification.send("This is a polymorphic notification!");

        }
        
    }
}
