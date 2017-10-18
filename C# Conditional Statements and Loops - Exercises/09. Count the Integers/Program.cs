using System;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = 0;

            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    numCount++;
                }
                catch (OverflowException)
                {
                    break;
                }
                catch (FormatException)
                {
                    break;
                }
            }
            Console.WriteLine(numCount);
        }
    }
}