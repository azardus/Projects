using System;
using System.Collections.Generic;
using System.Text;

namespace _14_heritage
{
     class Animal
    {
        // Mettre tjs les champs en "private" ou "protected"
        //--------------------------------------------------
        // distainguer les champs _age
        private byte age;
        private string name;
        private string couleur;
        private byte nombreDePattes;
        private string race;
        private int taille;

        private string estomac;
        protected string yeux;


        // le but du constructeur est d'initialiser l'objet
        // Assigner les valeurs par deflaut à mon objet
        public Animal()
        {
            name = "rex";
            age = 12;
            Console.WriteLine($"[Animal]");

        }

        public Animal(string name)
        {
            this.name = name;
        }
        // Mettre les fonctions dans la class parent et donner leurs accéssibilitées:
        // --------------------------------------------------------------------------

        // Accessibilité full avec "public"
        // Fonction pour lire name:
        public string GetName()
        {
            return name;
        }
        
        public byte GetAge()
        {
            return age;
        }

        public void SetAge(byte age)
        {
            this.age = age;
        }
        // Accessibilitée a la class parent et enfant avec "protected" + void
        // Fonciton pour modifier name:
        // je l'ai mit en protected pour me forcer a apprendre a utiliser les fonctions, ici ChooseDogName() qui
        // est dans une autre classe ici Dog
        protected void SetName(string name1)
        {
            name = name1;
            // Ou
            // this.name = name1;
            // ça ne sert a rein de fair un return dans un set car la valeur est deja dans le paramètre
        }

        public void IncrementAge()
        {
            this.age += 1;
            this.taille = this.age * 2;
        }

    }

    // Class Dog:
     class Dog : Animal
    {
        // Utilisation heritage avec base:
        //-------------------------------
        //Tous les menbres de ma classe son privé par default
        //----------------------------------------------------

        public Dog()
            :base() //F12
        {
            Console.WriteLine($"[dog]");
        }

        // Fonction pour choisir un nom d'un Dog de la class Dog
        // -------------------------------------------
         public string ChooseDogName()
        {
            // Appel de methode SetName() qui est protected + return GetName qui est public
            // ici nous utilison base. plutot que this pour montrer explicitement que SetName vient de la classe de base.
            //SetName("pluto");
            // encapsulation de Rex2
            base.SetName("Rex2");
            return base.GetName();
        }

        // surcharge
        public string ChooseDogName(string name)
        {
            base.SetName(name);
            return GetName();

        }


        // Constructeur:    
         public Dog(string dogName)
            : base(dogName)
        {
            // ?? pas la peinne de mettre des paramètre ds un constructeur?
            //ChooseDogName("res");
            SetAge(24);
        }
    }

    class Cat : Animal
    {
        Cat()
        {
        }
    }


 

}
