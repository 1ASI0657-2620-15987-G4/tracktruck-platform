using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IExpenseQueryService
{
    Task<Expense?> Handle(GetExpenseByIdQuery query);
    Task<IEnumerable<Expense>> Handle(GetAllExpensesQuery query);
}