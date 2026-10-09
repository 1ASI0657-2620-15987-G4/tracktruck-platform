namespace TrackTruck.Platform.API.Registration.Interfaces.REST.Resources;

public record DriverResource(int Id, string Name, string Dni, string License, string ContactNumber, string State, int EntrepreneurId);