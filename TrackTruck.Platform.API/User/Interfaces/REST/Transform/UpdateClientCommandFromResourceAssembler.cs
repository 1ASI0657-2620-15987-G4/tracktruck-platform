using TrackTruck.Platform.API.User.Domain.Model.Commands;
using TrackTruck.Platform.API.User.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.User.Interfaces.REST.Transform;

public static class UpdateClientCommandFromResourceAssembler
{
    public static UpdateClientCommand ToCommandFromResource(UpdateClientResource resource, int clientId)
    {
        return new UpdateClientCommand(clientId, resource.Name, resource.Dni, resource.BirthDate, resource.UserId);
    }
    
}