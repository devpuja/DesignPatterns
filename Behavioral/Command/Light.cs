namespace Command
{
    // Receivers
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is Off");
        }
    }


    public class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is On");
        }
        public void TurnOff()
        {
            Console.WriteLine("Fan is Off");
        }
    }
}
