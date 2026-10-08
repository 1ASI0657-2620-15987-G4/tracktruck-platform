using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class DriverResourceFromEntityAssembler
{
    public static DriverResource ToResourceFromEntity(Driver entity)
    {
        return new DriverResource(
            entity.Id,
            entity.Name,
            entity.Dni,
            entity.License,
            entity.ContactNumber,
            entity.State,
            entity.EntrepreneurId);
    }
}