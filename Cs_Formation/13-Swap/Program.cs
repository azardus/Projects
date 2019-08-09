using System;

namespace _13_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapExample(1, 2);

            static void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            public static void SwapExample()
            {
                int i = 1, j = 2;
                Swap(ref i, ref j);
                Console.WriteLine($"{i} {j}");    // Outputs "2 1"
            }
            Console.WriteLine("Hello World!");
        }
        
        
    }
}
