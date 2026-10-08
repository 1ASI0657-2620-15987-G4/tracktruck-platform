using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IVehicleCommandService
{
    Task<Vehicle?> Handle(CreateVehicleCommand createVehicleCommand);
    Task<Vehicle?> Handle(UpdateVehicleCommand updateVehicleCommand);
    Task<Vehicle?> Handle(UpdateVehicleStateCommand updateVehicleStateCommand);
}