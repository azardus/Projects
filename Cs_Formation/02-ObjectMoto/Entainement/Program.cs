using System;

namespace Entainement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Chanson c1 = new Chanson();

            Chanson c2 = new Chanson();

            c1.PrintMe();
            c2.PrintMe();

            c1.setArtiste("oweun");

            c1.PrintMe();
            c2.PrintMe();

            Console.WriteLine("Press enter to exit");

            /********************/

            Console.Read();


            Moto motoBleue = new Moto("bleue", "23");
            Moto motoRouge = new Moto("rouge", "10");


            Console.WriteLine(motoBleue);
            Console.WriteLine(motoRouge);

            motoBleue.RemplirReservoir(5);

            if (motoBleue.Demarrer())
            {
                Console.WriteLine (" mettre le casque (safety first) et rouler");
            }
            else
            {
                //TODO : c'est con
            }


            if (motoRouge.Demarrer())
            {
                //TODO : mettre le casque (safety first) et rouler
            }
            else
            {
                //TODO : c'est con
            }
        }
    }

    public class Moto
    {
        private bool _estDemarre = false;
        private int _litresEssence = 0;
        private int _capacité = 10;
        private string _couleur;
        private string _cylindree;

        public Moto(string couleur, string cylindree)
        {
            _couleur = couleur;
            _cylindree = cylindree;
        }

        public bool Demarrer()
        {
            if (_litresEssence > 0)
                this._estDemarre = true;

            return this._estDemarre;
        }

        public void RemplirReservoir(int litres)
        {
            int nouvelleQuantité = this._litresEssence + litres;

            if (nouvelleQuantité > _capacité)
                throw new InvalidOperationException("ça déborde");

            this._litresEssence = nouvelleQuantité;
        }

        public override string ToString()
        {
            return $"Votre moto est de couleur {_couleur}";
        }
    }

    public class Chanson
    {
        private String Titre = " ";
        private String Artiste = "jeremie";
        private String Duree = "";

        public Chanson()
        {
        }

        public Chanson(string artiste)
        {
            this.Artiste = artiste;
        }

        public void setArtiste(String Artiste)
        {
            this.Artiste = Artiste;
        }

        public String getArtiste()
        {
            return Artiste;
        }

        public void PrintMe()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Chanson " + this.Titre + " - " + this.Artiste + " (" + this.Duree + ")";
        }
    }

}
