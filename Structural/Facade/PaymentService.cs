namespace Facade
{

    public interface IPaymentService
    {
        void ProcessPayment(string orderId, decimal amount);

    }

    public class PaymentService : IPaymentService
    {
        public void ProcessPayment(string orderId, decimal amount)
        {
            Console.WriteLine($"Processed payment of ${amount:N2} for order {orderId}.");
        }
    }
}



