using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Classes
{
    public class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        public double Price()
        {
            return 240.0;
        }

        public string VehicleType()
        {
            return "Car";
        }

    }
}
