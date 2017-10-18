using System;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            bool isEven = number % 2 == 0;

            while (isEven)
            {
                Console.WriteLine("Please write an odd number.");
                number = Math.Abs(short.Parse(Console.ReadLine()));
                isEven = number % 2 == 0;
            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}