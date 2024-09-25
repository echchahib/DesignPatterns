using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NotificationSender
{
    public class SenderFactory
    {
        public SenderFactory() {}

        public INotificationSender CreateNotificationSender(string message, SenderType senderType)
        {
            //if (senderType == SenderType.Email)
            //    return new EmailSender(message);
            //else if (senderType == SenderType.Sms)
            //    return new SmsSender(message);
            //else if (senderType == SenderType.PushNotification)
            //    return new PushNotificationSender(message);
            //else
            //    throw new Exception("There is no available sender !!");

            return senderType switch
            {
                SenderType.Email => new EmailSender(message),
                SenderType.Sms => new SmsSender(message),
                SenderType.PushNotification => new PushNotificationSender(message),
                _ => throw new ArgumentException("Invalid sender type provided.")
            };
        }
    }
}
