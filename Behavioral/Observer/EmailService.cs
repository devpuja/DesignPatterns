namespace Observer
{
    public class EmailService : IOrderObserver
    {
        public void OrderPlaced(int orderId)
        {
            Console.WriteLine($"Email sent for order {orderId}");
        }
    }
}
