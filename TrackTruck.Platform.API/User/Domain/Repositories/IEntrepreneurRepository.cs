using TrackTruck.Platform.API.Shared.Domain.Repositories;
using TrackTruck.Platform.API.User.Domain.Model.Aggregates;

namespace TrackTruck.Platform.API.User.Domain.Repositories;

public interface IEntrepreneurRepository : IBaseRepository<Entrepreneur>
{
    Task<Entrepreneur?> FindByUserIdAsync(int userId);
    Task<Entrepreneur?> FindByRucAsync(string ruc);
    Task<Entrepreneur?> FindByNameAsync(string name);
}
