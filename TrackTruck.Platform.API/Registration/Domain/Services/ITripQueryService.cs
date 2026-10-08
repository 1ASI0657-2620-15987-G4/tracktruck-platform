using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;
using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;
using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Domain.Model.Queries;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface ITripQueryService
{
    Task<IEnumerable<Trip>> Handle(GetAllTripsQuery query);
    Task<Trip?> Handle(GetTripByIdQuery query);
    Task<Expense?> Handle(GetExpensesByTripIdQuery query);
    Task<IEnumerable<Alert>> Handle(GetAlertsByOngoingTripIdQuery query);
    Task<OngoingTrip?> Handle(GetOngGoingTripByIdQuery query);
    Task<IEnumerable<Trip>> Handle(GetTripsByClientIdQuery query);
    Task<IEnumerable<Trip>> Handle(GetTripsByEntrepreneurIdQuery query);
    Task<IEnumerable<Client>> Handle(GetClientsByEntrepreneurId query);
}