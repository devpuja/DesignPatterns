namespace Command
{
    // This is Invoker

    public class RemoteControl
    {
        private ICommand? command;

        public void SetCommand(ICommand _command)
        {
            command = _command;
        }

        public void PressButton()
        {
            // This is the action that the invoker performs
            command?.Execute();
        }
    }
}