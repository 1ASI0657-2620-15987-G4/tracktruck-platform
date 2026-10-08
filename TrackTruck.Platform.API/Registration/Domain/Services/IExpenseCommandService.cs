using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IExpenseCommandService
{
    Task<Expense?> Handle(CreateExpenseCommand createTripCommand);
    Task<Expense?> Handle(UpdateExpenseCommand updateTripCommand);
    Task<Expense?> Handle(UpdateExpenseStateCommand command);
}