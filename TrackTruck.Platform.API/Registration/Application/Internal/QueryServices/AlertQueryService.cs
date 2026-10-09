using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Registration.Domain.Services;

namespace TrackTruck.Platform.API.Registration.Application.Internal.QueryServices;

public class AlertQueryService(IAlertRepository alertRepository)
    : IAlertQueryService
{
    public async Task<Alert?> Handle(GetAlertByIdQuery query)
    {
        return await alertRepository.FindByIdAsync(query.AlertId);
    }
    
    public async Task<IEnumerable<Alert>> Handle(GetAllAlertsQuery query)
    {
        return await alertRepository.ListAsync();
    }
}
