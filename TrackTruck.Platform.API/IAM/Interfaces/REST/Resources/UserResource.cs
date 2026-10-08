namespace TrackTruck.Platform.API.IAM.Interfaces.REST.Resources;

public record UserResource(int Id, string Username, string Phone, bool State, DateTime ModifiedAt);