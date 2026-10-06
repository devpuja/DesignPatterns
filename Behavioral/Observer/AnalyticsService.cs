namespace Observer
{
    internal class AnalyticsService : IOrderObserver
    {
        public void OrderPlaced(int orderId)
        {
            Console.WriteLine($"Analytics updated for order {orderId}");
        }
    }
}
