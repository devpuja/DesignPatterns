using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class LinuxPlayButton : PlayButton
    {
        public override void Play(string fileName)
        {
            Console.WriteLine("Playing audio via the following command: LINUX");
            Console.WriteLine($"mpg123 -q '{fileName}'");
        }
    }
}
