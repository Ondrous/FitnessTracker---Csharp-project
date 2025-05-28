using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FitnessTracker.Models;
using FitnessTracker.Services;
using FitnessTracker.Forms;

namespace FitnessTracker.Controls
{
    public partial class IngredientControl : UserControl
    {
        private readonly IngredientService _ingredientService;
        private List<Ingredient> _currentIngredients;

        public event EventHandler? GoBackRequested;

        public IngredientControl(IngredientService ingredientService)
        {
            _ingredientService = ingredientService;
            _currentIngredients = new List<Ingredient>();
            InitializeComponent();
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            _currentIngredients = _ingredientService.GetAllIngredients();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            ingredientsGrid.Rows.Clear();

            for (int i = 0; i < _currentIngredients.Count; i++)
            {
                Ingredient ingredient = _currentIngredients[i];
                ingredientsGrid.Rows.Add(
                    ingredient.Id,
                    ingredient.Name,
                    ingredient.CaloriesPer100g.ToString("F1"),
                    ingredient.ProteinPer100g.ToString("F1"),
                    ingredient.CarbsPer100g.ToString("F1"),
                    ingredient.FatPer100g.ToString("F1"),
                    ingredient.FiberPer100g.ToString("F1")
                );
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            _currentIngredients = _ingredientService.SearchIngredients(searchTerm);
            RefreshGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            IngredientEditForm editForm = new IngredientEditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _ingredientService.AddIngredient(editForm.Ingredient);
                    LoadIngredients();
                    MessageBox.Show("Ingredient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding ingredient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (ingredientsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = ingredientsGrid.SelectedRows[0].Index;
            Ingredient selectedIngredient = _currentIngredients[selectedIndex];

            IngredientEditForm editForm = new IngredientEditForm(selectedIngredient);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _ingredientService.UpdateIngredient(editForm.Ingredient);
                    LoadIngredients();
                    MessageBox.Show("Ingredient updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating ingredient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ingredientsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = ingredientsGrid.SelectedRows[0].Index;
            Ingredient selectedIngredient = _currentIngredients[selectedIndex];

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{selectedIngredient.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _ingredientService.DeleteIngredient(selectedIngredient.Id);
                    LoadIngredients();
                    MessageBox.Show("Ingredient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting ingredient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            GoBackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
} 