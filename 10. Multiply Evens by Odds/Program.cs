namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            GetSumOfEvenDigits(number);
            GetSumOfOddDigits(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }


        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while (number > 0)
            {
                int n = 0;
                n = number % 10;

                if (n % 2 == 0)
                {
                    evenSum += n;
                }

                number /= 10;
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                int n = 0;
                n = number % 10;

                if (n % 2 != 0)
                {
                    oddSum += n;
                }

                number /= 10;

            }
            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

    }
}
