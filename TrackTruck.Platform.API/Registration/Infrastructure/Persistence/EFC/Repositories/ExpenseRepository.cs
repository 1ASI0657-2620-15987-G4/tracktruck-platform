using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using TrackTruck.Platform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TrackTruck.Platform.API.Registration.Infrastructure.Persistence.EFC.Repositories;
public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
{
        private readonly AppDbContext _context;

        public ExpenseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Expense?> FindByTripIdAsync(int tripId)
        {
            return await _context.Expenses.FirstOrDefaultAsync(e => e.TripId == tripId);
        }
}

