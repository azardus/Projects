using System;

namespace _16_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("les Structures :");
            Console.WriteLine("----------------");

            CoordonneesGeographique Maison = new CoordonneesGeographique();

        }
        /*
         * La struct en comparaison avec la class fait face a certaine limitation:
         * Elle ne peux pas avoir de constructeur vide
         * et encore moins gérer de l'heritage.
         */
        struct CoordonneesGeographique
        {
            public float latitude, longitude;

            public CoordonneesGeographique(float lat, float lon)
            {
                latitude = lat;
                longitude = lon;
            }

            
        }

    


    }
}
