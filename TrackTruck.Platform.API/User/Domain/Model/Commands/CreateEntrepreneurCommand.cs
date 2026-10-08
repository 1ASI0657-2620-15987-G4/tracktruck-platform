namespace TrackTruck.Platform.API.User.Domain.Model.Commands;

public record CreateEntrepreneurCommand(string Name, string Ruc, string Address, int UserId);
