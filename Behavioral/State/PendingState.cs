namespace State
{
    public class PendingState : IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine("Payment successful.");
            order.SetState(new PaidState());
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Cannot ship the order. Payment is pending.");
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Order canceled.");
            //order.SetState(new CanceledState());
        }
    }
}
