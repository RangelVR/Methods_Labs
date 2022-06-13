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


//using System;
//using System.Text;

//namespace _07._Repeat_String
//{
//    class Program
//    {
//        public static object SrtingBuilder { get; private set; }

//        static void Main(string[] args)
//        {
//            string str = Console.ReadLine();
//            int n = int.Parse(Console.ReadLine());

//            Console.WriteLine(RepeatString(str, n));
//        }

//        static string RepeatString(string str, int n)
//        {
//            StringBuilder sb = new StringBuilder();

//            for (int i = 0; i < n; i++)
//            {
//                sb.Append(str);
//            }
//            return sb.ToString();
//        }
//    }
//}
