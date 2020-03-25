using MaPremiereApplicationCs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MaPremiereApplicationCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voitureJeremie = new Voiture();
            voitureJeremie.Couleur = "bleu";

            Voiture voitureNicolas = new Voiture(couleur: "rouge");

            //  1- Comparaison d'instance:
            if (voitureJeremie == voitureNicolas)
            {
                Console.WriteLine(" Instances : Les objets référencent la meme instance.");
            }
            else Console.WriteLine(" Instances : Les objets n'ont pas la même instance");

            //  2- Equals comparaison substitution:
            if (voitureJeremie.Couleur.Equals(voitureNicolas.Couleur))
            {
                Console.WriteLine(" Equals : Les instances sont identiques");
            }
            Console.WriteLine(" Equals : les instances sont differentes.");

            //  3- Comparaison du constructeur:
            Voiture voiturePatricia = new Voiture(couleur: "vert", marque: "Porche", vitesse: 50);
            Voiture voitureAntoine = new Voiture(couleur: "vert", marque: "Porche", vitesse: 100);

            if (voiturePatricia == voitureAntoine)
            {
                Console.WriteLine(" Construstor avec 3 params : les instances sont identiques.");
            }
            else Console.WriteLine(" Construstor avec 3 params : les instances sont differentes.");

            //  4- Get type de mon instance:
            System.Type getTypeVoitureJeremie = voitureJeremie.GetType();
            Console.WriteLine(getTypeVoitureJeremie);

            //  5- CompareTo():
            voiturePatricia.CompareTo(voitureAntoine);

            //  6- Array de voitures:
            Voiture[] voitures = new Voiture[]
                {
                    new Voiture { Vitesse = 55, Couleur = "rouge" },
                    new Voiture { Vitesse = 100, Couleur = "bleu" },
                    new Voiture { Vitesse = 90, Couleur = "vert" },
                    new Voiture { Vitesse = 90, Couleur = "jaune" },
                    new Voiture { Vitesse = 280, Couleur = "rouge" }
                };

            //  7- Trie par paramètre "vitesse" de toutes les voitures
            Array.Sort(voitures);
            foreach (Voiture autreVoiture in voitures)
            {
                Console.WriteLine(" Vitesse :" + autreVoiture.Vitesse);
            }

            //  8- List de voitureList
            List<Voiture> voituresList = new List<Voiture>()
            {
                new Voiture { Vitesse = 55, Couleur = "rouge" },
                new Voiture { Vitesse = 100, Couleur = "bleu" },
                new Voiture { Vitesse = 90, Couleur = "vert" },
                new Voiture { Vitesse = 90, Couleur = "jaune" },
                new Voiture { Vitesse = 280, Couleur = "rouge" }
            };

            //  9- Dictionary dicVoitureParVitesse + dicVoitureParCouleur
            Dictionary<int, List<Voiture>> dicVoitureParVitesse = new Dictionary<int, List<Voiture>>();
            Dictionary<string, List<Voiture>> dicVoitureParCouleur = new Dictionary<string, List<Voiture>>();

            //  10- Trie par groupement vitesse
            dicVoitureParVitesse = voituresList.GroupBy(v => v.Vitesse).ToDictionary(v => v.Key, v => v.ToList());

            //  11- Trie par groupement par couleur
            dicVoitureParCouleur = voituresList.GroupBy(v => v.Couleur).ToDictionary(v => v.Key, v => v.ToList());

            //  12- Tuple permet de return plusieur parametres
            Tuple<string, Voiture> tuple = RetourVoiture("bleu", 300);
            string couleur = tuple.Item1;
            Voiture maVoiture = tuple.Item2;

            //  13- Initialisation + declaration d'1 oiseau
            Oiseau autreOiseau = new Oiseau { NombrePropulseur = 2 };

            //  14- Initialisation + declaration d'1 avion
            Avion autreAvion = new Avion { NombrePropulseur = 4 };

            //  15- Liste IVolant
            List<IVolant> volants = new List<IVolant> { autreAvion, autreOiseau };
            foreach (IVolant volant in volants)
            {
                volant.Voler();
            }

            //  16- Cating Ivolant pour acceder a une propriété d'Avion qu'Ivolant ne possède pas
            autreAvion = new Avion { NombrePropulseur = 6, MarqueDeCompanie = "AirFrance" };

            List<IVolant> objVolants = new List<IVolant> { autreAvion, autreOiseau };
            foreach (IVolant ivolant in objVolants)
            {
                ivolant.Voler();
                // Casting de ivolant
                Avion ivolantCast = ivolant as Avion;
                if (ivolantCast != null)
                {
                    Console.WriteLine(ivolantCast.MarqueDeCompanie);
                }

            }

            Console.ReadKey();
        }



        public static Tuple<string, Voiture> RetourVoiture(string couleur, int vitesse)
        {
            string toto = couleur;
            return new Tuple<string, Voiture>(toto, new Voiture { Couleur = couleur, Vitesse = vitesse });
        }


        // MaPremiereApplicationCs.Voiture voiturePaty = new MaPremiereApplicationCs.Voiture();

        // voitureJeremie.klaxonner();
        /*voitureJeremie.vitesseAutoriser(94);

            voitureJeremie.demarrer();
            voitureJeremie.sortirDeLaVoiture();

            Console.WriteLine("Fin du programme");
        */
    }
}

