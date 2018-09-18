using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltBilletLibrary;

namespace StorebaeltTester
{
    [TestClass]
    public class Biltester
    {
        [TestMethod]
        public void WeekendRabatTester()
        {
            // Arrange 
            StorebaeltBil biltester = new StorebaeltBil();
            

            // Act 
            var result = biltester.WeekendRabat();

            // Assert
            Assert.AreEqual(240,result);
        }

        [TestMethod]
        public void WeekendBrobizzTester()
        {
            // Arrange 
            StorebaeltBil biltester = new StorebaeltBil();


            // Act 
            var result = biltester.WeekendBrobizz();

            // Assert
            Assert.AreEqual(228, result);
        }
    }
}
