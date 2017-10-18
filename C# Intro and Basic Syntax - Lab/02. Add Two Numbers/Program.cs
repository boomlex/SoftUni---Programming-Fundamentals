using System;

namespace _02.Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 + number2;

            Console.WriteLine($"{number1} + {number2} = " + result);
        }
    }
}