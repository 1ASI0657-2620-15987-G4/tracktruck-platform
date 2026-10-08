using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;
using TrackTruck.Platform.API.Registration.Domain.Repositories;
using TrackTruck.Platform.API.Registration.Domain.Services;

namespace TrackTruck.Platform.API.Registration.Application.Internal.QueryServices;

public class AuditLogQueryService(IAuditLogRepository auditLogRepository)
    : IAuditLogQueryService
{
    public async Task<IEnumerable<AuditLog>> Handle(GetAllAuditLogsQuery query)
    {
        return await auditLogRepository.ListAsync();
    }

    public async Task<AuditLog?> Handle(GetAuditLogByIdQuery query)
    {
        return await auditLogRepository.FindByIdAsync(query.AuditLogId);
    }

    public async Task<IEnumerable<AuditLog>> Handle(GetAuditLogsByEntrepreneurIdQuery query)
    {
        return await auditLogRepository.FindByEntrepreneurIdAsync(query.EntrepreneurId);
    }

    public async Task<IEnumerable<AuditLog>> Handle(GetAuditLogsByEntrepreneurIdAndEntityTypeQuery query)
    {
        return await auditLogRepository.FindByEntrepreneurIdAndEntityTypeAsync(query.EntrepreneurId, query.EntityType);
    }
}
