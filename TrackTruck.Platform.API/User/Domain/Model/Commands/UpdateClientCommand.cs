namespace TrackTruck.Platform.API.User.Domain.Model.Commands;

public record UpdateClientCommand(int ClientId, string Name, string Dni, DateTime BirthDate, int UserId);
