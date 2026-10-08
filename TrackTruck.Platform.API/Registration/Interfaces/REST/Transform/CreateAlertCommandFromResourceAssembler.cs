using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class CreateAlertCommandFromResourceAssembler
{
    public static CreateAlertCommand ToCommandFromResource(CreateAlertResource resource)
    {
        return new CreateAlertCommand(resource.Title, resource.Type, resource.Description, resource.Date, resource.TripId);
    }
}