# Architecture — Patterns applied (high level)

This file lists the main architectural patterns used in the project. Each entry is short and follows: What it is, When to use it, How it fits this repo.

## Clean Architecture
- What it is: a layered approach that separates Presentation, Application, Domain and Infrastructure concerns.
- When to use: when you want clear boundaries, testability, and maintainable dependency rules.
- How it fits this repo: the solution groups projects by layer (Api, Application, Domain, Infrastructure) and keeps dependencies pointing inward.

## Dependency Injection
- What it is: a composition pattern where dependencies are provided to classes instead of constructed inside them.
- When to use: always in modern backend services to enable loose coupling and easier testing.
- How it fits this repo: services and repositories are registered at the composition root (`GymManagement.Api`) and injected into handlers/controllers.

## Options / Configuration Binding
- What it is: bind configuration sections to typed POCOs (and consume via `IOptions<T>` or concrete instances).
- When to use: when you want typed, testable settings without leaking `IConfiguration` into core layers.
- How it fits this repo: settings are bound and registered in the API; Application code consumes typed settings or an abstraction.

## Repository / Adapter
- What it is: encapsulate persistence behind interfaces; adapters implement those interfaces for concrete stores.
- When to use: to isolate domain and application logic from database details and to simplify testing.
- How it fits this repo: repository interfaces live with the Application/Contracts and implementations live in Infrastructure.

## CQRS (pragmatic)
- What it is: separate Commands (writes) from Queries (reads); handlers orchestrate use-cases.
- When to use: when read/write concerns diverge, or when you need clearer command handling; avoid for simple CRUD unless helpful.
- How it fits this repo: command/query handlers belong in `GymManagement.Application`; controllers map DTOs to commands/queries.

## DTOs at the API boundary
- What it is: use simple Request/Response DTOs for the external API surface.
- When to use: always at the boundary to decouple external contracts from internal models.
- How it fits this repo: DTOs and Contracts define the API surface and mapping occurs in the Presentation layer.

---
