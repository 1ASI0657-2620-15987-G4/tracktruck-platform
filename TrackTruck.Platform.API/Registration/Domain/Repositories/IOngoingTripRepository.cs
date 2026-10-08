using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Shared.Domain.Repositories;
namespace TrackTruck.Platform.API.Registration.Domain.Repositories;

public interface IOngoingTripRepository : IBaseRepository<OngoingTrip>
{
    Task<OngoingTrip?> FindByTripIdAsync(int tripId);
}