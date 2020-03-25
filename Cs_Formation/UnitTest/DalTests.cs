using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWord;
using HelloWord.Models;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class DalTests
    {
        [TestMethod]
        public void CreationRestaurant_AvecUnNnouveauResto_ObteintTousLesRestaurantsRenvoieBienLeResto()
        {
            using (IDal dal = new Dal())
            {
                dal.CreeUnResto("La fourchette", "01 23 82 43 55");
                List<Resto> restos = dal.OptenirListeDeTousLesRestos();

                Assert.IsNotNull(restos);
                Assert.AreEqual("La fourchette", restos[0].Nom);
                Assert.AreEqual("01 23 82 43 55", restos[0].Telephone);
                Assert.AreEqual(1, restos.Count);
            }
        }
    }
}
