using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MainComparaison
{
    public class Biblio
    {
        private List<Personne> premiereListe;


        public Biblio()
        {
            this.premiereListe = new List<Personne>();
            Personne personne = new Personne("jeremie", 37);

            // ici apres le .rename: equivaut a this de l'instance de personne avec un petit p
            personne.reName("titi");
            premiereListe.Add(personne);

            Personne personne2 = new Personne("antoine", 42);
            premiereListe.Add(personne2);
            personne2.setAge(30);


            premiereListe.Add(new Personne("benj",25));

        }


    }
    public class Personne
    {
        private string _name;
        private int _age;

        public Personne(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public void reName(string name)
        {
           this._name = name;   
        }

        public void setAge(int age)
        {
            this._age = age;
        }
    }


}
