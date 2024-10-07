using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary.Classes;

namespace OresundBroen.Classes
{
    public class VehicleBrigde : Vehicle
    {
        public override double Price()
        {
            switch (GetVehicleType())
            {
                case "oresund Car":
                    return Brobizz ? 161.0 : 410.0;
                case "oresund MC":
                    return Brobizz ? 73.0 : 210.0;
                default:
                    return 0.0;
            }
        }
        public override string GetVehicleType()
        {
            switch (VehicleType)
            {
                case 1:
                    return "oresund Car";
                case 2:
                    return "oresund MC";
                default:
                    return "vehilce type is not in system";
            }
        }
    }
}
