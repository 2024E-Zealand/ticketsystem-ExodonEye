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
        public void PriceTest1()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            Car car = new Car(licenseplate, date);

            //act
            var Price = car.Price();

            //assert
            Assert.AreEqual(240.0, Price);
        }

        [TestMethod()]
        public void PriceTest2() 
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            MC mc = new MC(licenseplate, date);

            //act
            var Price = mc.Price();

            //assert
            Assert.AreEqual(125.0, Price);
        }

        [TestMethod()]
        public void PriceTest3()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            MC mc = new MC(licenseplate, date);

            //act
            mc.VehicleType = 3;
            var Price = mc.Price();

            //assert
            Assert.AreEqual(0.0, Price);
        }

        [TestMethod()]
        public void GetVehicleType1()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            Car car = new Car(licenseplate, date);

            //act
            var VehicleType = car.GetVehicleType();

            //assert
            Assert.AreEqual("Car", VehicleType);
        }

        [TestMethod()]
        public void GetVehicleType2()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            MC mc = new MC(licenseplate, date);

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