using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int diffence = number2 - number1;

            if (diffence < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = number1; i < number2; i++)
                {
                    for (int k = number1; k < number2; k++)
                    {
                        for (int n3 = number1; n3 < number2; n3++)
                        {
                            for (int n4 = number1; n4 < number2; n4++)
                            {
                                for (int n5 = number1; n5 <= number2; n5++)
                                {
                                    if (i < k && k < n3 && n3 < n4 && n4 < n5)
                                    {
                                        Console.WriteLine($"{i} {k} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}