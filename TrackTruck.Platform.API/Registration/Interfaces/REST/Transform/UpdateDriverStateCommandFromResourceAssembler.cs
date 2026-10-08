using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class UpdateDriverStateCommandFromResourceAssembler
{
    public static UpdateDriverStateCommand ToCommandFromResource(UpdateDriverStateResource resource, int driverId)
    {
        return new UpdateDriverStateCommand(driverId, resource.State);
    }
}
