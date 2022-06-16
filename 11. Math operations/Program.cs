using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string operrator = Console.ReadLine(); 
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintResult(num1, operrator, num2));
        }

        static int PrintResult(int num1, string operrator, int num2 ) 
        {
            int sum = 0;
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
