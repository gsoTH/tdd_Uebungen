using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uebungen;

namespace UebungenTests
{
    [TestClass]
    public class FahrradTests
    {
        [TestMethod]
        public void Fahrrad_KannErstelltWerden()
        {
            // Arrange
            string farbe = "schwarz";
            int gaenge = 3;
            int reifengroesseInZoll = 20;

            // Act
            Fahrrad f = new Fahrrad(farbe, gaenge, reifengroesseInZoll);

            // Assert
            Assert.AreEqual(farbe, f.Farbe);
            Assert.AreEqual(gaenge, f.Gaenge);
            Assert.AreEqual(reifengroesseInZoll, f.ReifengroesseInZoll);
            Assert.AreEqual(1, f.Sitze);
        }

        [TestMethod]
        public void Fahrrad_KannErstelltWerdenMehrereSitze()
        {
            // Arrange
            int sitze = 2;

            // Act
            Fahrrad f = new Fahrrad("schwarz", 3, 20, sitze);

            // Assert
            Assert.AreEqual(sitze, f.Sitze);
        }

        [TestMethod]
        public void ReifengroesseInZoll_GibtNurGroesstenReifenAus()
        {
            // Arrange
            Reifen[] reifen = { new Reifen(20), new Reifen(26) };
            Fahrrad f = new Fahrrad("schwarz", 3, reifen);

            // Act
            int groessterReifen = f.ReifengroesseInZoll;

            // Assert
            Assert.AreEqual(26, groessterReifen);
        }

        [TestMethod]
        public void Farbe_KannVerändertWerden()
        {
            // Arrange
            Fahrrad f = new Fahrrad("schwarz", 1, 3, 20);
            string neueFarbe = "hellrosa";

            // Act
            f.Farbe = neueFarbe;

            // Assert
            Assert.AreEqual(neueFarbe, f.Farbe);
        }

        //TODO: Negativtests einbauen

    }
}
