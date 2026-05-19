# PlantCare

PlantCare is a .NET learning project built to practice applied
architecture, starting with CQRS and later evolving into Event Sourcing,
pipeline validation, optimized reads, and more domain-oriented testing.

The goal is not just to "make it work". The idea is to use a simple plant
care domain to study architectural decisions intentionally, comparing new
concepts with real-world C#/.NET backend scenarios.

## Purpose

This repository is part of a study plan focused on:

- practicing CQRS with a clear separation between write and read flows
- evolving into Event Sourcing with aggregate rehydration
- exercising validation, testing, and layered organization
- building a solid base for later studying Saga, projections, and
  snapshots

## Current Stage

The project is currently in **Stage 1**, with the initial solution
scaffold in place and the focus on implementing the first CQRS flow.

Planned next step:

- `RegisterPlantCommand`
- command handler
- FluentValidation validator
- unit test for the use case

## Stack

- .NET 10
- ASP.NET Core Web API
- C#
- xUnit

Planned stack for the next stages:

- MediatR
- FluentValidation
- EF Core on the write side
- Dapper on the read side
- SQL Server
- NSubstitute
- FluentAssertions

## Current Structure

```text
PlantCare.Api/
PlantCare.Application/
PlantCare.Domain/
PlantCare.Infrastructure/
PlantCare.UnitTests/
PlantCare.slnx
```

Project responsibilities:

- `PlantCare.Api`: HTTP entrypoint and application composition
- `PlantCare.Application`: use cases, commands, queries, and behaviors
- `PlantCare.Domain`: entities, core rules, and domain events
- `PlantCare.Infrastructure`: persistence and external integrations
- `PlantCare.UnitTests`: unit tests for use cases and domain behavior

## Study Roadmap

### Phase 1: Pure CQRS

- register a plant
- register watering
- query plant details
- query plants that are due for watering
- add logging and validation pipeline behaviors

### Phase 2: Event Sourcing

- turn `Plant` into an event-driven aggregate
- persist events in an append-only event store
- rebuild state through rehydration
- create a projected read model for queries

### Phase 3: Extras

- study Saga for reminder and confirmation flows
- overdue plant notifications
- snapshots
- tests driven by event history

## Running the Project

### Prerequisites

- .NET 10 SDK

### Restore dependencies

```bash
dotnet restore
```

### Run the API

```bash
dotnet run --project PlantCare.Api
```

### Run tests

```bash
dotnet test
```

## Current Code Status

At this point the solution is still at a very early stage:

- the API is still using the default ASP.NET Core template
- the layers have been created, but the domain model is not implemented yet
- the core architectural packages planned for this study are still to be
  added

This README is meant to reflect the real purpose of the repository and
the current implementation status, without implying an architecture that
has not been coded yet.

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE).
