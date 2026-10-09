using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IVehicleQueryService
{
    Task<Vehicle?> Handle(GetVehicleByIdQuery query);
    Task<IEnumerable<Vehicle>> Handle(GetAllVehiclesQuery query);
    Task<IEnumerable<Vehicle>> Handle(GetVehiclesByEntrepreneurIdQuery query);
}