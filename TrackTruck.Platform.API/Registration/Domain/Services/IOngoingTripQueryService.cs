using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IOngoingTripQueryService
{
    Task<OngoingTrip?> Handle(GetOnGoingTripByIdQuery query);
    Task<IEnumerable<OngoingTrip>> Handle(GetAllOngoingTripsQuery query);
}