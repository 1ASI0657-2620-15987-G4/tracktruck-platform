using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class CreateOngoingTripCommandFromResourceAssembler
{
    public static CreateOngoingTripCommand ToCommandFromResource(CreateOngoingTripResource resource)
    {
        return new CreateOngoingTripCommand(resource.Latitude, resource.Longitude, resource.Speed, resource.Distance, resource.TripId);
    }
}