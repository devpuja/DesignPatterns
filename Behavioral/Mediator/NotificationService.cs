namespace Mediator
{
    public class NotificationService
    {
        private readonly IApplicationMediator _mediator;
        public NotificationService(IApplicationMediator mediator)
        {
            _mediator = mediator;
        }

        public void SendOrderCreatedNotification()
        {
            Console.WriteLine("Order notification sent.");
            _mediator.ProcessPayment();
        }
    }
}
