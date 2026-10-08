using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IAuditLogQueryService
{
    Task<IEnumerable<AuditLog>> Handle(GetAllAuditLogsQuery query);
    Task<AuditLog?> Handle(GetAuditLogByIdQuery query);
    Task<IEnumerable<AuditLog>> Handle(GetAuditLogsByEntrepreneurIdQuery query);
    Task<IEnumerable<AuditLog>> Handle(GetAuditLogsByEntrepreneurIdAndEntityTypeQuery query);
}
