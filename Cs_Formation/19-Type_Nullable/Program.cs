using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _19_Type_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Les Type generiques:");
            Console.WriteLine("--------------------");


            Queue<int> fileAttente = new Queue<int>();
            fileAttente.Enqueue(3);
            fileAttente.Enqueue(1);
            int valeur = fileAttente.Dequeue();
            valeur = fileAttente.Dequeue();

            Dictionary<string, Personne> annuaire = new Dictionary<string, Personne>();
            annuaire.Add("06 61 67 93 75", new Personne { Prenom = "Jeremie" });
            annuaire.Add("03 23 23 23 23", new Personne { Prenom = "Antoine"});
            Personne p = annuaire["06 61 67 93 75"]; // Ici p contient la propriete Prenom valant Jeremie

            Afficheur(3);


            OBJECTIF: Voir les contributions dans le calendrier:

modification de user.email dans git config --global "jeremie.pichot.pro@gmail.com"



        }

        // le Type Nullable est definie avec le "?"

        /* * *
         * 2 methode predefinie pour les utilisers
         * 
         *       HasValue retourne s'il y a une valeur ou non
         *       
         *       Value retourne la valeur
         *       
         *    Si HasValue return False alors Value est Null
         */

        /* * * 
         * 
         * int? ii = 42;
         * 
         * if (x.HasValue)
         *  {System.Console.WriteLine(ii.Value);}
         * else
         *  {System.Console.WriteLine("Pas de valeur defiie");}
         * 
         * 
         */


        // les classes queue<> permettent de gérer une fille d'attente style FIFO (= Premier entrer premier sorti )



    }

    internal class Personne
    {
    }

    public class Afficheur
    {
        public class void Affiche( XObject o)
        {
            Console.WriteLine("Afficheur d'objet :");
            Console.WriteLine("\tType : " + o.GetType());
            Console.WriteLine("\tRepresentation : " + o.ToString());
        }
    }
}
