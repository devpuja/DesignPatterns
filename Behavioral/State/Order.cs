namespace State
{
    public class Order
    {
        private IOrderState _state;

        public Order(IOrderState state)
        {
            _state = state;
        }

        public void SetState(IOrderState state)
        {
            _state = state;
        }

        public void Pay()
        {
            _state.Pay(this);
        }

        public void Ship()
        {
            _state.Ship(this);
        }

        public void Cancel()
        {
            _state.Cancel(this);
        }
    }
}