namespace TrackTruck.Platform.API.IAM.Domain.Model.Commands;

public record UpdateUserStateCommand(int UserId, bool State);
