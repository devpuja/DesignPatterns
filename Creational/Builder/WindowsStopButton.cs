using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class WindowsStopButton : StopButton
    {
        public override void Stop(string fileName)
        {
            WindowsPlayerUtility.ExecuteMciCommand($"Stop MediaFile");
        }
    }
}
