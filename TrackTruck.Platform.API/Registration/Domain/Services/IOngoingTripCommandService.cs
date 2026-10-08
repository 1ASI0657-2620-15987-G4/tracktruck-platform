using TrackTruck.Platform.API.Registration.Domain.Model.Commands;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IOngoingTripCommandService
{
    Task<OngoingTrip?> Handle(CreateOngoingTripCommand createTripCommand);
    Task<OngoingTrip?> Handle(UpdateOngoingTripCommand updateTripCommand);
}