using System;
using System.Collections.Generic;
//using System.Diagnostics;

namespace lesListes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Création de listes :");
            Console.WriteLine("=====================");

            var namesListe = new List<String> {"jeremie", "antoine", "patricia"};

            namesListe.Add("laurence");
            namesListe.Add("martine");
            namesListe.Add("papa");
            namesListe.Remove("antoine");

            foreach (var names in namesListe)
            {
                Console.WriteLine($"Hello {names.ToUpper()}");
            }

            Console.WriteLine($"Bonjour, je m' appelle {namesListe[0]}");
            Console.WriteLine($"maintenant il y a {namesListe.Count} personnes dans notre liste");
            Console.WriteLine($"Nous avons ajouter a notre liste {namesListe[3]} et {namesListe[4]}.");

            var index = namesListe.IndexOf("papa");
            if (index != -1)
                Console.WriteLine($"The name {namesListe[index]} is at index {index}");

            var notFound = namesListe.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            Console.WriteLine("");

            namesListe.Sort();
            foreach (string var2 in namesListe)
            {
                Console.WriteLine($"La liste triée avec la fonction sort donne: {var2}");
            }
            Console.ReadKey();
        }
    }
}
