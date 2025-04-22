namespace BankAccountType
{
    //Interface: C# support Interface to solve the problem of Multiple inheritance

    public interface IOnlineBanking
    {
        //interface properties and method donot have body and the class calling interface should have all the implementation of methods 

        void PayUtilityBill (double amount);
    }
}