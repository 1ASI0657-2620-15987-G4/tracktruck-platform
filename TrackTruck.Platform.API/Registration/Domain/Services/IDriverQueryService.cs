using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Domain.Model.Queries;

namespace TrackTruck.Platform.API.Registration.Domain.Services;

public interface IDriverQueryService
{
    Task<Driver?> Handle(GetDriverByIdQuery query);
    Task<IEnumerable<Driver>> Handle(GetAllDriversQuery query);
    Task<IEnumerable<Driver>> Handle(GetDriversByEntrepreneurIdQuery query);
}