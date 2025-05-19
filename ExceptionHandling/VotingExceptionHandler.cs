using System; 
using System.IO;
//custom exception example for voting eligibility

namespace ExceptionHandlingExample{
    public static class VotingExceptionHandler{
        public static void HandleVotingException(){
            try{
                //code that may throw an exception
                int age = 15;
                if(age < 18){
                    throw new InvalidOperationException("You must be at least 18 years old to vote.");
                }
                Console.WriteLine("You are eligible to vote.");
            }
            catch(InvalidOperationException ex){
                //handle the exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally{
                Console.WriteLine("Voting eligibility check completed.");
            }
        }
    }
}