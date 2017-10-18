using System;

namespace _03.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine("Employee ID: {0}", id.ToString("00000000"));
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}