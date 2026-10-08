namespace TrackTruck.Platform.API.User.Interfaces.REST.Resources;

public record UpdateEntrepreneurResource(string Name, string Ruc, string Address, int UserId);
