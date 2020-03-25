using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// using System.Data.Entity;

namespace HelloWord.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public List<Resto> OptenirListeDeTousLesRestos()
        {
            return bdd.Restos.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public void CreeUnResto(string Nom, string Telephone)
        {
            bdd.Restos.Add(new Resto { Nom = Nom, Telephone = Telephone });
            bdd.SaveChanges();
        }
    }
}