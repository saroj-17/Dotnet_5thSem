using BankAccountType;
using Microsoft.Win32.SafeHandles;

namespace Oop_usingCsharp; 
 
//  To understand classes and objects in C#

//Classes is a blueprint for creating objects
//Objects are instances of classes

//BankAccount class
//This class represents a bank account with properties and methods to manage the account balance.
class Program{
    public static void Main(string[] args)
{
    // // //Creating an object of BankAccount class and default constructor is called
    // // BankAccount acc1 = new BankAccount(); 
    // // // acc1.accountNumber = "RBB123579";
    // // // acc1.accountHolderName = "Ram Prashad Yadav"; 
    // // // acc1.balance= 10000; 

    // // acc1.Deposit(5000);
    // // acc1.Withdraw(2000);
   
    // // acc1.Display(); 

    // // //Creating another object of BankAccount class and parameterized constructor is called
    // // BankAccount acc2 = new BankAccount("RBB123456", "Sita Devi", 20000);
    // // acc2.Deposit(10000);
    // // acc2.Withdraw(5000);

    // // acc2.Display();

    // SavingAccount s = new SavingAccount();

    Console.WriteLine("=== Single Inheritance ===");
    CurrentAccount current = new CurrentAccount("Jeevan", "ASD123456", 10000, 2000);
    current.Deposit(10000);
    current.DisplayAccountInfo(); 
    current.Withdraw(2000); 
    current.DisplayAccountInfo();


    Console.WriteLine("=== Hierarchial Inheritance ==="); 
    SavingAccount savingAccount = new SavingAccount("Bijaya", "ASD234567", 20000, 5); 
    savingAccount.Deposit(1000); 
    savingAccount.DisplayAccountInfo(); 
    savingAccount.Withdraw(10000); 
    savingAccount.DisplayAccountInfo(); 






}

}
