using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Shared.Domain.Repositories;

namespace TrackTruck.Platform.API.Registration.Domain.Repositories;

public interface IAlertRepository : IBaseRepository<Alert>
{
    Task<IEnumerable<Alert>> FindByTripIdAsync(int tripId);
    Task<Alert?> FindByTitleAsync(string title);
}