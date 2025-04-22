//Multilevel inheritance 
/*
    BankAccount -> Saving Account-> Personal Account 
*/

namespace BankAccountType
{
    public class PersonalAccount : SavingAccount
    {
        public string PAN {get; set;}

        public PersonalAccount(string holder, string accno,double interestRate, double balance, string pan):base(holder, accno, balance, interestRate)
        {
            this.PAN = pan; 
        }

        //override display 

        public override void DisplayAccountInfo()
        {
           Console.WriteLine($"AccountHolder Name: {AccountHolderName} \n Account No: {AccountNumber} \n PAN no:{PAN} \n Balance: {Balance}");
        }

    }


}





