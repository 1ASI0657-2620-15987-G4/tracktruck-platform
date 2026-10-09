using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Domain.Model.Queries;

namespace TrackTruck.Platform.API.User.Domain.Services;

public interface IClientQueryService
{
    Task<IEnumerable<Client>> Handle(GetAllClientsQuery query);
    Task<Client?> Handle(GetClientByIdQuery query);
    Task<Client?> Handle(GetClientByUserIdQuery query);
    Task<Client?> Handle(GetClientByDniQuery query);
}