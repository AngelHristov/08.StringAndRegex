using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string name2 = names.Substring(names.IndexOf(" ") + 1);
            string name1 = names.Remove(names.IndexOf(" "));

            int sumChar = 0;
            int minNameLenght = 0;
            if (name2.Length > name1.Length)
            {
                minNameLenght = name1.Length;
                for (int i = name1.Length; i < name2.Length; i++)
                {
                    sumChar += name2[i];
                }
            }
            else if (name2.Length < name1.Length)
            {
                minNameLenght = name2.Length;
                for (int i = name2.Length; i < name1.Length; i++)
                {
                    sumChar += name1[i];
                }
            }
            else
            {
                minNameLenght = name1.Length;
            }
             
            for (int i = 0; i < minNameLenght; i++)
            {
                sumChar += name1[i] * name2[i];
            }
            Console.WriteLine(sumChar);
        }
    }
}
