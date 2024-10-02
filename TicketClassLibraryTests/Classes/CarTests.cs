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
        public void CarPrice_PriceTrue_ReturnsPriceForCar()
        {
            //arrange
            var car = new Car();

            //act
            var result = car.Price();

            //assert
            Assert.AreEqual(240.0, result);
        }

        [TestMethod()]
        public void CarVehicleType_CarTrue_ReturnsCarType()
        {
            //arrange
            var car = new Car();

            //act
            var result = car.GetVehicleType();

            //assert
            Assert.AreEqual("Car", result);
        }

        [TestMethod()]
        public void vehicleType_CarFalse_ReturnsNoType()
        {
            //arrange
            var car = new Car { VehicleType = 3 };

            //act
            var result = car.GetVehicleType();

            //assert
            Assert.AreEqual("vehilce type is not in system", result);
        }

        [TestMethod()]
        public void CarCretion_CarCreatedTrue_ReturnsCarCreated()
        {
            //arrange
            string LI = "cc20202";
            DateTime D = new DateTime(2024, 10, 1);

            //act
            var result = new Car(LI, D);

            //assert
            Assert.AreEqual(LI, result.GetLicenseplate());
            Assert.AreEqual(D, result.GetDate());
            Assert.AreEqual("Car", result.GetVehicleType());
            Assert.AreEqual(240.0, result.Price());
        }

        [TestMethod()]
        public void BrobizzDiscount_CarDiscountTrue_ReturnsDiscountedPrice()
        {
            //arrange
            var car = new Car();
            double discountedPrice = 240.0 * 0.95;

            //act
            var result = car.Discount(true);

            //assert
            Assert.AreEqual(discountedPrice, result);
        }

        [TestMethod()]
        public void BrobizzDiscount_CarDiscountFalse_ReturnsOriginalPrice()
        {
            //arrange
            var car = new Car();
            double price = 240.0;

            //act
            var result = car.Discount(false);

            //assert
            Assert.AreEqual(price, result);
        }

    }
}