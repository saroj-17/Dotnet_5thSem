//hierarchial inheritance 

using System;
using System.Security.AccessControl;

namespace BankAccountType
{
    //make saving account a child of BankAccount(Hierarchial Inheritance)
    public class SavingAccount : BankAccount
    {
        public double InterestRate{get; set;}

        public SavingAccount(string holder, string accno, double balance, double interestRate) : base(holder, accno, balance)
        {
            this.InterestRate = interestRate; 

        }

        public void AddedInterest()
        {
            double interest = Balance* InterestRate/100;
            Deposit(interest);
        }

        //override 
        public override void Withdraw(double amount)
        {
            if(amount<=Balance)
            {
                Balance -= amount; 
                Console.WriteLine($"Rs{amount} is withdrawn from {AccountHolderName} Accounts.\n Now the balance is {Balance}");
            }

            else{
                Console.WriteLine("Insufficient Balance");
            }
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
        }

        



    }


}
