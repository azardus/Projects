using System;
using System.IO;

namespace _10_Using
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
        public static void UsingStatement(string[] args)
        {
            using (TextWriter w = File.CreateText("test.txt"))
            {
                w.WriteLine("Line one");
                w.WriteLine("Line two");
                w.WriteLine("Line three");
            }
        }
    }
}
