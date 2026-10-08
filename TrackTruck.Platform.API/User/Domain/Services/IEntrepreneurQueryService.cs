using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Domain.Model.Queries;

namespace TrackTruck.Platform.API.User.Domain.Services;

public interface IEntrepreneurQueryService
{
    Task<IEnumerable<Entrepreneur>> Handle(GetAllEntrepreneursQuery query);
    Task<Entrepreneur?> Handle(GetEntrepreneurByIdQuery query);
    Task<Entrepreneur?> Handle(GetEntrepreneurByUserIdQuery query);
}