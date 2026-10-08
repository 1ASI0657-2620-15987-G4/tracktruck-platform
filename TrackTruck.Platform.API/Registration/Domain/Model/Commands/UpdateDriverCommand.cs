namespace TrackTruck.Platform.API.Registration.Domain.Model.Commands;

public record UpdateDriverCommand(int DriverId, string Name, string ContactNumber);