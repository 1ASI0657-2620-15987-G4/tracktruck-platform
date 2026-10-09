using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Domain.Model.Commands;

namespace TrackTruck.Platform.API.User.Domain.Services;

public interface IEntrepreneurCommandService
{
    Task<Entrepreneur?> Handle(CreateEntrepreneurCommand createEntrepreneurCommand);
    Task<Entrepreneur?> Handle(UpdateEntrepreneurCommand updateEntrepreneurCommand);
}