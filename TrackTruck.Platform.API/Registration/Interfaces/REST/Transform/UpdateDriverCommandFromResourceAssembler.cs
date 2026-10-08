using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class UpdateDriverCommandFromResourceAssembler
{ 
    public static UpdateDriverCommand ToCommandFromResource(UpdateDriverResource resource, int driverId)
    {
        return new UpdateDriverCommand(driverId, resource.Name, resource.ContactNumber);
    }
}