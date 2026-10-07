namespace State
{
    public class ShippedState : IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine("Order is already paid.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Order is already shipped.");
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Cannot cancel the order. It is already shipped.");
        }
    }
}
