using FactoryMethod_Demo;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FactoryMethod_Demo
{
    internal class WindowsPlayer : Player
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string command, StringBuilder stringReturn, int returnLength, IntPtr hwndCallback);
        public override Task Play(string fileName)
        {
            Console.WriteLine("Playing audio via the following command:");
            Console.WriteLine($"start wmplayer \"{fileName}\"");

            var sb = new StringBuilder();
            var result = mciSendString($"Play {fileName}", sb, 1024 * 1024, IntPtr.Zero);
            Console.WriteLine(result);
            
            return Task.CompletedTask;
        }


    }
}
