using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Shared.Domain.Repositories;
 

namespace TrackTruck.Platform.API.Registration.Domain.Repositories;
public interface IExpenseRepository : IBaseRepository<Expense>
{ 
    Task<Expense?> FindByTripIdAsync(int tripId);

}
