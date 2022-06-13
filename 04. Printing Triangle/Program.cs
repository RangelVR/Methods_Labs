using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            for (int k = n - 1; k > 0; k--)
            {
                for (int q = 1; q <= k; q++)
                {
                    Console.Write($"{q} ");
                }
                Console.WriteLine();
            }
        }
    }
}