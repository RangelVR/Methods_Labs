using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            PrintAreaOfRectangle(a, b);
        }

        static void PrintAreaOfRectangle(double a, double b) 
        {
            Console.WriteLine(a * b);
        }
    }
}
