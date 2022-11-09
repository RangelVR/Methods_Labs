using System;
using System.Linq;
using System.Text;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{PrintTotalSum(product, quantity):f2}");
        }

        static double PrintTotalSum(string product, int quantity)
        {
            double totalSum = 0;
            switch (product)
            {
                case "coffee":
                    totalSum = quantity * 1.50;
                    break;
                case "water":
                    totalSum = quantity * 1.00;
                    break;
                case "coke":
                    totalSum = quantity * 1.40;
                    break;
                case "snacks":
                    totalSum = quantity * 2.00;
                    break;
            }
            return totalSum;
        }
    }
}
