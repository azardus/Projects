using System;
using System.Collections;
//using System.Collections;
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

            var namesListe = new List<String> { "jeremie", "antoine", "patricia" };

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


            Console.WriteLine("Création d une listes de la classe Person:");
            Console.WriteLine("==========================================");



            Console.WriteLine("Création de Array :");
            Console.WriteLine("===================");

            int[] arrayInts = new int[3];
            arrayInts[0] = 4;
            arrayInts[1] = 5;
            arrayInts[2] = 6;

            Console.WriteLine("Création de ArrayListes :");
            Console.WriteLine("=========================");

            // Detient un tableau object

            ArrayList arrayList = new ArrayList();
            arrayList.Add(arrayInts[0]);


            Console.WriteLine("Création String collection:");
            Console.WriteLine("===========================");

            // C est un liste de string

            Console.WriteLine("Création double collection :");
            Console.WriteLine("============================");

            //

            Console.WriteLine("Création list generique :");
            Console.WriteLine("=========================");

            // Type de classe genenrique


        }
        public class Person
        {
            private int _phoneNumber;
            private string _name;

            public int GetPhoneNumber() { return this._phoneNumber; }
            public void SetPhoneNumber(int phone) { this._phoneNumber = phone; }
            public void AddPhoneNumber(int phone) { this._phoneNumber = phone; }
            public void deletePhoneNumber(int phone) { this._phoneNumber = phone; }


            public string GetName() { return _name; }
            public void AddName(string name) { this._name = name; }
        }



    }
}
