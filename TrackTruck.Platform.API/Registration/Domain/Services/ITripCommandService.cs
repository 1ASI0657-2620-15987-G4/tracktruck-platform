using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;
using TrackTruck.Platform.API.Registration.Domain.Model.Commands;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface ITripCommandService
{
    Task<Trip?> Handle(CreateTripCommand createTripCommand);
    Task<Trip?> Handle(UpdateTripDetailsCommand command);
    Task<Trip?> Handle(UpdateTripScheduleCommand command);
    Task<Trip?> Handle(UpdateTripStateCommand updateTripStateCommand);
}