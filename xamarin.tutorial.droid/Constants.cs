using System;
namespace xamarin.tutorial.droid
{
    public class Constants
    {
        public static string NotificationChannelName { get; set; } = "xamarintutorial";
        public static string NotificationHubName { get; set; } = "push";
        public static string ListenConnectionString { get; set; } = "Endpoint=sb://xamarintutorial.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=m+fAsJZU+EJb0NGaN1/lPcFl15ZptswNupxoA6DV4b4=";
    }
}
