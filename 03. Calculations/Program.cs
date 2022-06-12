﻿using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;

            if (command == "add")
            {
                PrintAdd(num1, num2, result);
            }
            else if (command == "multiply")
            {
                PrintMultiply(num1, num2, result);
            }
            else if (command == "subtract")
            {
                PrintSubtract(num1, num2, result);
            }
            else if (command == "divide")
            {
                PrintDivide(num1, num2, result);
            }
        }

        static void PrintAdd(int num1, int num2, int result)
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }
        static void PrintMultiply(int num1, int num2, int result)
        {
            result = num1 * num2;
            Console.WriteLine(result);
        }
        static void PrintSubtract(int num1, int num2, int result)
        {
            result = num1 - num2;
            Console.WriteLine(result);
        }
        static void PrintDivide(int num1, int num2, int result)
        {
            result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}