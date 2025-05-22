using System; 

namespace  DeligatesAndEvents
{
    //delegate declaration 
    public delegate void NotifyHandler(string message);

    public class Notifier
    {
        //declare an event using delegates  
        public event NotifyHandler OnNotify; 

        //method to trigger events 
        public void TriggerNotification(string msg)
        {
            Console.WriteLine("Notifier: Sending Notification..");
            OnNotify?.Invoke(msg);
        }

    }
    
}