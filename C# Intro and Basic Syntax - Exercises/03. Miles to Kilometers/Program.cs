using System;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            number = (number * 1.60934);

            Console.WriteLine("{0:f2}", number);
        }
    }
}