using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IAlertCommandService
{
    Task<Alert?> Handle(CreateAlertCommand command);
    Task<Alert?> Handle(UpdateAlertCommand command);
}