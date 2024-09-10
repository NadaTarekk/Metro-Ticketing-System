using Metro_Ticketing_System.Data;
using Metro_Ticketing_System.Interfaces;
using Metro_Ticketing_System.Model;
using Microsoft.EntityFrameworkCore;

namespace Metro_Ticketing_System.Repository
{
    public class StationRepository : IStationRepository
    {
        private readonly MyDbContext _context;

        public StationRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Station?> GetStation(String name)
        {
            return await _context.Stations.FirstOrDefaultAsync(s => s.Name.ToLower() == name.ToLower());
        }

        public async Task<List<Station>> GetTransionStations(int lineId)
        {
            return await _context.Stations
                    .Where(s => s.HasTransition && s.LineId == lineId)
                    .Include(s => s.TransionToStation).ToListAsync();

        }
    }
}
