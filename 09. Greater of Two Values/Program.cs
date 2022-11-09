using System;
using System.Text;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMaxInt(n1, n2));
            }
            else if (type == "char")
            {
                char ch1 = char.Parse(Console.ReadLine());
                char ch2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMaxCahr(ch1, ch2));
            }
            else if (type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                Console.WriteLine(GetMacString(str1, str2));
            }
        }

        static int GetMaxInt(int n1, int n2) 
        {
            if (n1.CompareTo(n2) > 0)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
        static char GetMaxCahr(char ch1, char ch2) 
        {
            if (ch1.CompareTo(ch2) > 0)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }
        static string GetMacString(string str1, string str2) 
        {
            if (str1.CompareTo(str2) > 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }

    }
}
