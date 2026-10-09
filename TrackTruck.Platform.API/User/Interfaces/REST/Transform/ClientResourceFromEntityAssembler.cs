using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.User.Interfaces.REST.Transform;

public static class ClientResourceFromEntityAssembler
{
    public static ClientResource ToResourceFromEntity(Client entity)
    {
        return new ClientResource(
            entity.Id,
            entity.Name,
            entity.Dni,
            entity.BirthDate,
            entity.UserId);
    }
}