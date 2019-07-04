using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = string.Empty;
            int counter = 0;
            result += text[0];
            for (int i = 1; i < text.Length; i++)
            {
                if (result[counter] != text[i])
                {
                    result += text[i];
                    counter++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
