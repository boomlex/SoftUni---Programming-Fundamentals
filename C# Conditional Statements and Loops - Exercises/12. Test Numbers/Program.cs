using System;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstLine = int.Parse(Console.ReadLine());
            int SecondLine = int.Parse(Console.ReadLine());
            int ThirdLine = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = FirstLine; i >= 1; i--)
            {
                if (sum >= ThirdLine)
                {
                    break;
                }
                for (int k = 1; k <= SecondLine; k++)
                {
                    sum = sum + (3 * (k * i));
                    counter++;
                    if (sum >= ThirdLine)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", sum, ThirdLine);
                        break;
                    }
                }
            }
            if (sum < ThirdLine)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}