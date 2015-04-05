using System;

namespace AmazingApp
{
    public class Program
    {
        public static string Msg { get { return "Hello Prod TeamCity!"; } }

        public static void Main(string[] args)
        {
            Console.WriteLine(Msg);
        }
    }
}