using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string operrator = Console.ReadLine(); 
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(PrintResult(num1, operrator, num2));
        }

        static double PrintResult(double num1, string operrator, double num2 ) 
        {
            double sum = 0;
            switch (operrator)
            {
                case "+":
                    sum =  num1 + num2;
                    break;
                case "-":
                    sum = num1 - num2;
                    break;
                case "*":
                    sum =  num1 * num2;
                    break;
                case "/":
                    sum = num1 / num2;
                    break;
            }
            return sum;
        }
    }
}
