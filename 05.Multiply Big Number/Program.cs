using System;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main()
        {
            string num = Console.ReadLine().TrimStart('0');
            
            int multiplyer = int.Parse(Console.ReadLine());
            string resultReversed = string.Empty;
            int firstDigit = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {

                int multiply = int.Parse(num[i].ToString()) * multiplyer + firstDigit;
                if (multiply <= 9)
                {
                    resultReversed += multiply;
                    firstDigit = 0;
                }
                else
                {
                    resultReversed += multiply % 10;
                    firstDigit = multiply / 10;
                }
            }
            if (firstDigit > 0)
            {
                resultReversed += firstDigit;
            }
            string result = string.Empty;
            for (int i = resultReversed.Length - 1; i >= 0; i--)
            {
                result += resultReversed[i];
            }
            if (multiplyer == 0 )
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result);
            }
            
        }
    }
}
