using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FitnessTracker.Models;
using FitnessTracker.Services;
using FitnessTracker.Forms;

namespace FitnessTracker.Controls
{
    /// <summary>
    /// User interface control for managing meals and viewing their nutritional information.
    /// Shows a list of meals with their nutrition values and provides meal management
    /// operations. Depends on both MealService and IngredientService - uses MealService
    /// for meal operations and IngredientService for ingredient data needed in meal editing.
    /// </summary>
    public partial class MealControl : UserControl
    {
        private readonly MealService _mealService;
        private readonly IngredientService _ingredientService;
        private List<Meal> _currentMeals;

        public event EventHandler? GoBackRequested;

        public MealControl(MealService mealService, IngredientService ingredientService)
        {
            _mealService = mealService;
            _ingredientService = ingredientService;
            _currentMeals = new List<Meal>();
            InitializeComponent();
            LoadMeals();
        }

        private void LoadMeals()
        {
            _currentMeals = _mealService.GetAllMeals();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            mealsGrid.Rows.Clear();

            for (int i = 0; i < _currentMeals.Count; i++)
            {
                Meal meal = _currentMeals[i];
                mealsGrid.Rows.Add(
                    meal.Id,
                    meal.Name,
                    meal.Ingredients.Count.ToString()
                );
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            _currentMeals = _mealService.SearchMeals(searchTerm);
            RefreshGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MealEditForm editForm = new MealEditForm(_ingredientService);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mealService.AddMeal(editForm.Meal);
                    LoadMeals();
                    MessageBox.Show("Meal added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding meal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (mealsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a meal to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = mealsGrid.SelectedRows[0].Index;
            Meal selectedMeal = _currentMeals[selectedIndex];

            MealEditForm editForm = new MealEditForm(_ingredientService, selectedMeal);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mealService.UpdateMeal(editForm.Meal);
                    LoadMeals();
                    MessageBox.Show("Meal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating meal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (mealsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a meal to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = mealsGrid.SelectedRows[0].Index;
            Meal selectedMeal = _currentMeals[selectedIndex];

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{selectedMeal.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _mealService.DeleteMeal(selectedMeal.Id);
                    LoadMeals();
                    MessageBox.Show("Meal deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting meal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewNutritionButton_Click(object sender, EventArgs e)
        {
            if (mealsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a meal to view nutrition information.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = mealsGrid.SelectedRows[0].Index;
            Meal selectedMeal = _currentMeals[selectedIndex];

            // Get total nutrition for the entire meal
            NutritionSummary totalNutrition = _mealService.CalculateMealNutrition(selectedMeal);
            
            // Get nutrition per 100g
            NutritionSummary nutritionPer100g = _mealService.GetMealNutritionPer100g(selectedMeal);
            
            // Get total weight
            double totalWeight = selectedMeal.GetTotalWeight();
            
            string nutritionInfo = $"Nutrition Information for '{selectedMeal.Name}':\n\n" +
                                 $"Total Weight: {totalWeight:F0}g\n\n" +
                                 $"TOTAL MEAL NUTRITION:\n" +
                                 $"Calories: {totalNutrition.TotalCalories:F1}\n" +
                                 $"Protein: {totalNutrition.TotalProtein:F1}g\n" +
                                 $"Carbohydrates: {totalNutrition.TotalCarbs:F1}g\n" +
                                 $"Fat: {totalNutrition.TotalFat:F1}g\n" +
                                 $"Fiber: {totalNutrition.TotalFiber:F1}g\n\n" +
                                 $"PER 100g:\n" +
                                 $"Calories: {nutritionPer100g.TotalCalories:F1}\n" +
                                 $"Protein: {nutritionPer100g.TotalProtein:F1}g\n" +
                                 $"Carbohydrates: {nutritionPer100g.TotalCarbs:F1}g\n" +
                                 $"Fat: {nutritionPer100g.TotalFat:F1}g\n" +
                                 $"Fiber: {nutritionPer100g.TotalFiber:F1}g";

            MessageBox.Show(nutritionInfo, "Nutrition Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            GoBackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
} 