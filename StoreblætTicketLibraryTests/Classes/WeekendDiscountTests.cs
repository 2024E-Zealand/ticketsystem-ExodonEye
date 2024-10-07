using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreblætTicketLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary.Classes;

namespace StoreblætTicketLibrary.Classes.Tests
{
    [TestClass()]
    public class WeekendDiscountTests
    {
        private Vehicle _vehicle;
        private WeekendDiscount _weekendDiscount;

        [TestInitialize]
        public void Setup()
        {
            _vehicle = new MockVehicle();
            _weekendDiscount = new WeekendDiscount(_vehicle);
        }

        [TestMethod]
        public void IsWeekend_ShouldReturnTrue_WhenSaturday()
        {
            var date = new DateTime(2024, 10, 5); // Saturday
            Assert.IsTrue(_weekendDiscount.IsWeekend(date));
        }

        [TestMethod]
        public void IsWeekend_ShouldReturnTrue_WhenSunday()
        {
            var date = new DateTime(2024, 10, 6); // Sunday
            Assert.IsTrue(_weekendDiscount.IsWeekend(date));
        }

        [TestMethod]
        public void IsWeekend_ShouldReturnFalse_WhenWeekday()
        {
            var date = new DateTime(2024, 10, 7); // Monday
            Assert.IsFalse(_weekendDiscount.IsWeekend(date));
        }

        [TestMethod]
        public void GetDiscount_ShouldApplyDiscount_WhenConditionsMet()
        {
            var date = new DateTime(2024, 10, 6); // Saturday

            Assert.AreEqual(182.4 , _weekendDiscount.GetDiscount(date), 0.1);
        }

        [TestMethod]
        public void GetDiscount_ShouldNotApplyDiscount_WhenNotWeekend()
        {
            var date = new DateTime(2024, 10, 7); // Monday
            Assert.AreEqual(240.0, _weekendDiscount.GetDiscount(date));
        }
    }

    public class MockVehicle : Vehicle
    {
        public override double Price()
        {
            return 240.0;
        }

        public override string GetVehicleType()
        {
            return "Car";
        }

        public override bool GetBrobizz()
        {
        return true;        
        }
    }
}
