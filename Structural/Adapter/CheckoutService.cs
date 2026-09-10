namespace Adapter
{
    internal class CheckoutService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public CheckoutService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
