using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;
namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class OngoingTripResourceFromEntityAssembler
{
    public static OngoingTripResource ToResourceFromEntity(OngoingTrip entity)
    {
        return new OngoingTripResource(entity.Id, entity.Latitude, entity.Longitude, entity.Speed, entity.Distance, entity.TripId);
    }
}