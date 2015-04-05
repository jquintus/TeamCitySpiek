using System;

namespace AmazingApp
{
    public class Program
    {
        public static string Msg { get { return "Hello Prod TeamCity!"; } }

        public static void Main(string[] args)
        {
            // This will go in prod
            Console.WriteLine(Msg);
        }
    }
}