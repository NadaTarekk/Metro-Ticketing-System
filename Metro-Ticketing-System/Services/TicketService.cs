using Metro_Ticketing_System.Data;
using Metro_Ticketing_System.Interfaces;
using Metro_Ticketing_System.Model;
using Metro_Ticketing_System.Repository;
using Microsoft.EntityFrameworkCore;

namespace Metro_Ticketing_System.Services
{
    public class TicketService : ITicketService
    { 
        private readonly IStationRepository _stationRepository;

        public TicketService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }

        public async Task<int> GetDistance(Station startStation, Station endStation)
        {
            var startLineId = startStation.LineId;
            var endLineId = endStation.LineId;
            if(startLineId== endLineId)
            {
                return Math.Abs(startStation.Postion - endStation.Postion);
            }
            else
            {
                List<Station> exchangeStations = await _stationRepository.GetTransionStations(startLineId);
                int minDistance = 100;

                foreach(var exchangeStation in exchangeStations)
                {
                    var distance1 = Math.Abs(startStation.Postion - exchangeStation.Postion);
                    var distance2 = Math.Abs(endStation.Postion - exchangeStation.TransionToStation.Postion); 
                    if( (distance1 + distance2 )< minDistance)
                    {
                        minDistance = distance1 + distance2;    
                        
                    }
                }

                return minDistance;
            }

           
        }

        public int GetPrice(int numberOfStations)
        {
            if (numberOfStations == 0) return 0;
            if (numberOfStations < 9) return 8;
            if (numberOfStations < 16) return 10;
            if (numberOfStations < 23) return 15;
            return 20;
        }

    }
}
