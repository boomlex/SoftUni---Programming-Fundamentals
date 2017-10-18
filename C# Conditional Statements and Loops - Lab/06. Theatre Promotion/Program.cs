using System;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            //WEEKDAY
            if (day == "Weekday" && 0 <= age && age <= 18)
            {
                Console.WriteLine("12$");
            }
            else if (day == "Weekday" && 18 < age && age <= 64)
            {
                Console.WriteLine("18$");
            }
            else if (day == "Weekday" && 64 < age && age <= 122)
            {
                Console.WriteLine("12$");
            }
            //Weekend
            else if (day == "Weekend" && 0 <= age && age <= 18)
            {
                Console.WriteLine("15$");
            }
            else if (day == "Weekend" && 18 < age && age <= 64)
            {
                Console.WriteLine("20$");
            }
            else if (day == "Weekend" && 64 < age && age <= 122)
            {
                Console.WriteLine("15$");
            }
            //Holiday
            else if (day == "Holiday" && 0 <= age && age <= 18)
            {
                Console.WriteLine("5$");
            }
            else if (day == "Holiday" && 18 < age && age <= 64)
            {
                Console.WriteLine("12$");
            }
            else if (day == "Holiday" && 64 < age && age <= 122)
            {
                Console.WriteLine("10$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
