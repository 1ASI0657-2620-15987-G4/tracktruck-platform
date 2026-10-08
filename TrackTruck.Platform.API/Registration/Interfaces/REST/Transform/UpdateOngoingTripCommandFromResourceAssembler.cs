using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class UpdateOngoingTripCommandFromResourceAssembler
{
    public static UpdateOngoingTripCommand ToCommandFromResource(UpdateOngoingTripResource resource, int ongoingTripId)
    {
        return new UpdateOngoingTripCommand(ongoingTripId, resource.Latitude, resource.Longitude, resource.Speed, resource.Distance, resource.TripId);
    }
}