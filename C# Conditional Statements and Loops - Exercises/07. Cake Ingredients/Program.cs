using System;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cake = Console.ReadLine();
            int IngredientsCounter = 0;

            while (Cake != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {Cake}.");
                Cake = Console.ReadLine();
                IngredientsCounter++;
            }
            Console.WriteLine($"Preparing cake with {IngredientsCounter} ingredients.");
        }
    }
}