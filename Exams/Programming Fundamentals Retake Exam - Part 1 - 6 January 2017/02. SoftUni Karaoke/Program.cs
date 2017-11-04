using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            // list with all participants that applied for performance. 
            List<string> participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            // list with all available songs
            List<string> allSongs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();


            Dictionary<string, List<string>> awardsDictionary = new Dictionary<string, List<string>>();

            //While cicle until it saw "dawn" command for stop.
            //THE INPUT
            while (true)
            {
                List<string> input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (input[0] == "dawn")
                {
                    break;
                }

                var indexParticipant = input[0];
                var indexSong = input[1];
                var indexAward = input[2];

                if (participants.Contains(indexParticipant) && allSongs.Contains(indexSong))
                {
                    if (!awardsDictionary.ContainsKey(indexParticipant))
                    {
                        awardsDictionary.Add(indexParticipant, new List<string> { indexAward });
                    }
                    if (!awardsDictionary[indexParticipant].Contains(indexAward))
                    {
                        awardsDictionary[indexParticipant].Add(indexAward);
                    }
                }
            }
            // THE OUTPUT
            if (awardsDictionary.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            //if awardsDictionary contains any elements to enter in
            if (awardsDictionary.Any())
            {
                //for each item in awardsDictionary to be sorted by descending first by the awards values and their count n/
                //then by their keys
                foreach (var item in awardsDictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    // if the foreach item have any keys to... get the participant key and the awards values
                    if (item.Key.Any())
                    {
                        var participant = item.Key;
                        var award = item.Value;
                        Console.WriteLine($"{participant}: {award.Count} awards");
                        // for each awards in award to be sorted and print
                        foreach (var awards in award.OrderBy(x => x))
                        {
                            Console.WriteLine($"--{awards}");
                        }
                    }
                }
            }

        }
    }
}
