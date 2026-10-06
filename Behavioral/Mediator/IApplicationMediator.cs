namespace Mediator
{
    public interface IApplicationMediator
    {
        void CreateOrder();
        void ProcessPayment();
        void SendOrderNotification();
        void NotifyUserPaymentCompleted();
    }
}