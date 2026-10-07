namespace Strategy
{
    public class UpiStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using UPI.");
        }
    }
}
