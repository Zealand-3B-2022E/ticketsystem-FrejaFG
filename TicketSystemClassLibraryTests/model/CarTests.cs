using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.model.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        [DataRow(240.0)]
        public void TestPriceOK(double price)
        {
            // Arrange
            Car c = new Car();
            double expectedPrice = price;

            // Act
            c.price = price;

            // Assert
            Assert.AreEqual(expectedPrice,price);

        }

        [TestMethod()]
        [DataRow(230.0)]
        [DataRow(244.0)]
        public void TestPriceFail(double price)
        {
            //Arrange
            Car c = new Car();
            double failprice = price;

            //Act
            c.price = failprice;

            //Assert
            Assert.AreEqual(failprice,price);

        }

    }
}