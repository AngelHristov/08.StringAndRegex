using System;

namespace _01.Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(", ");
            foreach (var name in names)
            {
                bool isValid = true;
                if (name.Length >= 3 && name.Length <= 16)
                {         
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!Char.IsLetterOrDigit(name[i]) && name[i] != '-' && name[i] != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                else
                {
                    isValid = false;
                }
                if (isValid)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
