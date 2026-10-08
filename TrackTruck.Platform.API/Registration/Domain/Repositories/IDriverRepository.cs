using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Shared.Domain.Repositories;

namespace TrackTruck.Platform.API.Registration.Domain.Repositories;

public interface IDriverRepository : IBaseRepository<Driver>
{
    Task<IEnumerable<Driver>> FindByEntrepreneurIdAsync(int entrepreneurId);
    Task<Driver?> FindByDniAsync(string dni, int entrepreneurId);
    Task<Driver?> FindByNameAsync(string name, int entrepreneurId);
}