# FitnessTracker User Documentation

## Overview
FitnessTracker is a comprehensive nutrition and diet tracking application that helps you manage ingredients, create meals, track daily food intake, and analyze your nutritional data.

## Getting Started
- Launch the application to see the main menu
- Navigate between sections using the menu buttons
- Use "<- Go Back" buttons to return to the main menu

## 1. Ingredient Management

### Adding New Ingredients
- Click **"Manage Ingredients"** from main menu
- Click **"Add"** button
- Fill in ingredient details:
  - Name (required)
  - Calories per 100g
  - Protein per 100g
  - Carbohydrates per 100g
  - Fat per 100g
  - Fiber per 100g
- Use **"Calculate from Macros"** button to auto-calculate calories from protein, carbs, and fat
- Click **"OK"** to save

### Managing Existing Ingredients
- **Search**: Use search box to find specific ingredients
- **Edit**: Select ingredient and click "Edit" to modify details
- **Delete**: Select ingredient and click "Delete" to remove
- **View**: All ingredients display nutrition information per 100g

### Calculate Calories Feature
- Automatically calculates calories using standard formula:
  - Protein: 4 calories per gram
  - Carbohydrates: 4 calories per gram
  - Fat: 9 calories per gram

## 2. Meal Creation

### Creating Meals
- Click **"Manage Meals"** from main menu
- Click **"Add"** to create new meal
- Enter meal name
- Add ingredients:
  - Select ingredient from dropdown
  - Specify weight in grams
  - Click "Add Ingredient"
- Remove ingredients using "Remove" button
- Save meal when complete

### Managing Meals
- **Search**: Find meals by name
- **Edit**: Modify existing meals and their ingredients
- **Delete**: Remove meals permanently
- **View Nutrition**: See complete nutritional breakdown

### Nutrition Information
- **Total Meal**: Complete nutrition for entire meal
- **Per 100g**: Nutrition density information
- **Total Weight**: Shows meal's total weight in grams

## 3. Diet Tracking

### Recording Food Intake
- Click **"Track Diet"** from main menu
- Select date using date picker
- Choose meal from dropdown
- Set portion size in grams (1-2000g range)
- Select time of consumption
- Click **"Add Entry"** to record

### Managing Diet Entries
- **View by Date**: Use date picker to see specific day's entries
- **Edit Entry**: Select entry and click "Edit Entry" to modify
- **Delete Entry**: Remove incorrect entries
- **Time Tracking**: Each entry records exact consumption time

### Daily Nutrition Summary
- **Total Nutrition**: Complete daily totals for all macronutrients
- **Macronutrient Distribution**: Percentage breakdown of calories from protein, carbs, and fat
- **Real-time Updates**: Summary updates automatically when entries change

## 4. Statistics and Analysis

### Viewing Statistics
- Click **"View Statistics"** from main menu
- Select date range using start and end date pickers
- Click **"Generate Report"** to analyze period

### Available Reports
- **Daily Averages**: Average nutrition per day over selected period
- **Total Consumption**: Sum of all nutrition over period
- **Macronutrient Ratios**: Percentage distribution of calories

### Understanding the Data
- **Calories**: Total energy intake
- **Protein**: Muscle building and repair nutrients
- **Carbohydrates**: Primary energy source
- **Fat**: Essential fatty acids and energy storage
- **Fiber**: Digestive health nutrients

## 5. Key Features

### Weight-Based Calculations
- All nutrition calculations based on actual ingredient weights
- Proportional scaling ensures accurate nutrition when eating partial meals
- Example: 150g of a 300g meal provides exactly 50% of the nutrition

### Data Persistence
- All data automatically saved to JSON files
- Pre-loaded with common ingredients
- Data persists between application sessions

### User-Friendly Interface
- Single-window navigation system
- Clear, intuitive button layouts
- Confirmation messages for important actions
