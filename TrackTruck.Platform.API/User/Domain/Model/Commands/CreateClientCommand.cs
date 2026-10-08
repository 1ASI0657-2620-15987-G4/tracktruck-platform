namespace TrackTruck.Platform.API.User.Domain.Model.Commands;

public record CreateClientCommand(string Name, string Dni, DateTime BirthDate, int UserId);
