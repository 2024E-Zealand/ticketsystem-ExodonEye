using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Classes
{
    public abstract class Vehicle
    {
        //instance fields
        private string _licenseplate;
        private DateTime _date;

        //properties
        protected string Licenseplate 
        {  
            get { return _licenseplate; }
            set
            {
                if (value.Length != 7)
                {
                    throw new ArgumentException("Licenseplate most be 7 char long");
                }
                _licenseplate = value;
            } 
        }
        protected DateTime Date 
        {
            get { return _date; } 
            set { _date = value; } 
        }
        public int VehicleType { get; set; }


        //methods
        /// <summary>
        /// Price is deffinded by the type of GetVehicleType method
        /// and should return the vehicleTypes price
        /// </summary>
        /// <returns>Price</returns>
        public double Price() 
        {
            switch (GetVehicleType())
            {
                case "Car":
                    return 240.0;
                case "MC":
                    return 125.0;
                default:
                    return 0.0;
            }
        }
        /// <summary>
        /// The GetVehicleType() gets its int from VehicleType
        /// in a Switch so VehecleType 1 is "Car" And 2 is "MC"
        /// </summary>
        /// <returns>GetVehicleType</returns>
        public string GetVehicleType() 
        {
            switch (VehicleType) 
            {
                case 1:
                    return "Car";
                case 2:
                    return "MC";
                default:
                    return "vehilce type is not in system";
            }
        }
    }
}
