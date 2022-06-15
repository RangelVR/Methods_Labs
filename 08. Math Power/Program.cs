using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            PrintMathPower(num, power);
        }

        static void PrintMathPower(double num, double power) 
        {
            Console.WriteLine(Math.Pow(num, power));
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
//            double num = double.Parse(Console.ReadLine());
//            double power = double.Parse(Console.ReadLine());
//            Console.WriteLine(PrintNumPow(num, power));

//        }
//        static double PrintNumPow(double num, double power)
//        {
//            return Math.Pow(num, power);
//        }
//    }
//}
