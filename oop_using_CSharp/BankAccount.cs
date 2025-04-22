/**
    - Classes are blueprint to create an object. 
    - Class is the colleciton of data members(properties) and it's member function(methods) 
    - Classes are used to represent real world entities with different behaviors 
    - Objects are the instances of classes. Objects of a class follow similar behaviours 
**/

using System;
using System.Runtime.InteropServices.Marshalling;


namespace BankAccountType
{

    //abstrace base class with encaptulation 
    public abstract class BankAccount{
        //properties 

        private string accountNumber{get; set;}

        private string accountHolderName{ get; set; }

        private double balance{get; set; }


        //Propertites encaptulation 
        public string AccountHolderName
        {
            get{ return accountHolderName;}
            set {accountHolderName = value;}

        }

        public string AccountNumber
        {
            get { return accountNumber;}
            set{accountNumber = value;}

        }

        public double Balance
        {
            get{return balance;}
            set{balance = value;}
        }

        //constructor 
        public BankAccount(string holder, string accno, double balance)
        {
            this.AccountHolderName = holder; 
            this.AccountNumber = accno; 
            this.Balance = balance; 

        }


        //methods 
        public void Deposit(double amount)
        {
            if(amount <=0)
            {
                Console.WriteLine("Amount cannot be less than 0"); 
            }
            else{
                balance = balance+amount; 
                Console.WriteLine($"{amount} is deposited to {accountNumber} Account");
            }
        }

        //display account information to overriding(polymorphism)
        //virtual Method in C# is a method that can be overridden in a derived class.
        //It is used to achieve runtime polymorphism.
        //It is declared using the virtual keyword in the base class and the override keyword in the derived class.
        //Polymorphism is a process of using the same method name with different implementations.

        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"[BankAccount] Holder : {AccountHolderName}, Number : {AccountNumber}, Balance: {Balance}");
        }

        //abstract method (no body)
        //abstract method is a method that does not have any implementation in the base class.
        //It is declared using the abstract keyword in the base class and must be overridden in the derived class.
        //It is used to achieve abstraction in C#.
        //Abstraction is a process of hiding the implementation details and showing only the essential features of the object.
        public abstract void Withdraw(double amount); 


        // public void Display()
        // {
        //     Console.WriteLine($"Account Number: {accountNumber}");
        //     Console.WriteLine($"Account Holder Name: {accountHolderName}");
        //     Console.WriteLine($"Account balance: {balance}");
          
        // }

       //constructors 
       /**
        - Constructor is a special method of a class that is called when an object of the class is created. 
        - It is used to initialize the data members of the class. 
        - It has the same name as the class and does not have any return type. 
        - It can be parameterized or default constructor. 
        - Default constructor is a constructor that does not take any parameters. 
        - Parameterized constructor is a constructor that takes parameters.
       **/

       //default Constructor 

    //    public BankAccount()
    //    {
    //         accountNumber = "RBB123456"; 
    //         accountHolderName = "Ram Prashad Yadav"; 
    //         balance = 1000; 

    //    }

       //destructor
       //Destructor is a special method of a class that is called when an object of the class is destroyed.
       //It is used to clean up the resources used by the object.
       //It has the same name as the class and is preceded by a tilde (~) symbol.
       //It does not take any parameters and does not have any return type.

    //    ~BankAccount(){
    //         Console.WriteLine("Destructor is called"); 
    //         //clean up resources used by the object
    //         accountNumber = null; 
    //         accountHolderName = null; 
    //         balance = 0;
    //         Console.WriteLine("Resources are cleaned up");
    //    }
       //destructor is rearelly used in C# because of garbage collection.
       //Garbage collection is a process of automatically freeing up memory that is no longer in use by the program.

         //parameterized constructor
        //  public BankAccount(string accNum, string accHolderName, double bal)
        //  {
        //     this.accountNumber = accNum; 
        //     this.accountHolderName = accHolderName; 
        //     this.balance = bal; 

        //  }

       /**
       Obj
       BankAccount acc1 = new BankAccount("10223", "Ram Prashad Yadav", 10000);
       acc1.accountNumber = "RBB123579";
        

       **/

       //Inheritance
       //Inheritance is a process of acquiring the properties and methods of another class.
       //It is used to achieve reusability of code and to create a hierarchical relationship between classes.
         //In C#, inheritance is achieved using the colon (:) symbol.
         //The class that is inherited is called the base class or parent class and the class that inherits is called the derived class or child class.

         //Types of inheritance in C#:
            //1. Single Inheritance: A class inherits from a single base class.
            //2. Multiple Inheritance: A class inherits from multiple base classes. (Not supported in C#)
            //3. Multilevel Inheritance: A class inherits from a base class and the derived class can be inherited by another class.
            //4. Hierarchical Inheritance: Multiple classes inherit from a single base class.
            //5. Hybrid Inheritance: A combination of two or more types of inheritance.
     

     //single inheritance 
       

        //multilevel Inheritance 
       

        //hirerchial inheritance 

        // public class CurrentAccount: BankAccount
        // {
        //     CurrentAccount()=> Console.WriteLine("From current Account");
        // }









}
    
}
