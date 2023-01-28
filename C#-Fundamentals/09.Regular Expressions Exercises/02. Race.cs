using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        static void Main()
        {
            string patternForName = @"[A-Za-z]";
            string patternForDistance = @"\d?";

            string[] raceParticipants = Console.ReadLine()
                .Split(", ");
            Dictionary<string,int> finalResults = new Dictionary<string,int>();
            StringBuilder sb = new StringBuilder();
            StringBuilder distance = new StringBuilder();

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                Regex regex = new Regex(patternForName);
                MatchCollection matches = regex.Matches(input);


                Regex regexForDistance = new Regex(patternForDistance);
                MatchCollection matchesForDistance = regexForDistance.Matches(input);
                int dis = 0;

                for (int i = 0; i < matchesForDistance.Count; i++)
                {
                    distance.Append(matchesForDistance[i]);
                }

                int n = 0;
                for (int i = 0; i < distance.Length; i++)
                {
                    n += int.Parse(distance[i].ToString());
                }

                dis = n;

                for (int i = 0; i < matches.Count; i++)
                {
                    sb.Append(matches[i]);
                }

                for (int i = 0; i < raceParticipants.Length; i++)
                {
                    if (raceParticipants[i] == sb.ToString())
                    {
                        if (!finalResults.ContainsKey(sb.ToString()))
                        {
                            finalResults.Add(sb.ToString(), dis);
                        }
                        else
                        {
                            finalResults[sb.ToString()]+= dis;
                        }
                    }
                }

                sb = new StringBuilder();
                distance = new StringBuilder();
            }

            finalResults = finalResults.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int place = 1;
            string[] places = new string[] { "st", "nd", "rd" };
            foreach (var person in finalResults.Take(3))
            {
                Console.WriteLine($"{place}{places[place - 1]} place: {person.Key}");
                place++;
            }

        }
    }
}