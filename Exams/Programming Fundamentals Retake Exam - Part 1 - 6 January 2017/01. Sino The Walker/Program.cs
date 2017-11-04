using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var sunoLeaveSoftUni = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long numberOfSteps = long.Parse(Console.ReadLine());
            long timeInSeconds = long.Parse(Console.ReadLine());

            long convertToSeconds = numberOfSteps * timeInSeconds;
            long sunoSeconds = (sunoLeaveSoftUni.Hour * 60 * 60) + (sunoLeaveSoftUni.Minute * 60) + sunoLeaveSoftUni.Second;
            long totalSeconds = sunoSeconds + convertToSeconds;

            long seconds = totalSeconds % 60;
            long totalMinutes = totalSeconds / 60;

            long minutes = totalMinutes % 60;
            long totalHours = totalMinutes / 60;
            long hours = totalHours % 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}