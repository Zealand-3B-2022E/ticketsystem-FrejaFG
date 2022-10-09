using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaelt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary.model;

namespace StoreBaelt.Tests
{
    [TestClass()]
    public class StoreBaeltPriceTests
    {
        /// <summary>
        /// Shared instance field
        /// </summary>
        private Vehicle v = null;

        [TestInitialize]
        public void BeforeEachTestMethod()
        {
            v = new Car();
        }

        [TestMethod()]
        [DataRow(240.0)] // bil alm
        [DataRow(125.0)] // MC alm
        [DataRow(218.75)] // MC med brobizz
        [DataRow(228.0)] //Bil med brobizz
        [DataRow(182.4)] // bil med brobizz weekend
        public void StoreBaeltPriceTestOK(double price)
        {
            // Arrange
            double expectedPrice = price;
            double delta = 0.001;

            // Act
            v.Price = price;

            Assert.AreEqual(expectedPrice,price,delta);
        }

        [TestMethod()]

        public void StoreBaeltPriceTestFail(double price)
        {
            Assert.Fail();
        }
    }
}