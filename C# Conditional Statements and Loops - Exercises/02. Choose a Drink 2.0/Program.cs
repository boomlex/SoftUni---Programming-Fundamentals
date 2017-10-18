using System;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());

            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;
            double totalprice;

            if (profession == "Athlete")
            {
                totalprice = (qty * water);
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, totalprice);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalprice = (qty * coffee);
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, totalprice);
            }
            else if (profession == "SoftUni Student")
            {
                totalprice = (qty * beer);
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, totalprice);
            }
            else
            {
                totalprice = (qty * tea);
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, totalprice);

            }
        }
    }
}