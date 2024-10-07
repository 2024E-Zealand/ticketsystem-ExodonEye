using OresundBroen.Classes;

namespace OresundBroen.Repository
{
    public interface IOresundRepo
    {
        void AddTicket(VehicleBrigde bridgeTicket);
        List<VehicleBrigde> GetAllTickets();
        List<VehicleBrigde> GetTicketsByLicensePlate(string licensePlate);
    }
}