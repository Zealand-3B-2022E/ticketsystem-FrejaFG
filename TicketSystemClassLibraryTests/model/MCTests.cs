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
        private MC mc = null;

        [TestMethod()]
        [DataRow(125.0)]
        public void TestMCPriceOK(double price)
        {
            // Arrange
            MC mc = new MC();
            double expectedPrice = price;

            // Arrange
            mc.mcPrice = price;

            // Assert
            Assert.AreEqual(expectedPrice, price);
        }

        public void TestMCPriceFail(double price)
        {
            // Arrange
            MC mc = new MC();
            double failPrice = price;

            // Act
            mc.mcPrice = failPrice;

            // Assert
            Assert.AreEqual(failPrice, price);
        }

        [TestMethod]
        [DataRow(218.75)]
        public void TestPriceDiscount(double price)
        {
            // Arrange
            MC mc = new MC();
            double expectedPrice = price;
            double delta = 0.01;

            // Act
            mc.mcPrice = price;

            // Assert
            Assert.AreEqual(expectedPrice, price, delta);
        }

        [TestMethod()]
        [DataRow("MC")]
        [DataRow("mc")]
        public void VehicleTypeTestOK(string vehicle)
        {
            // Arrange
            MC mc = new MC();
            string expectedVehicle = vehicle;

            // Act
            mc.VehicleType = vehicle;

            Assert.AreEqual(expectedVehicle, mc.VehicleType);
        }

        [TestMethod()]
        // [DataRow(null)]
        [DataRow("")]
        [DataRow("Car")]
        public void VehicleTypeTestFail(string vehicle)
        {
            // Arrange
            MC mc = new MC();

            // Arrange
            // mc.Vehicle = vehicle;

            // Assert
            Assert.AreNotEqual(vehicle, mc.VehicleType);
        }

        [TestMethod()]
        [DataRow("1")]
        [DataRow(" 2    7")]
        [DataRow("1234567")]
        public void LicenseTestOK(string licenseplate)
        {
            // Arrange
            MC mc = new MC();

            // Act
            mc.LicenseplateMC = licenseplate;

            // Assert
            Assert.AreEqual(mc.LicenseplateMC,licenseplate);
        }

        [TestMethod()]
        [DataRow("")]
        [DataRow("12345678")]
        public void LicenseTestFail(string licenseplate)
        {
            // Arrange
            string rejectedLicense = licenseplate;

            // Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                MC mc = new MC(licenseplate, DateTime.Today, 125.0,"MC");
            });

        }
    }
}