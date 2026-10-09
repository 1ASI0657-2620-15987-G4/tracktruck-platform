using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TrackTruck.Platform.API.Registration.Infrastructure.Persistence.EFC.Repositories;

public class AlertRepository : BaseRepository<Alert>, IAlertRepository
{
    private readonly AppDbContext _context;

    public AlertRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Alert>> FindByTripIdAsync(int tripId)
    {
        return await _context.Alerts.Where(a => a.TripId == tripId).ToListAsync();
    }

    public async Task<Alert?> FindByTitleAsync(string title)
    {
        return await _context.Alerts.FirstOrDefaultAsync(a => a.Title == title);
    }
}