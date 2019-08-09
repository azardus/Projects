using System;

namespace _02_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            // TYPE[] name; -> NULL
            // TYPE[] name = new TYPE[size];

            int[] integerArray = new int[5];

            integerArray[0] = 5;
            integerArray[1] = 6;
            integerArray[2] = integerArray[0] + integerArray[1];
            integerArray[3] = 56 + integerArray[1];

            Console.WriteLine(integerArray);
            Console.WriteLine(integerArray[0]);
            Console.WriteLine(integerArray[1]);
            Console.WriteLine(integerArray[2]);
            Console.WriteLine(integerArray[2] + 60);

            Console.ReadKey();
        }
    }
}
