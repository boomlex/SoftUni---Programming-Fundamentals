using System;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());

            int PeshoHealth = 100;
            int GoshoHealth = 100;
            int i = 0;

            while (true)
            {
                i++;
                if (i % 2 != 0)
                {
                    GoshoHealth = GoshoHealth - PeshoDamage;

                    if (GoshoHealth > 0)
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GoshoHealth);
                    }
                    else
                    {
                        break;
                    }
                }
                if (i % 2 == 0)
                {
                    PeshoHealth = PeshoHealth - GoshoDamage;

                    if (PeshoHealth > 0)
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PeshoHealth);
                    }
                    else
                    {
                        break;
                    }
                }
                if (i % 3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }
            }
            if (PeshoHealth > GoshoHealth)
            {
                Console.WriteLine("Pesho won in {0}th round.", i);
            }
            else
            {
                Console.WriteLine("Gosho won in {0}th round.", i);
            }
        }
    }
}