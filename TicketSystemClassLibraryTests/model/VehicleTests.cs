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
    public class VehicleTests
    {
        // Shared instance field
        private Vehicle v = null;

        [TestInitialize]
        public void BeforeEachTestMethod()
        {
            v = new Vehicle();
        }


        [TestMethod()]
        [DataRow("1 2")]
        [DataRow("  2  6")]
        [DataRow("1 3")]
        [DataRow("12345 7")]
        public void LicenseplateOK(string value)
        {
            // ARRANGE
            // new Vehicicle in test init
            string expectedvale = value;

            // ACT
            v.Licenseplate = value;

            // ASSERT
            Assert.AreEqual(expectedvale, value);
        }

        [TestMethod()]
        [DataRow("       ")]
        [DataRow("12345678")]
        [DataRow(" ")]
        [DataRow("")]
        public void LicenseplateFail(string licenseplate)
        {
            // Arrange
            string failvalue = licenseplate;

            // Act - Lambda udtryk i assert

            // Assert
            Assert.ThrowsException<ArgumentException>(() => v.Licenseplate = licenseplate);
        }
    }
}