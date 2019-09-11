using System;

namespace MainComparaison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projet de comparaisons de listes d'ages de personnes sur 2 classes differentes:");
            Console.WriteLine("----------------------------------------------------------------------------");

            Biblio biblio1 = new Biblio();



            Personne personne = biblio1.FindPersonne("titi");
            
            if (personne == null)               // (4)
            {
                Console.WriteLine("la personne n'existe pas");
            }
            else
            {
                // (5) Permet d'afficher les datas de jeremie vu que personne n'est pas null        
                int age = personne.GetAge();
                Console.WriteLine(age);
                string name = personne.GetName();
                Console.WriteLine(name);
            }




        }
    }
}
