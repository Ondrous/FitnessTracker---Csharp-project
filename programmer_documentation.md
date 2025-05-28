# FitnessTracker - Programmer Documentation

## Overview
FitnessTracker is a .NET 8.0 Windows Forms application implementing a nutrition and diet tracking system with a layered architecture, following SOLID principles and clean code practices.

## Architecture Overview

### Layered Architecture
The application follows a **3-tier layered architecture**:

```
┌─────────────────────────────────────┐
│           Presentation Layer        │
│           (Forms, controls)         │
├─────────────────────────────────────┤
│           Program Logic Layer       │
│           (Services)                │
├─────────────────────────────────────┤
│           Data Access Layer         │
│           (JsonDataManager)         │
├─────────────────────────────────────┤
│           Data Models               │
│           (Models)                  │
└─────────────────────────────────────┘
```


## Design Patterns and principles

### Principles
- **DRY**: Do not repeat yourself - Code is written in a way that minimizes redundancies and reused code
- **No magic numbers**: Each number constant is named properly, that leads to better code readability and maintainability
- **Decomposition**: Every functionality of the application has its own class or function, the functions are short and easy to read

### Repository Pattern
**Implementation**: `JsonDataManager` class
- **Purpose**: Abstracts data persistence operations
- **Benefits**: Separates program logic from data storage implementation
- **Extensibility**: Easy to replace JSON storage with database or web API

```csharp
public class JsonDataManager
{
    public List<Ingredient> LoadIngredients() { }
    public void SaveIngredients(List<Ingredient> ingredients) { }
    // ...similar methods for Meals and DietEntries
}
```

### Service Layer Pattern
**Implementation**: `IngredientService`, `MealService`, `DietService`
- **Purpose**: Encapsulates program logic and operations
- **Benefits**: Centralized program rules, reusable across UI components
- **Dependency Chain**: `DietService` → `MealService` → `IngredientService`

## API Design and Extensibility

### Service Layer API

#### IngredientService
```csharp
public class IngredientService
{
    // CRUD Operations
    public List<Ingredient> GetAllIngredients()
    public Ingredient? GetIngredientById(int id)
    public List<Ingredient> SearchIngredients(string searchTerm)
    public void AddIngredient(Ingredient ingredient)
    public void UpdateIngredient(Ingredient ingredient)
    public void DeleteIngredient(int id)
}
```

#### MealService
```csharp
public class MealService
{
    // CRUD Operations
    public List<Meal> GetAllMeals()
    public Meal? GetMealById(int id)
    public List<Meal> SearchMeals(string searchTerm)
    public void AddMeal(Meal meal)
    public void UpdateMeal(Meal meal)
    public void DeleteMeal(int id)
    
    // Nutrition Calculations
    public NutritionSummary CalculateMealNutrition(Meal meal)
    public NutritionSummary CalculateMealNutritionForWeight(Meal meal, double weightInGrams)
    public NutritionSummary GetMealNutritionPer100g(Meal meal)
}
```

#### DietService
```csharp
public class DietService
{
    // CRUD Operations
    public List<DietEntry> GetAllDietEntries()
    public List<DietEntry> GetDietEntriesForDate(DateTime date)
    public List<DietEntry> GetDietEntriesForDateRange(DateTime startDate, DateTime endDate)
    public void AddDietEntry(DietEntry dietEntry)
    public void UpdateDietEntry(DietEntry dietEntry)
    public void DeleteDietEntry(int id)
    
    // Analytics
    public NutritionSummary CalculateDailyNutrition(DateTime date)
    public NutritionSummary CalculateNutritionForDateRange(DateTime startDate, DateTime endDate)
    public Dictionary<DateTime, NutritionSummary> GetDailyNutritionSummary(DateTime startDate, DateTime endDate)
}
```

### Extensibility Points

#### 1. Data Storage Extension
**Current**: JSON file storage
**Extension Point**: Replace `JsonDataManager` with database implementation

```csharp
public interface IDataManager
{
    List<Ingredient> LoadIngredients();
    void SaveIngredients(List<Ingredient> ingredients);
    // ... other methods
}
```

#### 2. New Nutrition Calculations
**Extension Point**: Add methods to `Meal` model and `MealService`

```csharp
// Example: Add vitamin calculations
public double GetVitaminCPer100g(List<Ingredient> allIngredients)
{
    // Implementation
}
```

#### 3. New UI Components
**Extension Point**: Create new UserControls implementing navigation pattern

```csharp
public partial class NewFeatureControl : UserControl
{
    public event EventHandler? GoBackRequested;
    // Implementation
}
```

## Encapsulation and Data Integrity

### Model Encapsulation
- **Properties**: Public getters with controlled setters
- **Validation**: Input validation in service layer

### Service Encapsulation
- **Private Fields**: Internal state hidden from consumers
- **Public API**: Clean, focused interface

### Data Validation
```csharp
private bool ValidateInput()
{
    if (string.IsNullOrWhiteSpace(_nameTextBox.Text))
    {
        MessageBox.Show("Please enter an ingredient name.", "Validation Error", 
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
    }
    return true;
}
```

## Code Maintainability

### Separation of Concerns
- **Models**: Pure data structures
- **Services**: Program logic only
- **UI**: Presentation logic only
- **Data**: Persistence logic only

### Single Responsibility Principle
- Each class nad method has one purpose
- Services focused on specific domain areas
- UI components handle single functionality

### Dependency Management
- Clear dependency hierarchy
- No circular dependencies

### Code Organization
- **Consistent Naming**: Clear, descriptive names
- **Method Size**: Small, focused methods
- **Class Size**: Reasonable class sizes
- **Comments**: Meaningful documentation

## Libraries and Dependencies

### UI Framework
- **Windows Forms**: UI framework
  - **Purpose**: Desktop application development
  - **Benefits**: Mature, stable, designer support
  - **Usage**: Forms, UserControls, event handling

### Data Serialization
- **System.Text.Json**: JSON serialization
  - **Purpose**: Data persistence to JSON files
  - **Benefits**: High performance, built-in, secure
  - **Usage**: Serialize/deserialize models to/from JSON
