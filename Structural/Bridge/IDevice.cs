namespace Bridge
{
    internal interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetVolume(int volume);
    }
}
