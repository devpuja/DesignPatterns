namespace Decorator
{
    public class EmailNotification : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email Notification: {message}");
        }
    }
}
