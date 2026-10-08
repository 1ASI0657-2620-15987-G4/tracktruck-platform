using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Domain.Model.Queries;
using TrackTruck.Platform.API.User.Domain.Repositories;
using TrackTruck.Platform.API.User.Domain.Services;

namespace TrackTruck.Platform.API.User.Application.Internal.QueryServices;

public class ClientQueryService(IClientRepository clientRepository) : IClientQueryService
{
    public async Task<IEnumerable<Client>> Handle(GetAllClientsQuery query)
    {
        return await clientRepository.ListAsync();
    }
    
    public async Task<Client?> Handle(GetClientByIdQuery query)
    {
        return await clientRepository.FindByIdAsync(query.ClientId);
    }

    public async Task<Client?> Handle(GetClientByUserIdQuery query)
    {
        return await clientRepository.FindByUserIdAsync(query.UserId);
    }
    public async Task<Client?> Handle(GetClientByDniQuery query)
        => await clientRepository.FindByDniAsync(query.Dni);
}