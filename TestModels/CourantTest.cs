using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;

namespace TestModels
{
    [TestClass]
    public class CourantTest
    {
        private Personne _titulaire = new Personne("Doe", "John", new DateTime(1970, 1, 1));

        [TestMethod]
        public void TestLigneDeCredit1()
        {
            Courant courant = new Courant("00001", _titulaire);
            courant.LigneDeCredit = 500;

            Assert.AreEqual(courant.LigneDeCredit, 500);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestLigneDeCredit2()
        {
            Courant courant = new Courant("00001", _titulaire);
            courant.LigneDeCredit = -500;
        }

        [TestMethod]
        public void TestDepot1()
        {
            Courant courant = new Courant("00001", _titulaire);
            courant.Depot(500);

            Assert.AreEqual(courant.Solde, 500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDepot2()
        {
            Courant courant = new Courant("00001", _titulaire);
            courant.Depot(-500);
        }

        [TestMethod]
        public void TestRetrait1()
        {
            Courant courant = new Courant("00001", _titulaire);
            courant.Depot(500);
            courant.Retrait(200);

            Assert.AreEqual(courant.Solde, 300);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRetrait2()
        {
            Courant courant = new Courant("00001", _titulaire);
            courant.Retrait(-500);
        }

        [TestMethod]
        [ExpectedException(typeof(SoldeInsuffisantException))]
        public void TestRetrait3()
        {
            Courant courant = new Courant("00001", _titulaire);
            courant.Depot(500);
            courant.Retrait(600);
        }
    }
}
