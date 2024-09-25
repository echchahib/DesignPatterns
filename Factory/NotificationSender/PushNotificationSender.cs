using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NotificationSender
{
    public class PushNotificationSender : INotificationSender
    {
        public string DeviceToken { get; set; }
        public string Message { get; set; }

        public PushNotificationSender(string Message) 
        {
            this.Message = Message;
            this.DeviceToken = "UYSmjg0-42FGhZEnxZUY";
        }

        public void Send()
        {
            Console.WriteLine($"The message : '{this.Message}' has showed in this device token : '{this.DeviceToken}'.");
        }
    }
}
