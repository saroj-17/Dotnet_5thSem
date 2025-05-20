/**

Linq in C#: 
 - Linq is known as Language Integrated Query
 - Linq is a set of methods that allow you to query collections(arrays, lists, or databases) in C#
 - Linq is a part of the .NET framework
- Linq is a powerful feature of C# that allows you to write queries in a declarative way

Advantages of using Linq:
- Linq is type-safe
- Linq is easy to read and write
- Linq is easy to maintain
- Linq is easy to debug
- Linq is easy to use
- Linq is easy to learn
- Linq is easy to understand
- Linq is easy to use with other .NET features

Imp: 
Types of Linq:
- Linq to Objects: Query that operates on in-memory collections like arrays, lists, etc.
- Linq to SQL: Query that operates on SQL databases
- Linq to XML: Query that operates on XML documents
- Linq to Entities: EF core data structure (Entity Framework)


--Syntax of linq 
var result = from item in collection
             where condition
             select item;

or we can use method syntax
var result = collection.Where(condition)
                       .Select(item => item);
**/

using System;
using System.IO;
//we should import linq 
using System.Linq;
using System.Collections.Generic;


class Program
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string city { get; set; }
    }
    static void Main(string[] args)
    {
        //linq to Objects 
        //sample list of integers 
        //collection is list for now
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //linq 
        var evenNumbers = from number in numbers
                          where number % 2 == 0
                          select number;
        //or we can use method syntax
        var evenNumbersMethodSyntax = numbers.Where(number => number % 2 == 0);
        //print the result
        Console.WriteLine("Even Numbers using Linq:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        //linq to SQL 
        List<Person> people = new List<Person>
        {
            new Person {Name ="Jeevan", Age= 19, city="Bangalore"},
            new Person {Name ="Roshika", Age= 30, city="Delhi"},
            new Person {Name ="Srikrishna", Age= 21, city="Hyderabad"},
            new Person {Name ="Binayak", Age= 25, city="Chennai"},
            new Person {Name ="Sarad", Age= 22, city="Mumbai"},

        };

        //sorting
        //use orderBy
        var sortedPeople = people.OrderBy(person => person.Age);
        Console.WriteLine("Sorted People:");
        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"{person.Name} is {person.Age} years old.");
        }

        //grouping
        //use groupBy
        var groupedPeople = people.GroupBy(person => person.city);
        Console.WriteLine("Grouped People:");
        foreach (var group in groupedPeople)
        {
            Console.WriteLine($"City: {group.Key}");
            foreach (var person in group)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }
        }

        //aggregation
        //use count
        var count = people.Count();
        Console.WriteLine($"Total number of people: {count}");

        //average age 
        var averageAge = people.Average(person => person.Age);
        Console.WriteLine($"Average age of people: {averageAge}");

        //sum of ages
        var sumOfAges = people.Sum(person => person.Age);
        Console.WriteLine($"Sum of ages of people: {sumOfAges}");

        //min age
        var minAge = people.Min(person => person.Age);
        Console.WriteLine($"Minimum age of people: {minAge}");

        //max age
        var maxAge = people.Max(person => person.Age);
        Console.WriteLine($"Maximum age of people: {maxAge}");


        //Linq query 
        var peopleOver20 = from person in people
                           where person.Age > 20
                           select person;

        Console.WriteLine("People over 20 using Linq:");
        foreach (var person in peopleOver20)
        {
            Console.WriteLine($"{person.Name} is {person.Age} years old.");
        }


        //Sorting, grouping and aggregation




    }



    


 }