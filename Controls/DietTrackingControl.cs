using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FitnessTracker.Models;
using FitnessTracker.Services;
using FitnessTracker.Forms;

namespace FitnessTracker.Controls
{
    public partial class DietTrackingControl : UserControl
    {
        private readonly DietService _dietService;
        private readonly MealService _mealService;
        private List<DietEntry> _currentEntries;
        private List<Meal> _availableMeals;

        public event EventHandler? GoBackRequested;

        public DietTrackingControl(DietService dietService, MealService mealService)
        {
            _dietService = dietService;
            _mealService = mealService;
            _currentEntries = new List<DietEntry>();
            _availableMeals = new List<Meal>();
            InitializeComponent();
            InitializeTimePicker();
            LoadMeals();
            LoadEntriesForSelectedDate();
        }

        private void InitializeTimePicker()
        {
            // Set the time picker to current time
            timePicker.Value = DateTime.Now;
        }

        private void LoadMeals()
        {
            _availableMeals = _mealService.GetAllMeals();
            mealComboBox.Items.Clear();

            for (int i = 0; i < _availableMeals.Count; i++)
            {
                mealComboBox.Items.Add(_availableMeals[i].Name);
            }

            if (mealComboBox.Items.Count > 0)
            {
                mealComboBox.SelectedIndex = 0;
            }
        }

        private void LoadEntriesForSelectedDate()
        {
            DateTime selectedDate = datePicker.Value.Date;
            _currentEntries = _dietService.GetDietEntriesForDate(selectedDate);
            RefreshEntriesGrid();
            UpdateNutritionSummary();
        }

        private void RefreshEntriesGrid()
        {
            entriesGrid.Rows.Clear();

            for (int i = 0; i < _currentEntries.Count; i++)
            {
                DietEntry entry = _currentEntries[i];
                Meal? meal = _mealService.GetMealById(entry.MealId);
                
                if (meal != null)
                {
                    // ServingSize now directly represents grams
                    double weightInGrams = entry.ServingSize;
                    NutritionSummary mealNutrition = _mealService.CalculateMealNutritionForWeight(meal, weightInGrams);

                    entriesGrid.Rows.Add(
                        entry.Id,
                        entry.ConsumedAt.ToString("HH:mm"),
                        meal.Name,
                        weightInGrams.ToString("F0") + "g",
                        mealNutrition.TotalCalories.ToString("F1")
                    );
                }
            }
        }

        private void UpdateNutritionSummary()
        {
            DateTime selectedDate = datePicker.Value.Date;
            NutritionSummary dailyNutrition = _dietService.CalculateDailyNutrition(selectedDate);

            string summaryText = $"Total Calories: {dailyNutrition.TotalCalories:F1}\n" +
                               $"Total Protein: {dailyNutrition.TotalProtein:F1}g\n" +
                               $"Total Carbohydrates: {dailyNutrition.TotalCarbs:F1}g\n" +
                               $"Total Fat: {dailyNutrition.TotalFat:F1}g\n" +
                               $"Total Fiber: {dailyNutrition.TotalFiber:F1}g\n\n" +
                               $"Macronutrient Distribution:\n" +
                               $"Protein: {GetPercentage(dailyNutrition.TotalProtein * NutritionConstants.CALORIES_PER_GRAM_PROTEIN, dailyNutrition.TotalCalories):F1}%\n" +
                               $"Carbs: {GetPercentage(dailyNutrition.TotalCarbs * NutritionConstants.CALORIES_PER_GRAM_CARBS, dailyNutrition.TotalCalories):F1}%\n" +
                               $"Fat: {GetPercentage(dailyNutrition.TotalFat * NutritionConstants.CALORIES_PER_GRAM_FAT, dailyNutrition.TotalCalories):F1}%";

            nutritionSummaryLabel.Text = summaryText;
        }

        private double GetPercentage(double value, double total)
        {
            if (total == 0) return 0;
            return (value / total) * NutritionConstants.PERCENTAGE_MULTIPLIER;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadEntriesForSelectedDate();
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            if (mealComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a meal.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedMealIndex = mealComboBox.SelectedIndex;
            Meal selectedMeal = _availableMeals[selectedMealIndex];
            
            // ServingSize now directly represents grams (no conversion needed)
            double servingSize = (double)servingSizeNumeric.Value;
            
            // Combine selected date with selected time
            DateTime selectedDate = datePicker.Value.Date;
            DateTime selectedTime = timePicker.Value;
            DateTime consumedAt = selectedDate.Add(selectedTime.TimeOfDay);

            DietEntry newEntry = new DietEntry(0, selectedMeal.Id, consumedAt, servingSize);

            try
            {
                _dietService.AddDietEntry(newEntry);
                LoadEntriesForSelectedDate();
                MessageBox.Show("Diet entry added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding diet entry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editEntryButton_Click(object sender, EventArgs e)
        {
            if (entriesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entry to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = entriesGrid.SelectedRows[0].Index;
            DietEntry selectedEntry = _currentEntries[selectedRowIndex];

            // Create a copy of the entry for editing
            DietEntry entryToEdit = new DietEntry(selectedEntry.Id, selectedEntry.MealId, selectedEntry.ConsumedAt, selectedEntry.ServingSize);

            using (DietEntryEditForm editForm = new DietEntryEditForm(entryToEdit, _mealService))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _dietService.UpdateDietEntry(editForm.DietEntry);
                        LoadEntriesForSelectedDate();
                        MessageBox.Show("Diet entry updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating diet entry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            if (entriesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entry to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = entriesGrid.SelectedRows[0].Index;
            DietEntry selectedEntry = _currentEntries[selectedRowIndex];

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this diet entry?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _dietService.DeleteDietEntry(selectedEntry.Id);
                    LoadEntriesForSelectedDate();
                    MessageBox.Show("Diet entry deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting diet entry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            GoBackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
} 