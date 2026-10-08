using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;
using TrackTruck.Platform.API.Registration.Domain.Model.Commands;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IAuditLogCommandService
{
    Task<AuditLog?> Handle(CreateAuditLogCommand command);
}
