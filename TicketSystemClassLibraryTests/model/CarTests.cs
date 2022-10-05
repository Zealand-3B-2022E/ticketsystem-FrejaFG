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
            Assert.AreEqual(expectedPrice, price);

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
            Assert.AreEqual(failprice, price);

        }

        [TestMethod()]
        [DataRow("Car")]
        [DataRow("car")]
        public void VehicleTypeTestOK(string OKvehicle)
        {
            // Arrange
            Car c = new Car();
            string expectedVehicle = OKvehicle;

            // Act
            c.Vehicle = OKvehicle;

            Assert.AreEqual(expectedVehicle, c.Vehicle);
        }

        [TestMethod()]
        [DataRow("  ")]
        [DataRow(null)]
        [DataRow("MC")]
        [DataRow("mc")]
        public void VehicleTypeTestFail(string failVehicle)
        {
            // Arrange
            Car c = new Car();

            // Act 
            c.Vehicle = failVehicle;

            // Assert
            Assert.AreEqual(failVehicle,c.Vehicle);
        }
    }
}