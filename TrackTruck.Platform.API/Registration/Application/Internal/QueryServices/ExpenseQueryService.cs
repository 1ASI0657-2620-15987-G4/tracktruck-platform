using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Registration.Domain.Services;

namespace TrackTruck.Platform.API.Registration.Application.Internal.QueryServices;

public class ExpenseQueryService(IExpenseRepository expenseRepository)
    : IExpenseQueryService
{
    public async Task<Expense?> Handle(GetExpenseByIdQuery query)
    {
        return await expenseRepository.FindByIdAsync(query.ExpenseId);
    }
    
    public async Task<IEnumerable<Expense>> Handle(GetAllExpensesQuery query)
    {
        return await expenseRepository.ListAsync();
    }
}