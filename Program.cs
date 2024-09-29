
using DesignPatterns.Factory.NotificationSender;
using DesignPatterns.Observer.Temperature;
// Factory
//SenderFactory sender = new SenderFactory();
//INotificationSender email = sender.CreateNotificationSender("Hello ChatGPT, Thanks for helping me.",SenderType.Email);
//email.Send();
//INotificationSender sms = sender.CreateNotificationSender("Hi mom, i will go back home at 10 pm o'clock, have a nice day.", SenderType.Sms);
//sms.Send();
//INotificationSender notificationSender = sender.CreateNotificationSender("Low Battry, You have to put your phone in charge.", SenderType.PushNotification);
//notificationSender.Send();

Temperature temperature = new Temperature(33.309990, 34.090077, "Casablanca", 26);

Device Iphone = new Device(39877265642563, "Oussama's Iphone", TypeDevice.PhoneApp);
Device Mac = new Device(39877265642563, "Oussama's Mac", TypeDevice.DesktopWidget);
Device PC = new Device(39877265642563, "Oussama's Laptop", TypeDevice.DesktopWidget);
Device HomeScreen = new Device(39877265642563, "ECHCHAHIB's Home screen", TypeDevice.DigitalSignboard);

temperature.Subscribe(Iphone);
temperature.Subscribe(Mac);
temperature.Subscribe(PC);
temperature.Subscribe(HomeScreen);

// Update the temperature to 30
temperature.Value = 30;

// Familly ECHCHAHIB shutdown their HomeScreen
temperature.Unsubscribe(HomeScreen);

// The temperature has changed
temperature.Value = 27;

Random random = new Random(); // Use a random generator without a fixed seed

// Create a thread that updates the temperature every 5 seconds
Thread thread = new Thread(() =>
{
    while (true)
    {
        // Generate a new random temperature within a reasonable range (e.g., 15°C to 40°C)
        int value = random.Next(15, 40);

        // Update the temperature
        temperature.Value = value;

        // Wait 5 seconds before the next update
        Thread.Sleep(5000);
    }
});

// Start the thread
thread.Start();
