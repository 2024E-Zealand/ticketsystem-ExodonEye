using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Classes
{
    public class MC : Vehicle
    {
         // Constructor to set the vehicle type
    public MC(string licenseplate, DateTime date)
    {
        Licenseplate = licenseplate;
        Date = date;
        VehicleType = 2;
    }
    }
}
