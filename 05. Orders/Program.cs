namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            GetTotalSum(product, quantity);
        }

        static void GetTotalSum(string product, int quantity)
        {
            double price = 0;
            double totalSum = 0;

            switch (product)
            {
                case "coffee": price = 1.50; break;
                case "water": price = 1.00; break;
                case "coke": price = 1.40; break;
                case "snacks": price = 2.00; break;
            }
            totalSum = quantity * price;

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}

//using System;

//namespace _05._Orders
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string product = Console.ReadLine();
//            int quantity = int.Parse(Console.ReadLine());

//            TotalPriceOfOrder(product, quantity);
//        }

//        static void TotalPriceOfOrder(string product, int quantity)
//        {
//            switch (product)
//            {
//                case "coffee":
//                    Console.WriteLine($"{(1.50 * quantity):f2}");
//                    break;
//                case "water":
//                    Console.WriteLine($"{(1.00 * quantity):f2}");
//                    break;
//                case "coke":
//                    Console.WriteLine($"{(1.40 * quantity):f2}");
//                    break;
//                case "snacks":
//                    Console.WriteLine($"{(2.00 * quantity):f2}");
//                    break;
//            }
//        }
//    }
//}
