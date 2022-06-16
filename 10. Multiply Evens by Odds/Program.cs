using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(PrintResult(num));
        }

        static int PrintResult(string num)
        {
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int currNum = num[i] - '0';
                if (num[i] == '-')
                {
                    continue;
                }
                else if (currNum % 2 == 0)
                {
                    evenSum += currNum;
                }
                else
                {
                    oddSum += currNum;
                }
            }
            return evenSum * oddSum;
        }
    }
}
