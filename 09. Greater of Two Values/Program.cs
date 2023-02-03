namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            PrintMaxValue(type, a, b);

        }

        static void PrintMaxValue(string type, string a, string b)
        {
            if (type == "int")
            {
                GetMaxInt(a, b);
            }
            else if (type == "char")
            {
                GetMaxChar(a, b);
            }
            else if (type == "string")
            {
                GetMaxString(a, b);
            }
        }

        static void GetMaxInt(string a, string b)
        {
            int n1 = int.Parse(a);
            int n2 = int.Parse(b);
            Console.WriteLine(Math.Max(n1, n2));
        }

        static void GetMaxChar(string a, string b)
        {
            char ch1 = char.Parse(a);
            char ch2 = char.Parse(b);

            if (ch1 > ch2)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        static void GetMaxString(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
