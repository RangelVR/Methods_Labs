using System;
using System.Text;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintNum(num);
        }

        static void PrintNum(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive. ");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative. "); 
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero. "); 
            }
        }

        //static void Main(string[] args)
        //{
        //    int num = int.Parse(Console.ReadLine());
        //    string output = string.Empty;

        //    Console.WriteLine(GetKindOfNum(num, output));
        //}

        //static string GetKindOfNum(int num, string output)
        //{
        //    if (num > 0)
        //    {
        //        output = $"The number {num} is positive. ";
        //    }
        //    else if (num < 0)
        //    {
        //        output = $"The number {num} is negative. ";
        //    }
        //    else if (num == 0)
        //    {
        //        output = $"The number {num} is zero. ";
        //    }
        //    return output;
        //}
    }
}
