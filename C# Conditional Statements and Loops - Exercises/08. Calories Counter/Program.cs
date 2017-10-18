using System;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int Totalkcal = 0;

            for (int i = 0; i < total; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        Totalkcal += 500; break;
                    case "tomato sauce":
                        Totalkcal += 150; break;
                    case "salami":
                        Totalkcal += 600; break;
                    case "pepper":
                        Totalkcal += 50; break;
                }
            }
            Console.WriteLine($"Total calories: {Totalkcal}");
        }
    }
}