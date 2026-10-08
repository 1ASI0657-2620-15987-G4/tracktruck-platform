using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;
namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IAlertQueryService
{
    Task<Alert?> Handle(GetAlertByIdQuery query);
    Task<IEnumerable<Alert>> Handle(GetAllAlertsQuery query);
}