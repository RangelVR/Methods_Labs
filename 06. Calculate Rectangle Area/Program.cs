using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            PrintRectangleArea(a, b);
        }

        static void PrintRectangleArea(int a, int b) 
        {
            Console.WriteLine(a * b);
        }
    }
}
