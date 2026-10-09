using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Registration.Domain.Services;

namespace TrackTruck.Platform.API.Registration.Application.Internal.QueryServices;

public class DriverQueryService(IDriverRepository driverRepository)
    : IDriverQueryService
{
    public async Task<Driver?> Handle(GetDriverByIdQuery query)
    {
        return await driverRepository.FindByIdAsync(query.DriverId);
    }
    
    public async Task<IEnumerable<Driver>> Handle(GetAllDriversQuery query)
    {
        return await driverRepository.ListAsync();
    }

    public async Task<IEnumerable<Driver>> Handle(GetDriversByEntrepreneurIdQuery query)
    {
        return await driverRepository.FindByEntrepreneurIdAsync(query.EntrepreneurId);
    }
}

