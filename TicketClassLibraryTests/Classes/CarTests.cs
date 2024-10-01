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
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            var car = new Car();

            //act
            var Price = car.Price();

            //assert
            Assert.AreEqual(240.0, Price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            var car = new Car();

            //act
            var VehicleType = car.VehicleType();

            //assert
            Assert.AreEqual("Car", VehicleType);
        }
    }
}