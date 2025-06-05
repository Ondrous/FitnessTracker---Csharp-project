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

## Main Components

### Data Models

#### Ingredient
Represents a single food ingredient with its nutritional values per 100g. This is the basic building block used by meals to calculate total nutrition. Contains methods to calculate nutrition values for specific weights and uses NutritionConstants for consistent weight calculations across the app.

#### Meal
Represents a meal composed of multiple ingredients with their quantities. Acts as a recipe that can calculate its own nutritional values per 100g by combining all ingredient nutritions proportionally. Used by DietEntry to track what was actually consumed and by MealService for nutrition calculations.

#### DietEntry
Records when and how much of a specific meal was consumed. Links a meal to a consumption time and serving size (in grams). This is what creates the actual diet log - each entry represents one instance of eating a meal. Used by DietService for tracking daily nutrition.

#### MealIngredient
Links an ingredient to a meal with a specific quantity in grams. This is a simple data structure that connects ingredient IDs to their amounts within a meal recipe. Used by Meal class to store its ingredient composition.

#### NutritionSummary
Aggregates nutritional values for meals, diet entries, or daily totals. Provides methods to add nutrition values together and reset totals. Used throughout the app to calculate and display combined nutrition information from multiple sources like ingredients in a meal or meals in a day.

### Data Access Layer

#### JsonDataManager
Handles all data persistence operations using JSON files for storage. Saves and loads ingredients, meals, and diet entries to/from JSON files in the Data directory. Acts as the data access layer that isolates the rest of the app from storage details. Uses System.Text.Json for serialization.

### Service Layer

#### IngredientService
Manages all ingredient-related operations including CRUD operations and search. Uses JsonDataManager for data persistence and maintains an in-memory list for fast access. Provides validation for ingredient data and generates unique IDs. Used by MealService to get ingredient data for nutrition calculations.

#### MealService
Manages meal operations and provides nutrition calculations for meals. Depends on IngredientService to get ingredient data for calculations. Handles meal CRUD operations and calculates nutrition values both for entire meals and for specific serving sizes. Used by DietService for diet tracking.

#### DietService
Manages diet tracking by recording meal consumption over time. Depends on MealService to get meal data and calculate nutrition values. Provides functionality to track daily nutrition, calculate nutrition for date ranges, and generate diet statistics. This is the top-level service that coordinates meal and ingredient data to provide comprehensive diet tracking.

### Presentation Layer

#### MainForm
Main application window that acts as a navigation hub between different features. Initializes all service dependencies and manages the display of different UserControls for ingredients, meals, diet tracking, and statistics. Handles navigation events and ensures proper cleanup when switching between different sections of the app.

#### IngredientControl
User interface control for managing ingredients in the application. Provides a grid view of ingredients with search, add, edit, and delete functionality. Uses IngredientService for all data operations and IngredientEditForm for detailed ingredient editing. Communicates with MainForm through events for navigation.

#### MealControl
User interface control for managing meals and viewing their nutritional information. Shows a list of meals with their nutrition values and provides meal management operations. Depends on both MealService and IngredientService - uses MealService for meal operations and IngredientService for ingredient data needed in meal editing.

#### DietTrackingControl
User interface control for tracking daily diet entries and viewing nutrition summaries. Allows users to log meals they've consumed with specific serving sizes and dates. Uses DietService for diet entry operations and MealService to get meal data for selection. Shows daily nutrition totals and provides diet entry management.

#### StatisticsControl
User interface control for viewing nutrition statistics and reports over time periods. Allows users to select date ranges and generates daily nutrition summaries with totals and averages. Uses DietService to get diet entry data and calculate comprehensive nutrition statistics for analysis and tracking progress.

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
