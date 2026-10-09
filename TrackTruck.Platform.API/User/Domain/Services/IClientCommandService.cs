using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Domain.Model.Commands;

namespace TrackTruck.Platform.API.User.Domain.Services;

public interface IClientCommandService
{
    Task<Client?> Handle(CreateClientCommand createClientCommand);
    Task<Client?> Handle(UpdateClientCommand updateClientCommand);
}