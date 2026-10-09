using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TrackTruck.Platform.API.Registration.Infrastructure.Persistence.EFC.Repositories;

public class DriverRepository(AppDbContext context) : BaseRepository<Driver>(context), IDriverRepository
{
	public async Task<IEnumerable<Driver>> FindByEntrepreneurIdAsync(int entrepreneurId)
	{
		return await Context.Set<Driver>()
			.Where(d => d.EntrepreneurId == entrepreneurId)
			.ToListAsync();
	}

	public async Task<Driver?> FindByDniAsync(string dni, int entrepreneurId)
	{
		return await Context.Set<Driver>()
			.FirstOrDefaultAsync(d => d.Dni == dni && d.EntrepreneurId == entrepreneurId);
	}

	public async Task<Driver?> FindByNameAsync(string name, int entrepreneurId)
	{
		return await Context.Set<Driver>()
			.FirstOrDefaultAsync(d => d.Name == name && d.EntrepreneurId == entrepreneurId);
	}
}
