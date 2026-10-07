namespace State
{
    public interface IOrderState
    {
        void Pay(Order order);
        void Cancel(Order order);
        void Ship(Order order);
    }
}