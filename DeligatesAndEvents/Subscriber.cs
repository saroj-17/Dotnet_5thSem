 using System; 

 namespace DeligatesAndEvents
 {
    public class EmailSubscriber
    {
        public void OnNotifyReceived(string message)
        {
            Console.WriteLine($"Email Received : {message}");
        }

    }

    public class SMSSubscriber
    {
         public void OnNotifyReceived(string message)
        {
            Console.WriteLine($"SMS Received : {message}");
        }
    }
 }