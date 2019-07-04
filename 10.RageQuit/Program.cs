using System;
using System.Linq;
using System.Text;

class RageQuit
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToUpper().ToCharArray();
        string toBeRepeated = "";
        string repetition = "";
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                repetition += input[i].ToString();

                if (i + 1 < input.Length && char.IsDigit(input[i + 1]))
                {
                    repetition += input[i + 1].ToString();
                }

                int counter = int.Parse(repetition);

                if (counter == 0) // Don't need to add that to the result.
                {
                    toBeRepeated = "";
                    repetition = "";
                }
                else
                {
                    for (int j = 0; j < counter; j++)
                    {
                        result.Append(toBeRepeated);

                        if (j == counter - 1) // If we are at the last iteration we clear the strings.
                        {
                            toBeRepeated = "";
                            repetition = "";
                        }
                    }
                }
            }
            else
            {
                toBeRepeated += input[i];
            }
        }

        int uniqueSymbols = result.ToString().Distinct().Count();
        string resultString = result.ToString();

        Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
        Console.WriteLine(resultString);
    }
}