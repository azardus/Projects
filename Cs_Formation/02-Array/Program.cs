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

            // A- 1er Array:
            int[] integerArray = new int[5];

            // initialization standard:
            integerArray[0] = 10;
            integerArray[1] = 20;
            integerArray[2] = integerArray[0] + integerArray[1];
            integerArray[3] = 30 + integerArray[1];

            // initialization loop with:
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }
            // Output
            Console.WriteLine(integerArray);
            Console.WriteLine(integerArray[0]);
            Console.WriteLine(integerArray[1]);
            Console.WriteLine(integerArray[2]);
            Console.WriteLine(integerArray[2] + 60);
            Console.WriteLine(integerArray[0]);




            // B- 2eme Array:
            int[] monArray = new int[] { 50, 40, 30, 100, 90 };
            Array.Sort(monArray);

         
            // Output eatch array element's value:
            for (int j = 0; j< monArray.Length; j++)
            {
                Console.WriteLine(" monArray[{0}] = {1}", j, monArray[j]);
            }
            Console.ReadKey();


        }
    }
}
