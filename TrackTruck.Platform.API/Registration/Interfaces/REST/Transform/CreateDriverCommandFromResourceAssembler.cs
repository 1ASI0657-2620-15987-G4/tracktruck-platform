using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class CreateDriverCommandFromResourceAssembler
{
    public static CreateDriverCommand ToCommandFromResource(CreateDriverResource resource)
    {
        return new CreateDriverCommand(resource.Name, resource.Dni, resource.License, resource.ContactNumber, resource.EntrepreneurId);
    }
}