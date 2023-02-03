namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintTriangle(n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                PrintTriangle(n, i);
            }

        }

        static void PrintTriangle(int n, int i)
        {
            for (int k = 1; k <= i; k++)
            {
                Console.Write("{0} ", k);
            }
            Console.WriteLine();
        }

    }
}

//namespace _04._Printing_Triangle
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());

//            PrintTriangle(n);
//        }

//        static void PrintTriangle(int n)
//        {
//            for (int i = 1; i <= n; i++)
//            {
//                for (int k = 1; k <= i; k++)
//                {
//                    Console.Write(k + " ");
//                }
//                Console.WriteLine();
//            }

//            GetSecondHalfOfTriangle(n);
//        }

//        static void GetSecondHalfOfTriangle(int n)
//        {
//            for (int i = n - 1; i > 0; i--)
//            {
//                for (int k = 1; k <= i; k++)
//                {
//                    Console.Write("{0} ", k);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
