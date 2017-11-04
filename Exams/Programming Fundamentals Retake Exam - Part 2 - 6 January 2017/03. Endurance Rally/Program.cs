using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> driversNames = Console.ReadLine().Split(' ').ToList();
            double[] trackLayout = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            long[] checkpoints = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            foreach (var driver in driversNames)
            {
                double fuel = driver[0];
                for (int i = 0; i < trackLayout.Length; i++)
                {
                    var zoneFuel = trackLayout[i];
                    if (checkpoints.Contains(i))
                    {
                        fuel += zoneFuel;
                    }
                    else
                    {
                        fuel -= zoneFuel;
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }

        }
    }
}