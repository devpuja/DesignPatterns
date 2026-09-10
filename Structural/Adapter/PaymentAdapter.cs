namespace Adapter
{
    internal class PaymentAdapter : IPaymentProcessor
    {
        private readonly LegacyPaymentGateway _legacyPaymentGateway;
        public PaymentAdapter(LegacyPaymentGateway legacyPaymentGateway)
        {
            _legacyPaymentGateway = legacyPaymentGateway;
        }
        public void ProcessPayment(decimal amount)
        {
            _legacyPaymentGateway.MakePayment(amount);
        }
    }
}
