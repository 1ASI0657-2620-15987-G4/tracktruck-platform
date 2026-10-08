using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IDriverCommandService
{
    Task<Driver?> Handle(CreateDriverCommand command);
    Task<Driver?> Handle(UpdateDriverCommand command);
    Task<Driver?> Handle(UpdateDriverStateCommand command);
}