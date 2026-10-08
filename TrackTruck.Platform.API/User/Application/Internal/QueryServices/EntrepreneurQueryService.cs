using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Domain.Model.Queries;
using TrackTruck.Platform.API.User.Domain.Repositories;
using TrackTruck.Platform.API.User.Domain.Services;

namespace TrackTruck.Platform.API.User.Application.Internal.QueryServices;

public class EntrepreneurQueryService(IEntrepreneurRepository entrepreneurRepository) : IEntrepreneurQueryService
{
    public async Task<IEnumerable<Entrepreneur>> Handle(GetAllEntrepreneursQuery query)
    {
        return await entrepreneurRepository.ListAsync();
    }
    
    public async Task<Entrepreneur?> Handle(GetEntrepreneurByIdQuery query)
    {
        return await entrepreneurRepository.FindByIdAsync(query.EntrepreneurId);
    }
    
    public async Task<Entrepreneur?> Handle(GetEntrepreneurByUserIdQuery query)
    {
        return await entrepreneurRepository.FindByUserIdAsync(query.UserId);
    }
}
