using Metro_Ticketing_System.Model;

namespace Metro_Ticketing_System.Interfaces
{
    public interface ITicketService
    {
        int GetPrice(int numberOfStations);
        Task<int> GetDistance(Station startStation, Station endStation);
    }
}
