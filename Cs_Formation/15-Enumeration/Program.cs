using System;

namespace _15_Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("l'enumeration:");
            Console.WriteLine("--------------");

            Console.WriteLine("Utilisation du [Flags]");
            Console.WriteLine("-----------------------");

            Couleur maCouleur = Couleur.rouge | Couleur.bleu;
            //string s = maCouleur.ToString();
            Console.WriteLine("la couleur courante est : " + maCouleur);
        }

        // Je base l'enum de type int  avec le :

        enum Jours 
        {
        lundi = 1,
        mardi,
        mercredi,
        jeudi,
        vendredi,

        }

        // Utilisation de l'attribut [Flags] et du |
        /*
         * il permet de combier differentes valeurs sous reserve de les choisir judicieusement
         */
         [Flags]
         enum Couleur : int
        {
            rouge = 1,
            vert = 2,
            bleu = 3,
            // je ne comprend pas pourquoi quand nous changons 4 en 3 le retour de s n'est pas le meme?
            // le | = ou binaire
        }
    
    }
}
