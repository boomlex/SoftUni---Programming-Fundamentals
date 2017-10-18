using System;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", number1 * number2);
        }
    }
}