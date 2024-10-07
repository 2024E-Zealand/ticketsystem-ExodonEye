using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary.Classes;

namespace StoreblætTicketLibrary.Classes
{
    public class WeekendDiscount 
    {
        private readonly Vehicle _weekenddiscount;
        public WeekendDiscount(Vehicle WeekendDiscount)
        {
            _weekenddiscount = WeekendDiscount;
        }

        public bool IsWeekend(DateTime Departure) 
        {
            if (Departure.DayOfWeek == DayOfWeek.Saturday || Departure.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            return false;
            
        }
        public double GetDiscount(DateTime DepartureDate)
        {
            double price = _weekenddiscount.Price();
            if (_weekenddiscount.GetVehicleType() == "Car" && _weekenddiscount.GetBrobizz() == true && IsWeekend(DepartureDate)) 
            {
                price *= 0.80;
                price *= 0.95;
            }
            return price;            
        }
    }
}
