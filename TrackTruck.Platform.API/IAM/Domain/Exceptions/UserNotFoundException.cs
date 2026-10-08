namespace TrackTruck.Platform.API.IAM.Domain.Exceptions;

public class UserNotFoundException(int userId)
    : Exception($"No se encontró el usuario con ID {userId}.");
