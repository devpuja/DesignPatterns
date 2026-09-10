
namespace Decorator
{
    // Concrete Decorator 2
    public class EncryptionDecorator : NotificationDecorator
    {
        public EncryptionDecorator(INotificationService notificationService) : base(notificationService) { }

        public override void Send(string message)
        {
            Console.WriteLine("Encrypting...");
            _notificationService.Send($"Encryption Decorator: {message}");

        }
    }
}
