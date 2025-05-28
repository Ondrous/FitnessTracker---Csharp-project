using System;
using System.Windows.Forms;
using FitnessTracker.Models;

namespace FitnessTracker.Forms
{
    public partial class IngredientEditForm : Form
    {
        public Ingredient Ingredient { get; private set; }

        public IngredientEditForm() : this(null)
        {
        }

        public IngredientEditForm(Ingredient? ingredient)
        {
            Ingredient = ingredient ?? new Ingredient();
            InitializeComponent();
            SetupForm();
            PopulateFields();
        }

        private void SetupForm()
        {
            this.Text = Ingredient.Id == 0 ? "Add Ingredient" : "Edit Ingredient";
        }

        private void PopulateFields()
        {
            _nameTextBox.Text = Ingredient.Name;
            _caloriesNumeric.Value = (decimal)Ingredient.CaloriesPer100g;
            _proteinNumeric.Value = (decimal)Ingredient.ProteinPer100g;
            _carbsNumeric.Value = (decimal)Ingredient.CarbsPer100g;
            _fatNumeric.Value = (decimal)Ingredient.FatPer100g;
            _fiberNumeric.Value = (decimal)Ingredient.FiberPer100g;
        }

        private void CalculateCaloriesButton_Click(object? sender, EventArgs e)
        {
            // Calculate calories based on macronutrients using standard nutritional constants
            double protein = (double)_proteinNumeric.Value;
            double carbs = (double)_carbsNumeric.Value;
            double fat = (double)_fatNumeric.Value;

            double calculatedCalories = (protein * NutritionConstants.CALORIES_PER_GRAM_PROTEIN) + 
                                      (carbs * NutritionConstants.CALORIES_PER_GRAM_CARBS) + 
                                      (fat * NutritionConstants.CALORIES_PER_GRAM_FAT);
            
            _caloriesNumeric.Value = (decimal)calculatedCalories;

            // Show a confirmation message with the calculation breakdown using constants
            string message = $"Calories calculated from macronutrients:\n\n" +
                           $"Protein: {protein:F1}g × {NutritionConstants.CALORIES_PER_GRAM_PROTEIN} = {protein * NutritionConstants.CALORIES_PER_GRAM_PROTEIN:F1} calories\n" +
                           $"Carbs: {carbs:F1}g × {NutritionConstants.CALORIES_PER_GRAM_CARBS} = {carbs * NutritionConstants.CALORIES_PER_GRAM_CARBS:F1} calories\n" +
                           $"Fat: {fat:F1}g × {NutritionConstants.CALORIES_PER_GRAM_FAT} = {fat * NutritionConstants.CALORIES_PER_GRAM_FAT:F1} calories\n" +
                           $"Total: {calculatedCalories:F1} calories";

            MessageBox.Show(message, "Calories Calculated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OkButton_Click(object? sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveIngredient();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(_nameTextBox.Text))
            {
                MessageBox.Show("Please enter an ingredient name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _nameTextBox.Focus();
                return false;
            }

            return true;
        }

        private void SaveIngredient()
        {
            Ingredient.Name = _nameTextBox.Text.Trim();
            Ingredient.CaloriesPer100g = (double)_caloriesNumeric.Value;
            Ingredient.ProteinPer100g = (double)_proteinNumeric.Value;
            Ingredient.CarbsPer100g = (double)_carbsNumeric.Value;
            Ingredient.FatPer100g = (double)_fatNumeric.Value;
            Ingredient.FiberPer100g = (double)_fiberNumeric.Value;
        }

    }
} 