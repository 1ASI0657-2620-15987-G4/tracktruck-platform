namespace TrackTruck.Platform.API.Registration.Domain.Model.Commands;

public record UpdateDriverStateCommand(int DriverId, string State);
