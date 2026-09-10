namespace Builder
{
    internal class WindowsPlayerBuilder : IPlayerBuilder
    {
        private readonly Player _player = new();
        public void AddPlayButton()
        {
            _player.PlayButton = new WindowsPlayButton();
        }
        public void StopPlayButton()
        {
            _player.StopButton = new WindowsStopButton();
        }
        public Player BuildPlayer()
        {
            return _player;
        }
    }
}
