using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Classes.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            var mc = new MC();

            //act
            var Price = mc.Price();

            //assert
            Assert.AreEqual(125.0, Price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            var mc = new MC();

            //act
            var VehicleType = mc.GetVehicleType();

            //assert
            Assert.AreEqual("MC", VehicleType);
        }
    }
}