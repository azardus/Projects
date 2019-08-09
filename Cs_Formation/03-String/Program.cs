using System;

namespace _03_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = new char[4];
            str[0] = 't';
            str[1] = 'o';
            str[2] = 't';
            str[3] = 'o';

            string str2 = "toto";

            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str2 + " hey");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}