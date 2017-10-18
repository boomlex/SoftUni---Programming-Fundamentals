using System;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: " + "|" + new string('|', currentHealth) + new string('.', health - currentHealth) + "|");
            Console.WriteLine("Energy: " + "|" + new string('|', currentEnergy) + new string('.', energy - currentEnergy) + "|");
        }
    }
}