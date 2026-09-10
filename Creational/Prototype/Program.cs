using Prototype;


var Warrior = new GameCharacter
{
    Name = "Warrior",
    Level = 1,
    Health = 100,
    Weapons = new List<string> { "Sword", "Shield" }
};


var Warrior1 = Warrior.Clone();
Warrior1.Name = "Warrior1";

var Warrior2 = Warrior.Clone();
Warrior2.Name = "Warrior2";
Warrior2.Weapons?.Add("Bow");

var Warrior3 = Warrior.Clone();
Warrior3.Name = "Warrior3";
Warrior3.Weapons?.Add("Axe");
Warrior3.Weapons?.Remove("Sword");


Console.WriteLine(Warrior1.ToString());
Console.WriteLine(Warrior2.ToString());
Console.WriteLine(Warrior3.ToString());