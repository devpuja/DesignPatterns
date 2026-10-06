namespace Mediator
{
    public class ApplicationMediator : IApplicationMediator
    {
        private readonly UserService _userService;
        private readonly OrderService _orderService;
        private readonly PaymentService _paymentService;
        private readonly NotificationService _notificationService;

        public ApplicationMediator()
        {
            _userService = new UserService(this);
            _orderService = new OrderService(this);
            _paymentService = new PaymentService(this);
            _notificationService = new NotificationService(this);
        }

        public void CreateOrder()
        {
            _orderService.CreateOrder();
        }

        public void SendOrderNotification()
        {
            _notificationService.SendOrderCreatedNotification();
        }

        public void ProcessPayment()
        {
            _paymentService.ProcessPayment();
        }

        public void NotifyUserPaymentCompleted()
        {
            _userService.NotifyPaymentCompleted();
        }

        public void Start()
        {
            _userService.CreateOrder();
        }
    }
}
