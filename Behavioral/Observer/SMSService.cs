namespace Observer
{
    internal class SMSService : IOrderObserver
    {
        public void OrderPlaced(int orderId)
        {
            Console.WriteLine($"SMS sent for order {orderId}");
        }
    }
}
