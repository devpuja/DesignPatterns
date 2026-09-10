
namespace Decorator
{
    // Concrete Decorator 1
    public class LoggingDecorator: NotificationDecorator
    {
        public LoggingDecorator(INotificationService notificationService) : base(notificationService) { }

        public override void Send(string message)
        {
            Console.WriteLine("Logging...");
            _notificationService.Send($"Logging Decorator: {message}");
        }
    }
}
