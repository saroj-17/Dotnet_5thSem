using System; 

namespace BankAccountType
{
    //single inheritance 
    public class CurrentAccount : BankAccount
    {
        public double OverDraftLimit {get; set;}


        public CurrentAccount(string holder, string accno, double balance, double overdraft) : base(holder, accno, balance)
        {
            this.OverDraftLimit = overdraft; 
        }

        //override abstract method 
        public override void Withdraw(double amount)
        {

            if(amount<=Balance+OverDraftLimit)
            {
                Balance -= amount; 
                Console.WriteLine($"Rs{amount} is withdrawn from {AccountNumber}\n The balance is {Balance}");
            }
            else{
                Console.WriteLine("Exceeded overdraft limit"); 
            }
            
        }

        // override virtual method (Polymorphism)

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
        }    
    }
}

