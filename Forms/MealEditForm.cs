using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FitnessTracker.Models;
using FitnessTracker.Services;

namespace FitnessTracker.Forms
{
    public partial class MealEditForm : Form
    {
        private readonly IngredientService _ingredientService;
        private List<Ingredient> _availableIngredients;

        public Meal Meal { get; private set; }

        public MealEditForm(IngredientService ingredientService) : this(ingredientService, null)
        {
        }

        public MealEditForm(IngredientService ingredientService, Meal? meal)
        {
            _ingredientService = ingredientService;
            Meal = meal ?? new Meal();
            _availableIngredients = new List<Ingredient>();
            InitializeComponent();
            SetupForm();
            LoadIngredients();
            PopulateFields();
        }

        private void SetupForm()
        {
            this.Text = Meal.Id == 0 ? "Add Meal" : "Edit Meal";
        }

        private void LoadIngredients()
        {
            _availableIngredients = _ingredientService.GetAllIngredients();
            _ingredientComboBox.Items.Clear();

            for (int i = 0; i < _availableIngredients.Count; i++)
            {
                _ingredientComboBox.Items.Add(_availableIngredients[i].Name);
            }

            if (_ingredientComboBox.Items.Count > 0)
            {
                _ingredientComboBox.SelectedIndex = 0;
            }
        }

        private void PopulateFields()
        {
            _nameTextBox.Text = Meal.Name;
            RefreshIngredientsGrid();
        }

        private void RefreshIngredientsGrid()
        {
            _ingredientsGrid.Rows.Clear();

            for (int i = 0; i < Meal.Ingredients.Count; i++)
            {
                MealIngredient mealIngredient = Meal.Ingredients[i];
                Ingredient? ingredient = _ingredientService.GetIngredientById(mealIngredient.IngredientId);
                
                if (ingredient != null)
                {
                    _ingredientsGrid.Rows.Add(
                        mealIngredient.IngredientId,
                        ingredient.Name,
                        mealIngredient.Grams.ToString("F1")
                    );
                }
            }
        }

        private void AddIngredientButton_Click(object? sender, EventArgs e)
        {
            if (_ingredientComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an ingredient.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = _ingredientComboBox.SelectedIndex;
            Ingredient selectedIngredient = _availableIngredients[selectedIndex];
            double grams = (double)_gramsNumeric.Value;

            // Check if ingredient is already in the meal
            for (int i = 0; i < Meal.Ingredients.Count; i++)
            {
                if (Meal.Ingredients[i].IngredientId == selectedIngredient.Id)
                {
                    MessageBox.Show("This ingredient is already in the meal. Please remove it first if you want to change the amount.", 
                                  "Ingredient Already Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            MealIngredient newMealIngredient = new MealIngredient(selectedIngredient.Id, grams);
            Meal.Ingredients.Add(newMealIngredient);
            RefreshIngredientsGrid();
        }

        private void RemoveIngredientButton_Click(object? sender, EventArgs e)
        {
            if (_ingredientsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = _ingredientsGrid.SelectedRows[0].Index;
            Meal.Ingredients.RemoveAt(selectedRowIndex);
            RefreshIngredientsGrid();
        }

        private void OkButton_Click(object? sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveMeal();
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
                MessageBox.Show("Please enter a meal name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _nameTextBox.Focus();
                return false;
            }

            if (Meal.Ingredients.Count == 0)
            {
                MessageBox.Show("Please add at least one ingredient to the meal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SaveMeal()
        {
            Meal.Name = _nameTextBox.Text.Trim();
        }
    }
} 