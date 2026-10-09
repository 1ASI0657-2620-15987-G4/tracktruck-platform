using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Registration.Domain.Services;

namespace TrackTruck.Platform.API.Registration.Application.Internal.QueryServices;

public class VehicleQueryService(IVehicleRepository vehicleRepository)
    : IVehicleQueryService
{
    public async Task<Vehicle?> Handle(GetVehicleByIdQuery query)
    {
        return await vehicleRepository.FindByIdAsync(query.VehicleId);
    }
    
    public async Task<IEnumerable<Vehicle>> Handle(GetAllVehiclesQuery query)
    {
        return await vehicleRepository.ListAsync();
    }

    public async Task<IEnumerable<Vehicle>> Handle(GetVehiclesByEntrepreneurIdQuery query)
    {
        return await vehicleRepository.FindByEntrepreneurIdAsync(query.EntrepreneurId);
    }
}