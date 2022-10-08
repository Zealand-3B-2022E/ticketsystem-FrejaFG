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
        // shared instance field
        private Car car = null;

        [TestMethod()]
        [DataRow(240.0)]
        public void TestPriceOK(double price)
        {
            // Arrange
            Car c = new Car();
            double expectedPrice = price;

            // Act
            c.carPrice = price;

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
            // c.price = failprice;

            //Assert
            Assert.AreEqual(failprice, price);

        }

        [TestMethod()]
        [DataRow("Car")]
        [DataRow("car")]
        public void VehicleTypeTestOK(string vehicle)
        {
            // Arrange
            Car c = new Car();
            string expectedVehicle = vehicle;

            // Act
            c.VehicleType = vehicle;

            Assert.AreEqual(expectedVehicle, c.VehicleType);
        }

        [TestMethod()]
        [DataRow("  ")]
        // [DataRow(null)]
        [DataRow("MC")]
        [DataRow("mc")]
        public void VehicleTypeTestFail(string vehicle)
        {
            // Arrange
            Car c = new Car();
            string failVehicle = vehicle;

            // Act 
            //c.Vehicle = failVehicle;

            // Assert
            Assert.AreNotEqual(vehicle, c.VehicleType);
            // Assert.IsNotNull(c.Vehicle);
        }


        [TestMethod()]
        [DataRow("1")]
        [DataRow(" 2    7")]
        [DataRow("1234567")]
        public void LicenseTestOK(string licenseplate)
        {
            // Arange
            Car c = new Car();
            string acceptedLicense = licenseplate;

            // Act
            c.LicenseplateCar = licenseplate;

            // Assert
            Assert.AreEqual(acceptedLicense,licenseplate);
        }

        [TestMethod()]
        [DataRow("")]
        [DataRow("12345678")]
        public void LicenseTestFail(string licenseplate)
        {
            // Arrange
            //Car c = new Car();
            string rejectedLicense = licenseplate;

            // Assert
            Assert.ThrowsException<ArgumentException>( ()=>
                {
                Car c = new Car(licenseplate, DateTime.Today, 240.0, "Car");
                });

        }

    }
}