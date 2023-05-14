using Microsoft.EntityFrameworkCore;
using RailwayReservationSystem.Data;
using RailwayReservationSystem.Models;

namespace RailwayReservationSystem.Repository
{
    public class TrainRepository : ITrain
    {
        private readonly RailwayContext railwayContext;

        public TrainRepository(RailwayContext railwayContext)
        {
            this.railwayContext = railwayContext;
        }

        public async Task<List<Train>> GetTrains()
        {
            return await railwayContext.Trains.ToListAsync();
        }

        public async Task<Train> CheckAvailability(string source, string destination, DateTime departureTime)
        {
            var train = await railwayContext.Trains.FirstOrDefaultAsync(t => (t.Source == source) && (t.Destination == destination) && (t.DepartureTime == departureTime));
            return train;
        }
    }
}
