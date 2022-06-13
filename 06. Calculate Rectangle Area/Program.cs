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


//using System;

//namespace CalculateRectangleArea
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double height = double.Parse(Console.ReadLine());
//            double width = double.Parse(Console.ReadLine());
//            double area = GetRectAngleArea(height, width);
//            Console.WriteLine(area);

//        }

//        static double GetRectAngleArea(double height, double width)
//        {
//            return height * width;
//        }
//    }
//}
