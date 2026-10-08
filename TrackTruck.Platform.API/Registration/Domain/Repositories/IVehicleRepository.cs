using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Shared.Domain.Repositories;

namespace TrackTruck.Platform.API.Registration.Domain.Repositories;

public interface IVehicleRepository: IBaseRepository<Vehicle>
{
	Task<IEnumerable<Vehicle>> FindByEntrepreneurIdAsync(int entrepreneurId);
	Task<Vehicle?> FindByPlateAsync(string plate, int entrepreneurId);
	Task<Vehicle?> FindByNameAsync(string name, int entrepreneurId);
}