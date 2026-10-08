using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class ExpenseResourceFromEntityAssembler
{
    public static ExpenseResource ToResourceFromEntity(Expense entity)
    {
        return new ExpenseResource(entity.Id, entity.FuelAmount, entity.FuelDescription, entity.ViaticsAmount,
            entity.ViaticsDescription, entity.TollsAmount, entity.TollsDescription, entity.TripId, entity.State);
    }
}