using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            List<string> nums = new List<string>();

            MatchCollection matched = Regex.Matches(numbers, regex);

            foreach (Match number in matched)

            {
                nums.Add(number.Value);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
