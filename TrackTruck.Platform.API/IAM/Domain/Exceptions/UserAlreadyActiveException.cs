namespace TrackTruck.Platform.API.IAM.Domain.Exceptions;

public class UserAlreadyActiveException(int userId)
    : Exception($"La cuenta del usuario {userId} ya está activa.");
