using Metro_Ticketing_System.Model;

namespace Metro_Ticketing_System.Interfaces
{
    public interface IStationRepository
    {
        Task<Station?> GetStation(String name);
        Task<List<Station>> GetTransionStations(int lineId);
    }
}
