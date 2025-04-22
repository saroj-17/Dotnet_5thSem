/// Class + Interface 
using System;
using System.Xml.Serialization;

namespace BankAccountType
{
    //hybrid account inherits personalAccount, and use Interface
    public class HybridAccount :PersonalAccount, IOnlineBanking
    {
        public HybridAccount(string holder, string accno, double balance, double interestRate, string pan):base(holder, accno, balance, interestRate, pan){

        }

        public void PayUtilityBill(double amount)
        {
            if(amount<=Balance)
            {
                Balance -= amount; 
                Console.WriteLine($"Rs{amount} deducted for utility bill \n New Balance is {Balance}");

            }
            else {
                Console.WriteLine("Insufficient balance");
            }

        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("From Hybrid class");
            base.DisplayAccountInfo();
        }



    }


}