namespace Mediator
{
    public class OrderService
    {
        private readonly IApplicationMediator _mediator;
        public OrderService(IApplicationMediator mediator)
        {
            _mediator = mediator;
        }

        public void CreateOrder()
        {
            Console.WriteLine("OrderService: Creating order...");
            _mediator.SendOrderNotification();
        }
    }
}
