using TrackTruck.Platform.API.IAM.Domain.Model.Commands;
using TrackTruck.Platform.API.IAM.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.IAM.Interfaces.REST.Transform;

public static class SignInCommandFromResourceAssembler
{
    public static SignInCommand ToCommandFromResource(SignInResource resource)
    {
        return new SignInCommand(resource.Username, resource.Password);
    }
}