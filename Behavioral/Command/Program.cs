using Command;


// This is client code which is using the command pattern to turn on and off the light and fan.

// E.g of Light class
Light light = new ();

TurnOnLightCommand turnOn = new (light);
TurnOffLightCommand turnOff = new (light);

RemoteControl remote = new ();
remote.SetCommand(turnOn);
remote.PressButton();

remote.SetCommand(turnOff);
remote.PressButton();


// E.g of Fan class
Fan fan = new();

TurnOnFanCommand turnOnFan = new (fan);
TurnOffFanCommand turnOffFan = new (fan);

RemoteControl remoteFan = new();
remoteFan.SetCommand (turnOnFan);
remoteFan.PressButton();

remoteFan.SetCommand(turnOffFan);
remoteFan.PressButton();