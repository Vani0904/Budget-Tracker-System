<a id="readme-top"></a>

# Budget Tracker System

A responsive C#/.NET web application for recording income and expenses, organising transactions by category, and viewing personal financial summaries.

![Status](https://img.shields.io/badge/status-in%20development-orange)
> This project is currently under development. The README and feature list will be updated as new functionality is completed.

## Technology Stack

The planned technology stack is:
* [![C#][C#]][C#-url]
* [![.NET][.NET]][.NET-url]
* [![Blazor][Blazor]][Blazor-url]
* [![SQLite][SQLite]][SQLite-url]
- SQLite will be used during early local development.
* [![Postgres][Postgres]][Postgres-url]
- PostgreSQL may be introduced later when the application is containerised or deployed.

The stack may change as the project develops. The README will reflect the technologies actually used by the current version.

## Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Testing](#testing)
- [Roadmap](#roadmap)
- [Known Limitations](#known-limitations)
- [Contact](#contact)
- [License](#license)

## About the Project

The Budget Tracker System is being developed as a practical full-stack project for managing personal income and expenses.

The project is also being used as a learning vehicle to practise:

- Object-oriented programming.
- Clean separation of responsibilities.
- Data validation.
- Database persistence.
- Web application development.
- Automated testing.
- Responsive user-interface design.

The initial version focuses on recording transactions and calculating useful financial summaries. More advanced features will be added gradually after the core functionality is stable.

## Product Goal

Budget Tracker System helps an individual record income and expenses, understand where money is going, set simple monthly spending limits, and review their financial position over time.

The first version focuses on clarity and manual control rather than bank integrations or financial advice.

## Minimum Viable Product

The first usable version will allow a signed-in user to:

- Add income and expense transactions.
- Select from a small set of spending categories.
- Record a description, amount and date.
- View transaction history.
- See total income, total expenses and current balance.
- Create simple monthly category budgets.
- Compare actual spending against each budget.
- Use the application comfortably on desktop and mobile browsers.

## Out of Scope for the MVP

The following are deliberately deferred:

- Automatic bank synchronisation.
- Automatic transaction categorisation.
- Push notifications.
- Subscription cancellation recommendations.
- Investment, lending or credit products.
- Financial forecasting or personalised financial advice.
- Shared household accounts.
- Native iOS/Android App Store distribution.
  
## Project Status

Current status: `Early development`

Planned development stages:

- [ ] Define the minimum viable product.
- [ ] Create the core transaction model.
- [ ] Add transaction validation.
- [ ] Persist transactions in a database.
- [ ] Build the transaction management interface.
- [ ] Add income, expense and balance summaries.
- [ ] Add filtering by date and category.
- [ ] Add automated tests.
- [ ] Improve responsive design.
- [ ] Deploy a demonstration version.

## Features

### Planned core features

- Create income and expense transactions.
- Assign transactions to categories.
- Record transaction dates and notes.
- View a list of transactions.
- Filter transactions by category and date.
- Calculate total income.
- Calculate total expenses.
- Calculate the current balance.
- Display useful monthly summaries.

Features marked as planned may not yet be implemented.

The stack may change as the project develops. The README will reflect the technologies actually used by the current version.

## Project Structure

The project is being organised around separate responsibilities:

```text
BudgetTracker/
├── src/
│   └── BudgetTracker.Console/
├── tests/
│   └── BudgetTracker.Tests/
├── docs/
│   ├── mvp.md
│   ├── user-flows.md
│   ├── domain-model.md
│   ├── decisions.md
│   └── wireframes/
└── README.md
```

The exact structure may change while the project is being developed. The aim is to keep domain rules, application logic, persistence and user-interface concerns separate.

## Getting Started

### Prerequisites

Install the following tools:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)
- QL

Check that .NET is installed:

```bash
dotnet --version
```

### Clone the repository

```bash
git clone [https://github.com/Vani0904/Budget-Tracker-System.git](https://github.com/Vani0904/Budget-Tracker-System.git)
cd Budget-Tracker-System
```

### Restore dependencies

```bash
dotnet restore
```

### Configure the application

Create or update the local configuration file required by the project.

Do not commit passwords, connection strings containing credentials or other secrets to GitHub.

Example development configuration:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "your-local-development-connection-string"
  }
}
```

### Run the application

```bash
dotnet run
```

Open the local URL shown in the terminal.

> These commands will be updated once the application structure and database configuration are complete.

## Usage

The intended user flow is:

1. Open the application.
2. Add an income or expense transaction.
3. Select a category.
4. Enter the amount and date.
5. Save the transaction.
6. Review the updated balance and summaries.
7. Filter transactions when reviewing spending.

Screenshots and usage instructions will be added when the first working interface is complete.

## Testing

The project will use automated tests for important domain and application behaviour.

Planned test cases include:

- Adding an income transaction.
- Adding an expense transaction.
- Calculating the current balance.
- Rejecting invalid or zero amounts.
- Filtering by category.
- Filtering by date range.
- Calculating summaries for an empty dataset.
- Preventing one user from accessing another user's transactions.

Run tests with:

```bash
dotnet test
```

## Roadmap

## Roadmap

### Phase 0 — Product definition
- [ ] Finalise MVP scope.
- [ ] Define user stories and success criteria.
- [ ] Create low-fidelity mobile-first wireframes.
- [ ] Define core entities and business rules.
- [ ] Record key technical decisions in `docs/decisions.md`.

### Phase 1 — Core C# domain
- [ ] Create a console application.
- [ ] Add `Transaction`, `Category` and `MonthlyBudget` models.
- [ ] Validate amounts, dates and required descriptions.
- [ ] Calculate income, expenses and balance in memory.

### Phase 2 — Budgets and reporting rules
- [ ] Add category spending totals.
- [ ] Add monthly budget limits.
- [ ] Calculate remaining/overspent category amounts.
- [ ] Add monthly summary calculations.

### Phase 3 — Persistence
- [ ] Add EF Core with SQLite.
- [ ] Create and apply migrations.
- [ ] Persist transactions, categories and budgets.
- [ ] Seed default categories.

### Phase 4 — Web API and testing
- [ ] Build ASP.NET Core API endpoints.
- [ ] Introduce request/response DTOs.
- [ ] Add unit tests for business rules.
- [ ] Add integration tests for important API behaviour.

### Phase 5 — Authentication and responsive UI
- [ ] Add user authentication and authorisation.
- [ ] Ensure all user-owned data is isolated by authenticated user.
- [ ] Build a responsive Blazor web interface.
- [ ] Add dashboard, transactions and budgets pages.
- [ ] Add accessible loading, empty and error states.

### Phase 6 — Delivery and optional extensions
- [ ] Containerise with Docker.
- [ ] Add GitHub Actions build/test workflow.
- [ ] Deploy a demonstration version.
- [ ] Optionally add Python-based reporting/analysis.
      
## Known Limitations

At the current stage:

- The application is still under development.
- Some planned features are not implemented.
- Database configuration may not yet be final.
- No production deployment is currently provided.
- The application should not be used as a source of financial advice.

## Contact

Javani Morris

- GitHub: [Vani0904](https://github.com/Vani0904)
- Project repository: [Budget Tracker System](https://github.com/Vani0904/Budget-Tracker-System)
- Portfolio: [Portfolio website](https://vani0904.github.io/Portfolio-site/)

## License

This project is currently intended as a personal learning and portfolio project.

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[product-screenshot]: images/screenshot.png
<!-- Shields.io badges. You can a comprehensive list with many more badges at: https://github.com/inttter/md-badges -->
[C#]: https://custom-icon-badges.demolab.com/badge/C%23-%23239120.svg?logo=cshrp&logoColor=white
[C#-url]: https://learn.microsoft.com/en-us/dotnet/csharp/
[.NET]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff
[.NET-url]: https://dotnet.microsoft.com/en-us/
[Blazor]: https://img.shields.io/badge/Blazor-512BD4?logo=blazor&logoColor=fff
[Blazor-url]: https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor
[Postgres]: https://img.shields.io/badge/Postgres-%23316192.svg?logo=postgresql&logoColor=white
[Postgres-url]: https://www.postgresql.org/
[SQLite]: https://img.shields.io/badge/SQLite-%2307405e.svg?logo=sqlite&logoColor=white
[SQLite-url]: https://www.sqlite.org/
