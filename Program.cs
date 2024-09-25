
using DesignPatterns.Factory.NotificationSender;

SenderFactory sender = new SenderFactory();

INotificationSender email = sender.CreateNotificationSender("Hello ChatGPT, Thanks for helping me.",SenderType.Email);
email.Send();


INotificationSender sms = sender.CreateNotificationSender("Hi mom, i will go back home at 10 pm o'clock, have a nice day.", SenderType.Sms);
sms.Send();


INotificationSender notificationSender = sender.CreateNotificationSender("Low Battry, You have to put your phone in charge.", SenderType.PushNotification);
notificationSender.Send();