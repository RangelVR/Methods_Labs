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

//using System;

//namespace MathPower
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int num = Math.Abs(int.Parse(Console.ReadLine()));
//            Console.WriteLine(MultiplyEvenByOddsDigits(num));
//        }

//        static int MultiplyEvenByOddsDigits(int num) 
//        {
//            int sumEven = 0;
//            int sumOdd = 0;
//            while (num !=0)
//            {
//                int digit = num % 10;
//                if (digit % 2 == 0)
//                {
//                    sumEven += digit;
//                }
//                else
//                {
//                    sumOdd += digit;
//                }
//                num = num / 10;
//            }
//            return sumEven * sumOdd;
//        }

//    }
//}
