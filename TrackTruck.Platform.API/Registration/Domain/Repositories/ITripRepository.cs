using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Shared.Domain.Repositories;
using TrackTruck.Platform.API.User.Domain.Model.Aggregates;

namespace TrackTruck.Platform.API.Registration.Domain.Repositories;

public interface ITripRepository : IBaseRepository<Trip>
{
    Task<IEnumerable<Trip>> FindByClientIdAsync(int clientId);
    Task<IEnumerable<Trip>> FindByEntrepreneurIdAsync(int entrepreneurId);
    Task<IEnumerable<Client>> FindClientsByEntrepreneurIdAsync(int entrepreneurId);
    Task<Trip?> FindByNameAsync(string name, int entrepreneurId);
}