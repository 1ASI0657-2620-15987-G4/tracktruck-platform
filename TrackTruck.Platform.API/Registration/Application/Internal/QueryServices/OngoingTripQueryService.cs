using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Registration.Domain.Services;

namespace TrackTruck.Platform.API.Registration.Application.Internal.QueryServices;

public class OngoingTripQueryService(IOngoingTripRepository ongoingTripRepository)
    : IOngoingTripQueryService
{
    public async Task<OngoingTrip?> Handle(GetOnGoingTripByIdQuery query)
    {
        return await ongoingTripRepository.FindByIdAsync(query.OngoingTripId);
    }
    
    public async Task<IEnumerable<OngoingTrip>> Handle(GetAllOngoingTripsQuery query)
    {
        return await ongoingTripRepository.ListAsync();
    }
}
