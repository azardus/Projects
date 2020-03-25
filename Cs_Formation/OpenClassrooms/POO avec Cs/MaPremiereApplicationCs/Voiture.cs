using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApplicationCs
{
    class Voiture : IComparable
    {
        public string Couleur { get; set; }
        protected string Marque { get; set; }
        public int Vitesse { get; set; }

        public Voiture()
        {
        }
        public Voiture(String couleur)
        {
            this.Couleur = couleur;
        }
        public Voiture(String couleur, String marque, int vitesse)
        {
            this.Couleur = couleur;
            this.Marque = marque;
            this.Vitesse = vitesse;
        }

        public int CompareTo(object obj)
        {
            Voiture autreVoiture = (Voiture)obj;

            // 1- Simplification
            return Vitesse.CompareTo(autreVoiture.Vitesse);

            // 2- Cast explicite
            // if (this.Vitesse < autreVoiture.Vitesse) return -1;
            // if (this.Vitesse > autreVoiture.Vitesse) return 1;
            // return 0;
            
            // throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            // return base.GetHashCode();
            return Couleur.GetHashCode() * Marque.GetHashCode() * Vitesse.GetHashCode();
        }

        public override bool Equals(object obj)
        {   // 1er ecriture:
            //  Voiture autreVoiture = (obj) as Voiture;
            //if (autreVoiture == null)
            //  return false;

            // 2eme ecriture:
            if (!((obj) is Voiture autreVoiture))
                return false;

            return Couleur == autreVoiture.Couleur &&
                   Marque == autreVoiture.Marque &&
                   Vitesse == autreVoiture.Vitesse;
        }

        public void SortirDeLaVoiture()
        {
            if (IsClefSurContact()) { PrevenirConducteur(); }
        }

        private void PrevenirConducteur()
        {
            Console.WriteLine("Tu as oublier tes clefs sur le contact");
        }

        public bool Demarrer()
        {
            if (IsClefSurContact())
            {
                DemarrerLeMoteur();
                return true;
            }
            return false;
        }

        private void DemarrerLeMoteur()
        {
            Console.WriteLine("Wroom le moteur demarre !!");
        }

        private bool IsClefSurContact() { return true; }

        public void Klaxonner()
        {
            if (!VitesseAutoriser(150))
            {
                Console.WriteLine("Pouet pouet !!!");
            }
        }


        public bool VitesseAutoriser(int vitesse)
        {
            return vitesse <= 90;
        }




    }
}
