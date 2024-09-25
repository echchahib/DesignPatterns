using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NotificationSender
{
    public enum SenderType
    {
        Email = 1,
        Sms = 2,
        PushNotification = 3,
    }
}
