namespace Bridge
{
    internal class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void SetVolume(int volume)
        {
            _device.SetVolume(volume);
        }

        public void Mute()
        {
            _device.SetVolume(0);

        }

        public void UnMute()
        {
            _device.SetVolume(50);
        }

    }
}
