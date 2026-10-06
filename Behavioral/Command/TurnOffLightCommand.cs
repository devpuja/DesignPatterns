namespace Command
{
    // Concrete Commands

    public class TurnOffLightCommand : ICommand
    {
        private readonly Light light;
        public TurnOffLightCommand(Light _light)
        {
            light = _light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }

    public class TurnOffFanCommand : ICommand
    {
        private readonly Fan fan;
        public TurnOffFanCommand(Fan _fan)
        {
            fan = _fan;
        }
        public void Execute()
        {
            // This is the action that the command performs
            fan.TurnOff();
        }
    }
}
