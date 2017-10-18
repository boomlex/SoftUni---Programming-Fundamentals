using System;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumbersCount = int.Parse(Console.ReadLine());
            int sumOfOddNumbers = 0;
            for (int i = 1; i < oddNumbersCount * 2; i += 2)
            {
                sumOfOddNumbers += i;
                Console.WriteLine(i);
            }

            Console.WriteLine($"Sum: {sumOfOddNumbers}");
        }
    }
}