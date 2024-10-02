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
        public void MCPrice_PriceTrue_ReturnsPriceForMC()
        {
            //arrange
            var mc = new MC();

            //act
            var Price = mc.Price();

            //assert
            Assert.AreEqual(125.0, Price);
        }

        [TestMethod()]
        public void VehicleType_VehicleTypeTrue_ReturnsMCType()
        {
            //arrange
            var mc = new MC();

            //act
            var VehicleType = mc.GetVehicleType();

            //assert
            Assert.AreEqual("MC", VehicleType);
        }

        [TestMethod()]
        public void vehicleType_MCFalse_ReturnsNoType()
        {
            //arrange
            var mc = new MC { VehicleType = 3 };

            //act
            var result = mc.GetVehicleType();

            //assert
            Assert.AreEqual("vehilce type is not in system", result);
        }

        [TestMethod()]
        public void MCCreatetion_CreateAnMCObject_ReturnsAllTrue()
        {
            //arrange
            string licenseplate = "cc20202";
            DateTime date = new DateTime(2024, 10, 1);

            //act
            var result = new MC(licenseplate, date);

            //assert
            Assert.AreEqual(licenseplate, result.GetLicenseplate());
            Assert.AreEqual(date, result.GetDate());
            Assert.AreEqual("MC", result.GetVehicleType());
            Assert.AreEqual(125.0, result.Price());
        }

        [TestMethod()]
        public void BrobizzDiscount_MCDiscountTrue_ReturnsDiscountedPrice()
        {
            //arrange
            var mc = new MC();
            double discountedPrice = 125.0 * 0.95;

            //act
            var result = mc.Discount(true);

            //assert
            Assert.AreEqual(discountedPrice, result);
        }

        [TestMethod()]
        public void BrobizzDiscount_MCDiscountFalse_ReturnsOriginalPrice()
        {
            //arrange
            var mc = new MC();
            double price = 125.0;

            //act
            var result = mc.Discount(false);

            //assert
            Assert.AreEqual(price, result);
        }
    }
}