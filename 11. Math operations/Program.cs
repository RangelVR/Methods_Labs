namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine(PrintOperation(n1, @operator, n2));
        }

        static double PrintOperation(double n1, string @operator, double n2)
        {
            switch (@operator)
            {
                case "/":
                    return n1 / n2;
                case "*":
                    return n1 * n2;
                case "-":
                    return n1 - n2;
                case "+":
                    return n1 + n2;
            }

            return 0;
        }
    }
}
