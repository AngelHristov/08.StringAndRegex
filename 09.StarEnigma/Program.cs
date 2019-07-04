using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
           
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string regex = @"[starSTAR]";                

                MatchCollection matched = Regex.Matches(encryptedMessage, regex);
                int key = matched.Count;
                string message = string.Empty;
                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    message += (char)(encryptedMessage[j] - key);
                }
                
                string pattern = @"@(?<name>[A-Za-z]+)([^@:!\->]*):(?<population>[0-9]+)([^@:!\->]*)!(?<type>(A|D))!([^@:!\->]*)->(?<count>[0-9]+)";

                var match = Regex.Match(message, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;                   
                    var type = match.Groups["type"].Value;                   
                    if (type == "A")
                    {
                        attackedPlanets.Add(name);
                    }
                    else
                    {
                        destroyedPlanets.Add(name);
                    }
                }
            }//for loop ends here

            int sumAttacked = attackedPlanets.Count;
            int sumDestroyed = destroyedPlanets.Count;

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }           
        }
    }
}
