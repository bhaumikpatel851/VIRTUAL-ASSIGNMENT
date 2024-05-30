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
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Please choose a type of pet:");
                Console.WriteLine("1. Cat");
                Console.WriteLine("2. Dog");
                Console.WriteLine("3. Rabbit");
                int choice = Convert.ToInt32(Console.ReadLine());
                string type = "";
                switch (choice)
                {
                    case 1:
                        type = "Cat";
                        break;
                    case 2:
                        type = "Dog";
                        break;
                    case 3:
                        type = "Rabbit";
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Defaulting to cat.");
                        type = "cat";
                        break;
                }

                Console.WriteLine("What would you like to name your {0}?", type);
                string name = Console.ReadLine();

                Pet pet = new Pet(name, type);
                Console.WriteLine("Welcome, {0}! Let’s take good care of {1}.", name, name);

                int userInput;
                do
                {
                    Console.WriteLine("\nMain menu:");
                    Console.WriteLine("1. Feed {0}", name);
                    Console.WriteLine("2. Play with {0}", name);
                    Console.WriteLine("3. Let {0} rest", name);
                    Console.WriteLine("4. Check {0}’s status", name);
                    Console.WriteLine("5. Exit");
                    Console.Write("User input: ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            pet.Feed();
                            break;
                        case 2:
                            pet.Play();
                            break;
                        case 3:
                            pet.Rest();
                            break;
                        case 4:
                            pet.CheckStatus();
                            break;
                        case 5:
                            Console.WriteLine("Thank you for playing with {0}!", name);
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                } while (userInput != 5);
            }
        }
    }
}
