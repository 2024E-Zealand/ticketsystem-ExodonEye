using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicketClassLibrary.Classes.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            var mc = new MC(licenseplate, date);

            //act
            var Price = mc.Price();

            //assert
            Assert.AreEqual(125.0, Price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            var mc = new MC(licenseplate, date);

            //act
            var VehicleType = mc.GetVehicleType();

            //assert
            Assert.AreEqual("MC", VehicleType);
        }

        [TestMethod()]
        public void MCCretion()
        {
            //arrange
            string LI = "cc20202";
            DateTime D = new DateTime(2024, 10, 1);

            //act
            MC mc = new MC(LI, D);

            //assert
            Assert.AreEqual(LI, mc.GetLicenseplate());
            Assert.AreEqual(D, mc.GetDate());
            Assert.AreEqual("MC", mc.GetVehicleType());
        }
    }
}