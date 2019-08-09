using System;
using System.Collections.Generic;

namespace _05__Suite_de_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercie de Fibonacci :");
            Console.WriteLine("======================");

            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                // index des dernier nombre de fibonacci :
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                // somme des 2 dernier nombre de fibonacci :
                fibonacciNumbers.Add(previous + previous2);
            }
                foreach (var item in fibonacciNumbers)
                    Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
