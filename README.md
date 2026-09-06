# WalkBooks

## Be your neighborhood Sidewalk Librarian

### Easily catalog the items you add and borrow from your local sidewalk libraries

WalkBooks is a modern .NET application designed for scalable, cloud-native delivery on Azure.  
It uses a clean architecture layout, containerized API, automated CI/CD, and Azure-managed services.

---

## Architecture Overview

- **API** — .NET Web API
- **Application Layer** — Use cases, orchestrators, service logic
- **Domain Layer** — Entities, value objects, domain rules
- **Infrastructure Layer** — EF Core, storage, external integrations
- **Frontend** — React (Azure Static Web Apps)
- **Storage** — Azure Blob Storage
- **Database** — Azure PostgreSQL Flexible Server
- **Hosting** — Azure App Service for Containers
- **CI/CD** — GitHub Actions
- **Deployment** — **GitHub Actions** > **Container Registry** > **App Service**

---

## WalkBooks Project Structure

Below is an auto-generated directory map (depth: 2).

Regenerate by running GitHub Action Workflow "Update Directory Tree" 
or run locally: `pwsh .\tools\generate-tree.ps1 -Depth 2`.

```
.
├─ .github
│  ├─ workflows
│  │  ├─ api-ci.yml
│  │  └─ update-tree.yml
│  └─ copilot-instructions.md
├─ docker
│  └─ README.md
├─ docs
│  └─ README.md
├─ infra
│  └─ README.md
├─ k8s
│  └─ README.md
├─ scripts
│  └─ README.md
├─ src
│  ├─ Api
│  │  ├─ Properties
│  │  ├─ Api.csproj
│  │  ├─ Api.http
│  │  ├─ appsettings.Development.json
│  │  ├─ appsettings.json
│  │  ├─ Dockerfile
│  │  └─ Program.cs
│  ├─ Application
│  │  ├─ Application.csproj
│  │  └─ Class1.cs
│  ├─ Domain
│  │  ├─ Class1.cs
│  │  └─ Domain.csproj
│  └─ Infrastructure
│     ├─ Class1.cs
│     └─ Infrastructure.csproj
├─ tests
│  └─ README.md
├─ tools
│  ├─ generate-tree.ps1
│  └─ README.md
├─ .gitattributes
├─ .gitignore
├─ LICENSE.txt
├─ README.md
├─ tree.tmp
└─ WalkBooks.slnx
```



