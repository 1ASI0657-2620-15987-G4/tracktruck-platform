namespace TrackTruck.Platform.API.Registration.Domain.Exceptions;

public class DriverNameTooLongException()
    : Exception("El nombre del conductor no puede superar los 60 caracteres.");
