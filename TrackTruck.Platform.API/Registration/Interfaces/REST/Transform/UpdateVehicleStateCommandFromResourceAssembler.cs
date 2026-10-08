using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class UpdateVehicleStateCommandFromResourceAssembler
{
    public static UpdateVehicleStateCommand ToCommandFromResource(UpdateVehicleStateResource resource, int vehicleId)
    {
        return new UpdateVehicleStateCommand(vehicleId, resource.State);
    }
}
