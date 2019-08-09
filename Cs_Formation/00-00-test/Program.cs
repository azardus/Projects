using System;

namespace _00_00_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] args2 = null;
            IfStatement(args2);
            Console.WriteLine("Hello World!");
        }

        static void IfStatement(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("Parameters not set");
            }
            else if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else
            {
                Console.WriteLine("One or more arguments");
                foreach (string arg in args)
                    Console.WriteLine(arg);
            }
        }
    }
}
