namespace Adapter
{
    public class LegacyPaymentGateway
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} through Legacy Payment Gateway.");
        }
    }
}
