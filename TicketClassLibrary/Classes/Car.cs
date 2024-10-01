using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Classes
{
    public class Car
    {
        //properties
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        //methods
        /// <summary>
        /// Price will always return 240
        /// </summary>
        /// <returns>240</returns>
        public double Price()
        {
            return 240.0;
        }
        /// <summary>
        /// Can only return Car
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
