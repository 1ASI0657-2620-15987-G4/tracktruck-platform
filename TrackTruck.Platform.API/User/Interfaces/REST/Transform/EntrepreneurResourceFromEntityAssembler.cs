using TrackTruck.Platform.API.User.Domain.Model.Aggregates;
using TrackTruck.Platform.API.User.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.User.Interfaces.REST.Transform;

public static class EntrepreneurResourceFromEntityAssembler
{
    public static EntrepreneurResource ToResourceFromEntity(Entrepreneur entity)
    {
        return new EntrepreneurResource(
            entity.Id,
            entity.Name,
            entity.Ruc,
            entity.Address,
            entity.UserId);
    }
}
