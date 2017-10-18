using System;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char FirstLine = char.Parse(Console.ReadLine());
            char SecondLine = char.Parse(Console.ReadLine());
            char ThirdLine = char.Parse(Console.ReadLine());

            for (char i = FirstLine; i <= SecondLine; i++)
            {
                for (char k = FirstLine; k <= SecondLine; k++)
                {
                    for (char j = FirstLine; j <= SecondLine; j++)
                    {
                        if (i != ThirdLine && k != ThirdLine && j != ThirdLine)
                        {
                            Console.Write("{0}{1}{2} ", i, k, j);
                        }
                    }
                }
            }
        }
    }
}