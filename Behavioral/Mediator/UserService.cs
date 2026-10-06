namespace Mediator
{
    public class UserService
    {
        private readonly IApplicationMediator _mediator;

        public UserService(IApplicationMediator mediator)
        {
            _mediator = mediator;
        }

        public void CreateOrder()
        {
            Console.WriteLine("UserService: Creating order...");
            _mediator.CreateOrder();
        }

        public void NotifyPaymentCompleted()
        {
            // Terminal notification step: do not call mediator again,
            // otherwise this loops back into ApplicationMediator.NotifyUserPaymentCompleted().
            Console.WriteLine("User notified: Payment completed.");
        }
    }
}