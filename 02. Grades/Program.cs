using System;
using System.Linq;
using System.Text;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            PrintGradeDefinition(n);
        }

        static void PrintGradeDefinition(double n) 
        {
            if (n < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (n >= 3 && n < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (n >= 3.50 && n < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (n >= 4.50 && n < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (n >= 5.50 && n <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
       
    }
}
