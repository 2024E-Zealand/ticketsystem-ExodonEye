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
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            var car = new Car(licenseplate, date);

            //act
            var Price = car.Price();

            //assert
            Assert.AreEqual(240.0, Price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = DateTime.Now;
            var car = new Car(licenseplate, date);

            //act
            var VehicleType = car.GetVehicleType();

            //assert
            Assert.AreEqual("Car", VehicleType);
        }

        [TestMethod()]
        public void CarCretion()
        {
            //arrange
            string LI = "cc20202";
            DateTime D = new DateTime(2024, 10, 1);

            //act
            Car car = new Car(LI, D);

            //assert
            Assert.AreEqual(LI, car.GetLicenseplate());
            Assert.AreEqual(D, car.GetDate());
            Assert.AreEqual("Car", car.GetVehicleType());
        }
    }
}