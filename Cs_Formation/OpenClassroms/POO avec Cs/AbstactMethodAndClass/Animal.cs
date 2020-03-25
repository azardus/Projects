using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactMethodAndClass
{
    /**
     *  Une classe abstraite est une classe particulière qui ne peut pas être instanciée
     *      nous ne pourrons pas utiliser l’opérateur "new"
     * 
     */
    public abstract class Animal
    {
        /**
         *  une méthode abstraite est une méthode qui ne contient pas d’implémentation, c’est-à-dire pas de code.
         */
        public abstract void SeDeplacer();

        private Coeur coeur;
        private bool EstVivant;
        public int age;
        public int NombreDePattes{get; set;}
        public string prenom { get; set; }

        public Animal()
        {
            coeur = new Coeur();
        }

        public void Respirer()
        {
            Console.WriteLine(" Mon animal respire");
        }

        public void Naissance(int age)
        {
            this.age = age;
            EstVivant = true;
            Console.WriteLine($" Mon Animal : à {age} ans");
        }

        public void Mourrir()
        {
            coeur.Stop();
        }
    
    
    }
}
