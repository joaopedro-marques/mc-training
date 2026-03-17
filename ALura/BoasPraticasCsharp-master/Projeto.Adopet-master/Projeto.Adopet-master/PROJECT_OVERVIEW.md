# Project Overview

This repository contains the **Alura Adopet** sample project, a simple
application that demonstrates good C# coding practices. It is divided into
two main parts:

## 1. API (`Alura.Adopet.API`)
* **Purpose** – Exposes a RESTful API for managing pets and clients.
* **Key components** –
  * Controllers (`PetController.cs`) handling HTTP requests.
  * Domain models (`Cliente.cs`, `Pet.cs`, `TipoPet.cs`).
  * Entity Framework Core data context (`DataBaseContext.cs`).
  * Service layer (`EventoService.cs`, `IEventoService.cs`).
* **Configuration** – `appsettings.json` and `Program.cs` set up the web host
  and logging (Serilog).

## 2. Console Application (`Alura.Adopet.Console`)
* **Purpose** – Provides a command‑line interface to interact with the API.
* **Key files** –
  * `Program.cs` – entry point that parses commands.
  * `DocComando.cs`, `Help.cs`, `Import.cs`, `LeitorDeArquivo.cs` – utilities
    for handling user input and file operations.
  * `Pet.cs`, `TipoPet.cs` – simple DTOs used by the console client.

## Project Structure
```
Alura.Adopet.API/          # ASP.NET Core Web API
Alura.Adopet.Console/      # .NET console client
Alura.Adopet.sln           # Solution file
```

The solution follows clean architecture principles, separating concerns between
the API layer, domain models, and data access. It serves as a learning resource
for best practices in C# development, including unit testing, logging, and
dependency injection.

Feel free to explore the code, run the API with `dotnet run` inside the API
project folder, and use the console application to issue commands such as
listing pets or adding a new client.

