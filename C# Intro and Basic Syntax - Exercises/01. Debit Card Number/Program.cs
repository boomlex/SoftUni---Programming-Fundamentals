using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            Console.Write(number1.ToString("0000 "));
            Console.Write(number2.ToString("0000 "));
            Console.Write(number3.ToString("0000 "));
            Console.Write(number4.ToString("0000"));
            Console.WriteLine();
        }
    }
}