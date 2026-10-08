using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class UpdateTripDetailsCommandFromResourceAssembler
{
    public static UpdateTripDetailsCommand ToCommandFromResource(UpdateTripDetailsResource resource, int tripId)
    {
        return new UpdateTripDetailsCommand(
            tripId,
            resource.Name,
            resource.Type,
            resource.Weight,
            resource.DriverId,
            resource.VehicleId,
            resource.ClientId);
    }
}
