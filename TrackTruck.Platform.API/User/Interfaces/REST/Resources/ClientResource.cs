namespace TrackTruck.Platform.API.User.Interfaces.REST.Resources;

public record ClientResource(int Id, string Name, string Dni, DateTime BirthDate, int UserId);
