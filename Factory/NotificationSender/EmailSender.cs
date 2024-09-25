using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NotificationSender
{
    public class EmailSender : INotificationSender
    {
        public string EmailAddress { get; set; }
        public string Message { get; set; }
        public string EmailServer { get; set; }

        public EmailSender(string Message) 
        {
            this.Message = Message;
            this.EmailServer = "contact@chatgpt.com";
            this.EmailAddress = "oussama@me.com";
        }


        public void Send()
        {
            Console.WriteLine($"The message : '{this.Message}' sended to : '{this.EmailAddress}' from  : '{this.EmailServer}'.");
        }
    }
}
