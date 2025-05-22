using System; 

namespace DeligatesAndEvents
{
    class Program
    {
        public static void Main(string[] args)
        {
            //create notifier and subscriber 
            Notifier notifier = new Notifier();
            EmailSubscriber email = new EmailSubscriber(); 
            SMSSubscriber sms = new SMSSubscriber(); 


            //Subscribe methods to an event 
            notifier.OnNotify += email.OnNotifyReceived; 
            notifier.OnNotify += sms.OnNotifyReceived;

            //trigger notificaiton 
            notifier.TriggerNotification("Your transaction for $1000 has been subscribed sucessfully");

            //Unsubscribing 

            notifier.OnNotify -= sms.OnNotifyReceived; 

            //trigger 

            notifier.TriggerNotification("Your account balance is low.");

        }
    }
}