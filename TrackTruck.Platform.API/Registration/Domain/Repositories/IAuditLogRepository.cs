using TrackTruck.Platform.API.Registration.Domain.Model.Aggregates;

namespace TrackTruck.Platform.API.Registration.Domain.Repositories;

public interface IAuditLogRepository
{
    Task AddAsync(AuditLog auditLog);
    Task<AuditLog?> FindByIdAsync(Guid id);
    Task<IEnumerable<AuditLog>> ListAsync();
    Task<IEnumerable<AuditLog>> FindByEntrepreneurIdAsync(int entrepreneurId);
    Task<IEnumerable<AuditLog>> FindByEntrepreneurIdAndEntityTypeAsync(int entrepreneurId, string entityType);
}
