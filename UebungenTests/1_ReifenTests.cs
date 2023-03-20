using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Uebungen;

namespace UebungenTests
{
    [TestClass]
    public class ReifenTests
    {
        [TestMethod]
        public void Reifen_KannErstelltWerden()
        {
            // Arrange
            int zoll = 20;

            // Act
            Reifen r = new Reifen(zoll);

            // Assert
            Assert.AreEqual(zoll, r.Zoll);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Reifen_UntereGrenze()
        {
            // Arrange
            int zoll = 11;

            // Act
            Reifen r = new Reifen(zoll);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Reifen_ObereGrenze()
        {
            // Arrange
            int zoll = 30;

            // Act
            Reifen r = new Reifen(zoll);
        }



    }
}