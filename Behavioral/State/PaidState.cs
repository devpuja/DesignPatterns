namespace State
{
    public class PaidState : IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine("Order is already paid.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Order shipped.");
            order.SetState(new ShippedState());
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Cannot cancel the order. Payment is already made.");
        }
    }
}