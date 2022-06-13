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

//using System;

//namespace PrintTriangle
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                PrintTriangle(1, i);
//            }
//            for (int i = n; i > 0; i--)
//            {
//                PrintTriangle(1, i);
//            }
//        }

//        static void PrintTriangle(int start, int end) 
//        {
//            for (int i = start; i <= end; i++)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
