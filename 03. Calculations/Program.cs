using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    PrintAdd(a, b);
                    break;
                case "multiply":
                    PrintMultiply(a, b);
                    break;
                case "subtract":
                    PrintSubtract(a, b);
                    break;
                case "divide":
                    PrintDivide(a, b);
                    break;
            }
        }

        static void PrintAdd(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void PrintMultiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void PrintSubtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void PrintDivide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}


//using System;

//namespace Calculation
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string comand = Console.ReadLine();
//            double firstNum = double.Parse(Console.ReadLine());
//            double secondNum = double.Parse(Console.ReadLine());

//            if (comand == "add")
//            {
//                Console.WriteLine(PrintResultOfAdd(firstNum, secondNum));
//            }
//            else if (comand == "multiply")
//            {
//                Console.WriteLine(PrintResultOdMultiply(firstNum, secondNum));
//            }
//            else if (comand == "subtract")
//            {
//                Console.WriteLine(PrintResultOdSubtract(firstNum, secondNum));
//            }
//            else if (comand == "divide")
//            {
//                Console.WriteLine(PrintResultOdDivide(firstNum, secondNum));
//            }

//        }
//        static double PrintResultOfAdd(double firsNumber, double secondNumber)
//        {
//            return firsNumber + secondNumber;
//        }
//        static double PrintResultOdMultiply(double firsNumber, double secondNumber)
//        {
//            return firsNumber * secondNumber;
//        }
//        static double PrintResultOdSubtract(double firsNumber, double secondNumber)
//        {
//            return firsNumber - secondNumber;
//        }
//        static double PrintResultOdDivide(double firsNumber, double secondNumber)
//        {
//            return firsNumber / secondNumber;
//        }
//    }
//}

//using System;

//namespace _03._Calculations
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string command = Console.ReadLine();
//            int num1 = int.Parse(Console.ReadLine());
//            int num2 = int.Parse(Console.ReadLine());
//            int result = 0;

//            if (command == "add")
//            {
//                PrintAdd(num1, num2, result);
//            }
//            else if (command == "multiply")
//            {
//                PrintMultiply(num1, num2, result);
//            }
//            else if (command == "subtract")
//            {
//                PrintSubtract(num1, num2, result);
//            }
//            else if (command == "divide")
//            {
//                PrintDivide(num1, num2, result);
//            }
//        }

//        static void PrintAdd(int num1, int num2, int result)
//        {
//            result = num1 + num2;
//            Console.WriteLine(result);
//        }
//        static void PrintMultiply(int num1, int num2, int result)
//        {
//            result = num1 * num2;
//            Console.WriteLine(result);
//        }
//        static void PrintSubtract(int num1, int num2, int result)
//        {
//            result = num1 - num2;
//            Console.WriteLine(result);
//        }
//        static void PrintDivide(int num1, int num2, int result)
//        {
//            result = num1 / num2;
//            Console.WriteLine(result);
//        }
//    }
//}
