namespace Bridge
{
    internal class RemoteControl
    {
        //Bridge pattern is used to decouple the abstraction from its implementation so that the two can vary independently.
        protected readonly IDevice _device;
        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
