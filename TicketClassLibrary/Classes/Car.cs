using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Classes
{
    public class Car : Vehicle
    {
        // Constructor to set the vehicle type

        public Car()
        {
            VehicleType = 1;
        }
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
            VehicleType = 1;
        }
        public Car(string licenseplate, DateTime date, bool brobizz)
        {
            Licenseplate = licenseplate;
            Date = date;
            VehicleType = 1;
            Brobizz = brobizz;
        }

    }
}
