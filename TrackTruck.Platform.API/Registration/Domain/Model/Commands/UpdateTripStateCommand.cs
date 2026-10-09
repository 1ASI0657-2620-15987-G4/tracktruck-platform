namespace TrackTruck.Platform.API.Registration.Domain.Model.Commands;

public record UpdateTripStateCommand(int TripId, string State);
