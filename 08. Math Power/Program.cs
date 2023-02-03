namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            int power = int .Parse(Console.ReadLine());

            PrintResult(@base, power);
        }

        static void PrintResult(double @base, int power)
        {
            double sum = 1; 

            for (int i = 0; i < power; i++)
            {
                sum *= @base;
            }

            Console.WriteLine(sum);
        }
    }
}
