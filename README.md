# TrackTruck Platform
## Summary
TrackTruck REST API built with Microsoft C#, ASP.NET Core, Entity Framework Core, and MySQL persistence. The codebase follows Domain-Driven Design and exposes OpenAPI documentation through Swagger UI.

## Features
- RESTful API
- OpenAPI Documentation
- Swagger UI
- ASP.NET Framework
- Entity Framework Core
- Audit Creation and Update Date
- Custom Route Naming Conventions
- Custom Object-Relational Mapping Naming Conventions.
- MySQL Database
- Domain-Driven Design

## Bounded Contexts
The platform currently contains IAM, Registration, and User bounded contexts.

### Registration Context

The Registration Context is responsible for managing the registrations made by entrepreneur users. It includes the following features:

- Create a new trip, expense, driver or vehicle.
- Get a trip, expense, driver or vehicle by id.
- Get all trips, expenses, drivers or vehicles.

### User Context

The User Context is responsible for managing the users. It includes the following features:

- Create a new user (client or entrepreneur)
- Get an user by id.
- Get a client by id.
- Get an entrepreneur by id.
- Get all users.
- Get all clients.
- Get all entrepreneurs.

## Local configuration

The repository does not include production credentials. Configure these values through environment variables or .NET user secrets:

```powershell
$env:ConnectionStrings__DefaultConnection = '<mysql-connection-string>'
$env:ConnectionStrings__LocalConnection = '<mysql-connection-string>'
$env:TokenSettings__Secret = '<at-least-64-random-characters>'
dotnet run --project TrackTruck.Platform.API/TrackTruck.Platform.API.csproj
```

Swagger UI is available at `/swagger` when the application is running in a supported development environment.

## Verification

Run the complete executable test suite with:

```powershell
dotnet test TrackTruck.Platform.API.sln --configuration Release
```

`TrackTruck.UnitTests` contains domain unit tests and `TrackTruck.IntegrationTests` contains executable API integration tests. The Gherkin files under `TrackTruck.IntegrationTests/Features` are acceptance specifications; they are retained as documentation and are not presented as automated tests because the imported project did not include SpecFlow step bindings.
