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
    public class MCTests
    {
        [TestMethod()]
        [DataRow(125.0)]
        public void TestMCPriceOK(double price)
        {
            // Arrange
            MC mc = new MC();
            double expectedPrice = price;

            // Arrange
            mc.price = price;

            // Assert
            Assert.AreEqual(expectedPrice, price);
        }

        public void TestMCPriceFail(double price)
        {
            // Arrange
            MC mc = new MC();
            double failPrice = price;

            // Act
            mc.price = failPrice;

            // Assert
            Assert.AreEqual(failPrice, price);
        }

        [TestMethod()]
        [DataRow("MC")]
        public void VehicleTypeTestOK(string OKvehicle)
        {
            // Arrange
            MC mc = new MC();
            string expectedVehicle = OKvehicle;

            // Act
            mc.Vehicle = OKvehicle;

            Assert.AreEqual(expectedVehicle, mc.Vehicle);
        }

        [TestMethod()]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("Car")]
        public void VehicleTypeTestFail(string failVehicle)
        {
            // Arrange
            MC mc = new MC();

            // Arrange
            mc.Vehicle = failVehicle;

            // Assert
            Assert.AreEqual(failVehicle,mc.Vehicle);
        }
    }
}