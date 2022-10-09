using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary.model;

namespace OresundbronTicketLibrary.Tests
{
    [TestClass]
    public class OresundVehicleTests
    {
        // fælles instans
        OresundVehicle v = null;

        [TestInitialize()]
        public void BeforeEachTest()
        {
            v = new OresundVehicle();
        }

        [TestMethod()]
        [DataRow("OresundCar")]
        [DataRow("OresundMC")]
        public void OresundVehicleTypeTestOK(string vehicleType)
        {
            // Arrange
            string expectedVehicleType = vehicleType;

            // Act
            v.VehicleType = vehicleType;

            //Assert
            Assert.AreEqual(expectedVehicleType,vehicleType);
        }
    }
}