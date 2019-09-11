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
            this.premiereListe = new List<Personne>();              // (1) instance de premiereListe
            Personne personne = new Personne("jeremie", 37);        // (2) instance de personne avec creation de jeremie

            // ici apres le .Rename: equivaut a this de l'instance de personne avec un petit p
            personne.ReName("titi");
            premiereListe.Add(personne);                            // (3) Ajout de jeremie ds la list premiereListe

            Personne personne2 = new Personne("antoine", 42);       // (4) creation antoine
            premiereListe.Add(personne2);
            personne2.SetAge(30);                                   // Ajout Antoine a la list

            Personne personne3 = personne2;                         // (5) 

            premiereListe.Add(new Personne("benj", 25));            //(6) Ajout Benj a la list


        }
        public Personne ShowList(string name)
        {
            int count;
            count = this.premiereListe.Count;

            for(int i=0; i<count; i++)
            {
               Personne curentListe = premiereListe[i];
               string curentName = curentListe.GetName();
               Console.WriteLine(curentName);
            }
        }
        public Personne FindPersonne(string name)
        {
            /****
            *       Obtimisation de la condition d arret de la boucle :
            *  
            *  En initialisant et declarant la condition d'arret, juste avant la boucle
            * 
            *******************************************************************************/

            int count;
            count = this.premiereListe.Count;

            for (int i = 0; i < count; i++)
            {
                /****
                 * 1- je veux parcourir ma liste : En initialisant un variable (currentPersonne) a ma premiereListe de [i] pour chaque tours de boucle
                 * 2- Affectation de ma variable a une fonciton pour faire quelque chose
                 * 3- Condition pour vérifier si ma variable est bien == a mon parametre name. Si true alors return 
                 * 4- Gestion de la valeur de retour si null, si il n'y a pas la personne en question ds la liste, si name n'et pas trouver dans a la fin des boucles
                 * 5- Gestion de l'affichage des datas: dans Program.cs
                 * 
                 *****************************************************************************************************************************************************/
                Personne currentPersonne = this.premiereListe[i];           // (1) Pour nous ne pouvons pas mettre "new" ici ???????
                //Personne.GetName() 
                string currentName = currentPersonne.GetName();             // (2)
                if (currentName == name)                                    // (3) 
                {
                    return currentPersonne;
                }
            } // Le scope de current se fini ici
            return null;
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

        public void ReName(string name) { this._name = name; }
        public void SetAge(int age) { this._age = age; }
        public string GetName() { return _name; }
        public int GetAge() { return _age; }
    }


}
