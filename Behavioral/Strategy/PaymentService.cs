namespace Strategy
{
    public class PaymentService
    {
        private readonly IPaymentStrategy paymentStrategy;
        public PaymentService(IPaymentStrategy _paymentStrategy)
        {
            paymentStrategy = _paymentStrategy;
        }

        public void MakePayment(decimal amount)
        {
            paymentStrategy.Pay(amount);
        }
    }
}
