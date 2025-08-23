# DotNetCoreLibraries

This repository contains the Chinook.API ASP.NET Core Web API project, organized using the Vertical Slice architecture.

## Structure
- `src/Chinook.API` - Main Web API project
  - `Features` - Vertical slices/features
  - `Core` - Core domain logic
  - `Infrastructure` - Infrastructure and data access
- `test` - Test projects

## Getting Started
1. Install .NET 8 SDK or later.
2. Run the API:
   ```sh
   dotnet run --project src/Chinook.API
   ```
3. Access Swagger UI at `https://localhost:5001/swagger` (development mode).

## License
See the LICENSE file for details.
