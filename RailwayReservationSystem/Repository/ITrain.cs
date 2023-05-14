using RailwayReservationSystem.Models;

namespace RailwayReservationSystem.Repository
{
    public interface ITrain
    {
        Task<List<Train>> GetTrains();

        Task<Train> CheckAvailability(string source, string destination, DateTime departureTime);
    }
}
