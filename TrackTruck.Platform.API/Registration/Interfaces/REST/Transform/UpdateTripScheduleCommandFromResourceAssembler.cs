using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class UpdateTripScheduleCommandFromResourceAssembler
{
    public static UpdateTripScheduleCommand ToCommandFromResource(UpdateTripScheduleResource resource, int tripId)
    {
        return new UpdateTripScheduleCommand(
            tripId,
            resource.LoadLocation,
            resource.LoadDate,
            resource.UnloadLocation,
            resource.UnloadDate);
    }
}
