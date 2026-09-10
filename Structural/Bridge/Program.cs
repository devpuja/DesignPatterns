using Bridge;

// Advanced Remote + TV 
IDevice deviceTV = new TV();

var advancedTVRemote = new AdvancedRemoteControl(deviceTV);
advancedTVRemote.TurnOn();
advancedTVRemote.SetVolume(30);
advancedTVRemote.Mute();
advancedTVRemote.UnMute();
advancedTVRemote.TurnOff();

Console.WriteLine("\n====================\n");
// Advanced Remote + Radio 
IDevice deviceRadio = new Radio();

var advancedRadioRemote = new AdvancedRemoteControl(deviceRadio);
advancedRadioRemote.TurnOn();
advancedRadioRemote.SetVolume(20);
advancedRadioRemote.Mute();
advancedRadioRemote.UnMute();
advancedRadioRemote.TurnOff();