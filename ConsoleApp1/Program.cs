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

        public void Feed()
        {
            Hunger = Math.Max(0, Hunger - 2);
            Happiness = Math.Min(10, Happiness + 1);
            Console.WriteLine("You feed {0}. Hunger decreases.", Name);
        }
        public void Play()
        {
            Happiness = Math.Min(10, Happiness + 2);
            Hunger = Math.Min(10, Hunger + 1);
            Console.WriteLine("You play with {0}. Happiness increases.", Name);
        }

        public void Rest()
        {
            Health = Math.Min(10, Health + 2);
            Happiness = Math.Max(0, Happiness - 1);
            Console.WriteLine("You let {0} rest. Health improves.", Name);
        }

        public void CheckStatus()
        {
            Console.WriteLine("status:", Name);
            Console.WriteLine("• Hunger: {0}", Hunger);
            Console.WriteLine("• Happiness: {0}", Happiness);
            Console.WriteLine("• Health: {0}", Health);
        }
    }

}