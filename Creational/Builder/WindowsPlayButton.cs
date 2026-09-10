using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class WindowsPlayButton : PlayButton
    {
        public override void Play(string fileName)
        {
            Console.WriteLine("Playing audio via the following command: WINDOWS");
            Console.WriteLine($"mpg123 -q '{fileName}'");
            WindowsPlayerUtility.ExecuteMciCommand($"open \"{fileName}\" type mpegvideo alias MediaFile");
        }
    }
}
