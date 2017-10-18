using System;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = "";
            double discount = 0.0;
            double priceForDiscount = 0.0;
            double hallPrice = 0.0;
            double price = 0.0;

            switch (package)
            {
                case "Normal":
                    discount = 0.95;
                    priceForDiscount = 500;
                    break;
                case "Gold":
                    discount = 0.90;
                    priceForDiscount = 750;
                    break;
                case "Platinum":
                    discount = 0.85;
                    priceForDiscount = 1000;
                    break;
            }
            if (groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {((hallPrice + priceForDiscount) * discount) / groupSize:f2}$");
        }
    }
}