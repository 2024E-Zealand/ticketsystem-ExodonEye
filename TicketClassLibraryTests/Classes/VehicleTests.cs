using TicketClassLibrary.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace TicketClassLibrary.Classes.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        [TestMethod()]
        public void GetCarPrice_CarPriceTrue_ReturnsOriginalCarPrice()
        {
            //arrange
            var car = new Car();
            double price = 240.0;

            //act
            var result = car.Price();

            //assert
            Assert.AreEqual(price, result);
        }

        [TestMethod()]
        public void GetMCPrice_MCPriceTrue_ReturnsOriginalMCPrice() 
        {
            //arrange
            var mc = new MC();
            double price = 125.0;

            //act
            var result = mc.Price();

            //assert
            Assert.AreEqual(price, result);
        }

        [TestMethod()]
        public void GetPrice_NoTypeTrue_ReturnsNoPrice()
        {
            //arrange
            var mc = new MC();
            mc.VehicleType = 3;
            var price = 0.0;

            //act
            var result = mc.Price();

            //assert
            Assert.AreEqual(price, result);
        }

        [TestMethod()]
        public void GetTypeCar_CarTypeTrue_ReturnsCarType()
        {
            //arrange
            var car = new Car();
            string type = "Car";

            //act
            var result = car.GetVehicleType();

            //assert
            Assert.AreEqual(type, result);
        }

        [TestMethod()]
        public void GetVehicleType2()
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
        public void GetVehicleType3()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            MC mc = new MC(licenseplate, date);
            mc.VehicleType = 3;

            //act
            var VehicleType = mc.GetVehicleType();

            //assert
            Assert.AreEqual("vehilce type is not in system", VehicleType);
        }



    }
}