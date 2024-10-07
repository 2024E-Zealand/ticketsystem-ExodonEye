using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBroen.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary.Classes;

namespace OresundBroen.Classes.Tests
{
    [TestClass()]
    public class VehicleBrigdeTests
    {

        [TestMethod()]
        public void TestCarPriceWithoutBrobizz()
        {
            var car = new VehicleBrigde { VehicleType = 1};
            car.SetBrobizz(false);
            Assert.AreEqual(410.0, car.Price());
        }

        [TestMethod()]
        public void TestCarPriceWithBrobizz()
        {
            var car = new VehicleBrigde { VehicleType = 1};
            car.SetBrobizz(true);
            Assert.AreEqual(161.0, car.Price());
        }

        [TestMethod()]
        public void TestMCPriceWithoutBrobizz()
        {
            var mc = new VehicleBrigde { VehicleType = 2};
            mc.SetBrobizz(false);
            Assert.AreEqual(210.0, mc.Price());
        }
        [TestMethod()]
        public void TestMCPriceWithBrobizz()
        {
            var mc = new VehicleBrigde { VehicleType = 2};
            mc.SetBrobizz(true);
            Assert.AreEqual(73.0, mc.Price());
        }
        [TestMethod()]
        public void TestGetVehicleTypeCar()
        {
            var car = new VehicleBrigde { VehicleType = 1 };
            Assert.AreEqual("oresund Car", car.GetVehicleType());
        }
        [TestMethod()]
        public void TestGetVehicleTypeMC()
        {
            var mc = new VehicleBrigde { VehicleType = 2 };
            Assert.AreEqual("oresund MC", mc.GetVehicleType());
        }
    }
}