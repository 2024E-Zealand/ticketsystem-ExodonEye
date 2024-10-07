using OresundBroen.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OresundBroen.Repository
{
    public class OresundRepo : IOresundRepo
    {
        private List<VehicleBrigde> bridgeTickets = new List<VehicleBrigde>();

        // Method to add a new ticket
        public void AddTicket(VehicleBrigde bridgeTicket)
        {
            bridgeTickets.Add(bridgeTicket);
        }

        // Method to get all tickets
        public List<VehicleBrigde> GetAllTickets()
        {
            return new List<VehicleBrigde>(bridgeTickets);
        }

        // Method to get tickets by license plate
        public List<VehicleBrigde> GetTicketsByLicensePlate(string licensePlate)
        {
            return bridgeTickets.Where(t => t.GetLicenseplate() == licensePlate).ToList();
        }
    }
}
