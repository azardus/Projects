using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MathTests.Interfaces;

namespace MathTests.Unit_tests
{
    [TestClass]
    public class GenerateurTest
    {
        [TestMethod]
        public void ObtenirLaValeur_AvecBouchon_RetunrValeur5()
        {
            Mock<IGenerateur> mock = new Mock<IGenerateur>();
            mock.Setup(generateur => generateur.Valeur).Returns(5);

            Assert.AreEqual(5, mock.Object.Valeur);
        }
    }
}
