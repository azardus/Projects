using System;

namespace _17_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Les classes");
            Console.WriteLine("-----------");

            ApplicationTriple(1, 2, 3);
            TestStatic test = new TestStatic();

            //TestStatic.a;
            TestStatic.Incrementer();
            Console.WriteLine("la valeur de a est :" + test.GetA()) ;
        }


       static public int ApplicationTriple(int a,int b, int c)
        {
            return a + b + c;
        }

    }
    
    class TestStatic
    {
        protected static int a;
        public static void Incrementer()
        {
            a++;
        }
        public int GetA()
        {
            return a;
        }
    }


}
