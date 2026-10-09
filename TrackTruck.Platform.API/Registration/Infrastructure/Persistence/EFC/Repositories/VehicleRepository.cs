using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TrackTruck.Platform.API.Registration.Infrastructure.Persistence.EFC.Repositories;

public class VehicleRepository(AppDbContext context): BaseRepository<Vehicle>(context), IVehicleRepository
{
	public async Task<IEnumerable<Vehicle>> FindByEntrepreneurIdAsync(int entrepreneurId)
	{
		return await Context.Set<Vehicle>()
			.Where(v => v.EntrepreneurId == entrepreneurId)
			.ToListAsync();
	}

	public async Task<Vehicle?> FindByPlateAsync(string plate, int entrepreneurId)
	{
		return await Context.Set<Vehicle>()
			.FirstOrDefaultAsync(v => v.Plate == plate && v.EntrepreneurId == entrepreneurId);
	}

	public async Task<Vehicle?> FindByNameAsync(string name, int entrepreneurId)
	{
		return await Context.Set<Vehicle>()
			.FirstOrDefaultAsync(v => v.Name == name && v.EntrepreneurId == entrepreneurId);
	}
}
