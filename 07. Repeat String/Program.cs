using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            RepeatString(str, n);
        }

        static void RepeatString(string str, int n) 
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(str);
            }
        }
    }
}
