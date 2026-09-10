using Builder;
using System.Runtime.InteropServices;

var playerDirector = new PlayerDirector();
Player? player;

if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    player = playerDirector.BuildPlayer(new WindowsPlayerBuilder());
}
else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
{
    player = playerDirector.BuildPlayer(new LinuxPlayerBuilder());
}
else
{
    throw new PlatformNotSupportedException("Unsupported platform");
}


Console.WriteLine("Enter the path to the audio file:");
var filePath = Console.ReadLine()??string.Empty;
player?.PlayButton?.Play(filePath);

Console.WriteLine("Playing audio. Type 'stop' to stop it or 'exit' to exit the application.");

while (true)
{
    var command = Console.ReadLine()?.ToLower();
    if (command == "stop")
    {
        player?.StopButton?.Stop(filePath);
        Console.WriteLine("Playback stopped.");
    }
    else if (command == "exit")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown command. Type 'stop' to stop playback or 'exit' to exit the application.");
    }
}

Console.WriteLine("Press any key to stop playback...");
Console.ReadKey();