namespace Command
{
    // Concrete Commands

    public class TurnOnLightCommand : ICommand
    {
        private readonly Light light;

        public TurnOnLightCommand(Light _light)
        {
            light = _light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }

    public class TurnOnFanCommand : ICommand
    {
        private readonly Fan fan;
        public TurnOnFanCommand(Fan _fan)
        {
            fan = _fan;
        }
        public void Execute()
        {
            // This is the action that the command performs
            fan.TurnOn();
        }
    }
}
