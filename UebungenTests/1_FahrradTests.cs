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
    }
}