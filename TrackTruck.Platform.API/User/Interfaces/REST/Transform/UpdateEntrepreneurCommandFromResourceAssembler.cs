using TrackTruck.Platform.API.User.Domain.Model.Commands;
using TrackTruck.Platform.API.User.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.User.Interfaces.REST.Transform;

public static class UpdateEntrepreneurCommandFromResourceAssembler
{
    public static UpdateEntrepreneurCommand ToCommandFromResource(UpdateEntrepreneurResource resource, int entrepreneurId)
    {
        return new UpdateEntrepreneurCommand(entrepreneurId, resource.Name, resource.Ruc, resource.Address, resource.UserId);
    }
}
