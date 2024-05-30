using System;

namespace VirtualPet
{
    class Pet
    {
        public string Name { get; }
        public string Type { get; }
        public int Hunger { get; private set; }
        public int Happiness { get; private set; }
        public int Health { get; private set; }

        public Pet(string name, string type)
        {
            Name = name;
            Type = type;
            Hunger = 5;
            Happiness = 5;
            Health = 10;
        }
    }
}
