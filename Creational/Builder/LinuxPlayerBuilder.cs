using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class LinuxPlayerBuilder : IPlayerBuilder 
    {
        private readonly Player _player = new();
        public void AddPlayButton()
        {
            _player.PlayButton = new LinuxPlayButton();
        }
        public void StopPlayButton()
        {
            _player.StopButton = new LinuxStopButton();
        }
        public Player BuildPlayer()
        {
            return _player;
        }
    }
}
