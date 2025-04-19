```markdown
# DevHabit API

DevHabit is a RESTful API built with ASP.NET Core that helps users manage habits and their associated tags.
 It provides full CRUD operations, filtering, sorting, pagination, data shaping, and HATEOAS-compliant responses for clients that support it.

---

## 🚀 Features

- **Habit Management**
  - Create, update, patch, and delete habits
  - Filter by status, type, and search by keyword
  - Paginate and sort habits with customizable parameters
  - Data shaping: return only requested fields
  - HATEOAS links for easy API navigation

- **Tag Management**
  - Associate tags with habits
  - Create, update, and delete tags
  - Retrieve individual or all tags

- **Advanced REST Features**
  - JSON Patch support
  - HATEOAS support via custom media types
  - Field selection and validation
  - Structured error handling with ProblemDetails
  - API versioning via media type

---

## 🧱 Tech Stack

| Layer              | Technology            |
|-------------------|-----------------------|
| Framework         | ASP.NET Core 8        |
| ORM               | Entity Framework Core |
| Database          | PostgreSQL            |
| Validation        | FluentValidation      |
| Observability     | OpenTelemetry         |
| Serialization     | Newtonsoft.Json       |

---

## 📦 API Structure

### Habit Entity
```csharp
Habit {
  string Id,
  string Name,
  string? Description,
  HabitType Type,         // Binary, Measurable, etc.
  Frequency Frequency,    // Daily, Weekly, etc.
  Target Target,          // Value + Unit
  HabitStatus Status,     // Ongoing, Completed
  bool IsArchived,
  DateOnly? EndDate,
  Milestone? Milestone,
  DateTime CreatedAtUtc,
  DateTime? UpdatedAtUtc,
  DateTime? LastCompletedAtUtc,
  List<Tag> Tags
}
```

### Endpoints

#### `/habits`
| Method | Description                |
|--------|----------------------------|
| GET    | List habits with filters, sort, pagination, and data shaping |
| POST   | Create a new habit         |

#### `/habits/{id}`
| Method | Description                |
|--------|----------------------------|
| GET    | Get a habit by ID          |
| PUT    | Fully update a habit       |
| PATCH  | Partially update a habit using JSON Patch |
| DELETE | Delete a habit             |

#### `/tags`
| Method | Description                |
|--------|----------------------------|
| GET    | List all tags              |
| POST   | Create a new tag           |

#### `/tags/{id}`
| Method | Description                |
|--------|----------------------------|
| GET    | Get tag by ID              |
| PUT    | Update tag                 |
| DELETE| Delete tag                 |

#### `/habits/{habitId}/tags`
| Method | Description                |
|--------|----------------------------|
| PUT    | Upsert tags for a habit    |
| DELETE | Remove a specific tag from a habit |

---

## 🔗 HATEOAS Support

Supports HATEOAS via the following media types:

- `application/vnd.dev-habit.hateoas+json`
- `application/vnd.dev-habit.hateoas.1+json`
- `application/vnd.dev-habit.hateoas.2+json`

You can include these media types in the `Accept` header to get navigational links in responses.

---

## 🔍 Query Parameters

`GET /habits` supports:

- `q`: Search keyword in name/description
- `type`: Filter by `HabitType`
- `status`: Filter by `HabitStatus`
- `sort`: Comma-separated field names (e.g., `name,-createdAtUtc`)
- `fields`: Comma-separated field names for shaping (e.g., `id,name,type`)
- `page`: Page number (default: 1)
- `pageSize`: Items per page (default: 10)

---

## 🧪 Validation & Error Handling

- Uses `FluentValidation` for input validation
- Custom error responses via `ProblemDetails`
- Global and validation exception handlers implemented

---

## 🔍 Observability

Integrated with OpenTelemetry to support:

- HTTP request tracing
- Database query tracing (PostgreSQL)
- Metrics for HTTP and runtime performance

---

## 🛠 Setup Instructions

1. **Clone the repo**

```bash
git clone [https://github.com/your-org/devhabit-api.git](https://github.com/hadi-soufan/DevHabit.git)
cd src/DevHabit
```

2. **Configure your database connection**

Update your `appsettings.json` or `secrets.json` with your PostgreSQL connection string.

3. **Apply Migrations**

```bash
dotnet ef database update
```

4. **Run the app**

```bash
dotnet run
```

---

## 📖 Future Enhancements

- Habit completion history tracking
- Notifications for milestone achievement
- User authentication and ownership
- Export habits as reports

---

