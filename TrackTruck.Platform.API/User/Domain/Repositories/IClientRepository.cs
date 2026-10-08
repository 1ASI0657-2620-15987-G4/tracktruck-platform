using TrackTruck.Platform.API.Shared.Domain.Repositories;
using TrackTruck.Platform.API.User.Domain.Model.Aggregates;

namespace TrackTruck.Platform.API.User.Domain.Repositories;

public interface IClientRepository : IBaseRepository<Client>
{
    Task<Client?> FindByDniAsync(string dni);
    Task<Client?> FindByUserIdAsync(int userId);
}