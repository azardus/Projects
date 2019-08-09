using System;
using System.IO;

namespace _09_using
{
    public class Class1
    {

        static void UsingStatement(string[] args)
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
