using TrackTruck.Platform.API.Registration.Domain.Model.Entities;
using TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Transform;

public static class VehicleResourceFromEntityAssembler
{
    public static VehicleResource ToResourceFromEntity(Vehicle entity)
    {
        return new VehicleResource(
            entity.Id,
            entity.Name,
            entity.Model,
            entity.Plate,
            entity.TractorPlate,
            entity.MaxLoad,
            entity.Volume,
            entity.State,
            entity.EntrepreneurId);
    }
}