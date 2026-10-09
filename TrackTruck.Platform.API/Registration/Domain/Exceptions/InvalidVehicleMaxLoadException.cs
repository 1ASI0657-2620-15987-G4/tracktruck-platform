namespace TrackTruck.Platform.API.Registration.Domain.Exceptions;

public class InvalidVehicleMaxLoadException()
    : Exception("La carga máxima del vehículo no puede estar vacía.");
