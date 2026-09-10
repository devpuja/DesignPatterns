using Decorator;

INotificationService notification = new EmailNotification();

notification = new LoggingDecorator(notification);
notification = new EncryptionDecorator(notification);

notification.Send("Order Shipped Successfully.");