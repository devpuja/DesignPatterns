using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class LinuxStopButton : StopButton
    {
        public override void Stop(string fileName)
        {
            if (LinuxPlayerUtility.PlayBackProcess != null)
            {
                LinuxPlayerUtility.PlayBackProcess.Kill();
                LinuxPlayerUtility.PlayBackProcess.Dispose();
                LinuxPlayerUtility.PlayBackProcess = null;
            }
            else
            {
                Console.WriteLine("No active playback process found.");
            }
        }
    }
}
