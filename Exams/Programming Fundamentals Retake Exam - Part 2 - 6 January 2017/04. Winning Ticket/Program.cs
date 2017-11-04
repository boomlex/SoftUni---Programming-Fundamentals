using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main()
        {
            List<string> tickets = Console.ReadLine()
                .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();

            for (int i = 0; i < tickets.Count; i++)
            {
                bool validTicket = tickets[i].Length == 20;
                if (!validTicket)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                bool winningTicket = Regex.IsMatch(tickets[i], @"([\@\#\$\^])\1{19}");
                if (winningTicket)
                {
                    Console.WriteLine($"ticket \"" + tickets[i] + "\" - 10" + tickets[i][0] + " Jackpot!");
                    continue;
                }

                Match leftPart = Regex.Match(tickets[i].Substring(0, 10), @"([\@\#\$\^])\1{5,8}");
                if (leftPart.Success)
                {
                    Match rightPart = Regex.Match(tickets[i].Substring(10), @"([\@\#\$\^])\1{5,8}");
                    if (rightPart.Success && leftPart.Value[0].Equals(rightPart.Value[0]))
                    {
                        Console.WriteLine($"ticket \"" + tickets[i] + $"\" - {Math.Min(leftPart.Length, rightPart.Length)}{leftPart.Value[0]}");
                        continue;
                    }
                }
                Console.WriteLine($"ticket \"" + tickets[i] + "\" - no match");
            }
        }
    }
}