using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            PrintNtimesInput(input, n);
        }

        static void PrintNtimesInput(string input, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(input);
            }
        }
    }
}

//using System.Text;

//namespace _07._Repeat_String
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            int n = int.Parse(Console.ReadLine());

//            PrintNtimesInput(input, n);
//        }

//        static void PrintNtimesInput(string input, int n)
//        {
//            StringBuilder sb = new StringBuilder();

//            for (int i = 0; i < n; i++)
//            {
//                sb.Append(input);
//            }

//            Console.WriteLine(sb);
//        }
//    }
//}

//namespace _07._Repeat_String
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            int n = int.Parse(Console.ReadLine());

//            PrintNtimesInput(input, n);
//        }

//        static void PrintNtimesInput(string input, int n)
//        {
//            string resultString = string.Empty;

//            for (int i = 0; i < n; i++)
//            {
//                resultString += input;
//            }

//            Console.WriteLine(resultString);
//        }
//    }
//}
