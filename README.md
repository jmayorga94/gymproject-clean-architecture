# GymManagement

Minimal Gym Management API built with .NET following Clean Architecture principles.

## What this project is

- Small API for managing gym subscriptions and other domain concepts.
- Solution is in the `src/` folder with projects grouped by responsibility.

## How to run

From the repository root:

```bash
cd src/GymManagement.Api
dotnet run
```

The API project is `GymManagement.Api` (presentation layer).

## Clean Architecture (high-level)

This repository follows a Clean Architecture approach. High-level responsibilities for each layer:

- Presentation (`GymManagement.Api`):
  - Hosts controllers, HTTP endpoints, DTOs and API-specific wiring (routing, filters, authentication).
  - Translates between external representations (JSON) and internal application requests.

- Application (`GymManagement.Application`):
  - Contains use-cases / application services that orchestrate business logic.
  - Depends on abstractions (interfaces) only; coordinates domain entities to fulfill requests.
  - Fetch domain objects

 - Contracts (`GymManagement.Contracts`):
  - Public API contracts (request/response DTOs, enums and small shared types) that define the stable surface between the service and its clients.
  - Designed to be versionable and publishable (for example as a NuGet package or via OpenAPI generation) so external consumers can reuse or generate client code without depending on implementation details.

- Domain (`GymManagement.Domain`):
  - Core business model: entities, value objects, domain services and business rules.
  - No external framework or infrastructure concerns — pure logic and invariants.

- Infrastructure (`GymManagement.Infrastructure`):
  - Concrete implementations for persistence, external APIs, file system, and other I/O.
  - Implements interfaces the application layer depends on.

Key principles:

- Dependencies point inward: outer layers (API, Infrastructure) depend on inner layers (Application, Domain).
- Keep business rules (Domain) framework-agnostic and easy to unit test.

## Patterns applied

- **Clean Architecture** — clear separation into Presentation, Application, Domain and Infrastructure layers; dependencies point inward toward the Domain.
- **Dependency Injection** — composition root lives in the API/Host; services are registered with appropriate lifetimes (`Scoped` for request-scoped services, `Singleton` for global, thread-safe services).
- **Options / Configuration Binding** — configuration is bound to typed POCOs and provided to services via `IOptions<T>` or registered instances to avoid leaking `IConfiguration` into core layers.
- **Repository / Adapter Pattern** — persistence is encapsulated behind repository or adapter interfaces implemented in Infrastructure; Application layer depends on interfaces only.
- **DTOs for API Boundary** — Request/Response DTOs live with the Presentation/Contracts layer; mapping to domain models happens at the boundary.
- **Unit-testable Use-cases** — use-cases in Application are small, orchestrated classes/functions that are easy to unit test (no I/O in the domain or application logic).

## Solution layout

```
src/
  GymManagement.Api/           # Presentation
  GymManagement.Application/   # Application (use-cases)
  GymManagement.Contracts/     # Contracts (request/response DTOs)
  GymManagement.Domain/        # Domain entities and business rules
  GymManagement.Infrastructure/# Persistence and external implementations
```
## Patterns Applied

## CQRS 
    Command Query Responsability segragation 

## What is it?
   Splits reads and writes 
   Splits inot commands and reads
   Example Create Subscription, Delete Subscription
   Queries
   Get Subscription
   Get Room
   In other words not mixing objects that change state with objects that read
## Why?
   So we can split 