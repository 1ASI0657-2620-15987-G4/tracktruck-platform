using TrackTruck.Platform.API.IAM.Domain.Model.Commands;
using TrackTruck.Platform.API.IAM.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.IAM.Interfaces.REST.Transform;

public static class SignUpCommandFromResourceAssembler
{
    public static SignUpCommand ToCommandFromResource(SignUpResource resource)
    {
        return new SignUpCommand(
            resource.Username,
            resource.Password,
            resource.Phone,
            resource.Role,
            resource.Profile?.Name ?? string.Empty,
            resource.Profile?.Dni,
            resource.Profile?.BirthDate,
            resource.Profile?.Ruc,
            resource.Profile?.Address);
    }
}
