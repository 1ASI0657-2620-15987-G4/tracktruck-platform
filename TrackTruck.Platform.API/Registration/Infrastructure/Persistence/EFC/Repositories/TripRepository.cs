using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace TrackTruck.Platform.API.Registration.Infrastructure.Persistence.EFC.Repositories;

public class TripRepository : BaseRepository<Trip>, ITripRepository
{
    private readonly AppDbContext _context;

    public TripRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Trip>> FindByClientIdAsync(int clientId)
    {
        return await _context.Trips.Where(t => t.ClientId == clientId).ToListAsync();
    }
    
    public async Task<IEnumerable<Trip>> FindByEntrepreneurIdAsync(int entrepreneurId)
    {
        return await _context.Trips.Where(t => t.EntrepreneurId == entrepreneurId).ToListAsync();
    }
    
    public async Task<IEnumerable<Client>> FindClientsByEntrepreneurIdAsync(int entrepreneurId)
    {
        return await _context.Trips
            .Where(t => t.EntrepreneurId == entrepreneurId)
            .Select(t => t.Client)
            .Distinct()
            .ToListAsync();
    }

    public async Task<Trip?> FindByNameAsync(string name, int entrepreneurId)
    {
        return await _context.Trips.FirstOrDefaultAsync(t => t.Name == name && t.EntrepreneurId == entrepreneurId);
    }
}