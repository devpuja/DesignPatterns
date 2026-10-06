namespace Observer
{
    public class OrderService
    {
        private readonly List<IOrderObserver> _observers = new();
        public void Subscribe(IOrderObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IOrderObserver observer)
        {
            _observers.Remove(observer);
        }

        public void PlaceOrder(int orderId)
        {
            Console.WriteLine($"Order {orderId} placed.");
            NotifyObservers(orderId);
        }

        private void NotifyObservers(int orderId)
        {
            foreach (var observer in _observers)
            {
                observer.OrderPlaced(orderId);
            }
        }
    }
}
