namespace Decorator
{

    // Base Decorator
    public abstract class NotificationDecorator : INotificationService
    {
        protected readonly INotificationService _notificationService;

        protected NotificationDecorator(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public abstract void Send(string message);
    }
}
