using System;

namespace _19_Type_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Les Type generiques:");
            Console.WriteLine("--------------------");

        }
        // le Type Nullable est definie avec le "?"
        /*
         * 2 methode predefinie pour les utilisers
         * 
         *       HasValue retourne s'il y a une valeur ou non
         *       
         *       Value retourne la valeur
         *       
         *    Si HasValue return False alors Value est Null
         */
        int? ii = 42;
        if (x.HasValue)
        {
        System.Console.WriteLine(ii.Value);
        }
        else
        {
        System.Console.WriteLine("Pas de valeur defiie");
        }
}
