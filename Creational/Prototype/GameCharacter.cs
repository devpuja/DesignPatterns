using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    internal class GameCharacter
    {
        public string? Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public List<string>? Weapons { get; set; }

        public GameCharacter Clone()
        {
            return new GameCharacter
            {
                Name = Name,
                Level = Level,
                Health = Health,
                Weapons = Weapons != null ? new List<string>(Weapons) : null
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}, Level: {Level}, Health: {Health}, Weapons: {string.Join(", ", Weapons ?? new List<string>())}";
        }
    }
}
