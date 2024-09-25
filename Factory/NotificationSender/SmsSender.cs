using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NotificationSender
{
    public class SmsSender : INotificationSender
    {
        public string Number { get; set; }
        public string Message { get; set; }
        public string SmsGetway { get; set; }

        public SmsSender(string Message) 
        {
            this.Message = Message;
            this.Number = "0630300300";
            this.SmsGetway = "0638976942";
        }
        public void Send()
        {
            Console.WriteLine($"The message : '{this.Message}' sended to : '{this.Number}' from : '{this.SmsGetway}'.");
        }
    }
}
