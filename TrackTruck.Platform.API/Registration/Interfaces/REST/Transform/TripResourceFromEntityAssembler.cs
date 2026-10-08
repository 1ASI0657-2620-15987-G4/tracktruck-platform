using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class TripResourceFromEntityAssembler
{
    public static TripResource ToResourceFromEntity(Trip entity)
    {
        return new TripResource(
            entity.Id,
            entity.Name,
            entity.Type,
            entity.Weight,
            entity.LoadLocation,
            entity.LoadDate,
            entity.UnloadLocation,
            entity.UnloadDate,
            entity.DriverId,
            entity.VehicleId,
            entity.ClientId,
            entity.EntrepreneurId,
            entity.State);
    }
}