using System;
using System.Collections.Generic;

namespace FitnessTracker.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MealIngredient> Ingredients { get; set; }

        public Meal()
        {
            Name = string.Empty;
            Ingredients = new List<MealIngredient>();
        }

        public Meal(int id, string name)
        {
            Id = id;
            Name = name;
            Ingredients = new List<MealIngredient>();
        }

        public void AddIngredient(int ingredientId, double grams)
        {
            MealIngredient mealIngredient = new MealIngredient(ingredientId, grams);
            Ingredients.Add(mealIngredient);
        }

        public void RemoveIngredient(int ingredientId)
        {
            for (int i = Ingredients.Count - 1; i >= 0; i--) // iterate backwards to safely remove items
            {
                if (Ingredients[i].IngredientId == ingredientId)
                {
                    Ingredients.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Calculates the total weight of the meal in grams
        /// </summary>
        public double GetTotalWeight()
        {
            double totalWeight = 0;
            for (int i = 0; i < Ingredients.Count; i++)
            {
                totalWeight += Ingredients[i].Grams;
            }
            return totalWeight;
        }

        /// <summary>
        /// Calculates calories per 100g of this meal
        /// </summary>
        public double GetCaloriesPer100g(List<Ingredient> allIngredients)
        {
            return GetNutrientPer100g(allIngredients, ingredient => ingredient.CaloriesPer100g);
        }

        /// <summary>
        /// Calculates protein per 100g of this meal
        /// </summary>
        public double GetProteinPer100g(List<Ingredient> allIngredients)
        {
            return GetNutrientPer100g(allIngredients, ingredient => ingredient.ProteinPer100g);
        }

        /// <summary>
        /// Calculates carbohydrates per 100g of this meal
        /// </summary>
        public double GetCarbsPer100g(List<Ingredient> allIngredients)
        {
            return GetNutrientPer100g(allIngredients, ingredient => ingredient.CarbsPer100g);
        }

        /// <summary>
        /// Calculates fat per 100g of this meal
        /// </summary>
        public double GetFatPer100g(List<Ingredient> allIngredients)
        {
            return GetNutrientPer100g(allIngredients, ingredient => ingredient.FatPer100g);
        }

        /// <summary>
        /// Calculates fiber per 100g of this meal
        /// </summary>
        public double GetFiberPer100g(List<Ingredient> allIngredients)
        {
            return GetNutrientPer100g(allIngredients, ingredient => ingredient.FiberPer100g);
        }

        /// <summary>
        /// Generic method to calculate any nutrient per 100g of this meal.
        /// Eliminates code duplication across all nutrition calculation methods
        /// </summary>
        private double GetNutrientPer100g(List<Ingredient> allIngredients, Func<Ingredient, double> getNutrientValue)
        {
            double totalNutrient = 0;
            double totalWeight = GetTotalWeight();
            
            if (totalWeight == 0) return 0; // prevent division by zero if meal has no weight

            for (int i = 0; i < Ingredients.Count; i++)
            {
                MealIngredient mealIngredient = Ingredients[i];
                Ingredient? ingredient = FindIngredientById(allIngredients, mealIngredient.IngredientId); // find the full ingredient object
                
                if (ingredient != null)
                {
                    // get the specific nutrient value (e.g., calories, protein)
                    double nutrientValue = getNutrientValue(ingredient);
                    // calculate nutrient for the ingredient's proportion in the meal
                    double ingredientNutrient = (nutrientValue * mealIngredient.Grams) / NutritionConstants.REFERENCE_WEIGHT_GRAMS;
                    totalNutrient += ingredientNutrient;
                }
            }

            // scale total nutrient to a per-100g value
            return (totalNutrient * NutritionConstants.REFERENCE_WEIGHT_GRAMS) / totalWeight;
        }

        private Ingredient? FindIngredientById(List<Ingredient> allIngredients, int ingredientId)
        {
            for (int i = 0; i < allIngredients.Count; i++) // simple linear search for ingredient by id
            {
                if (allIngredients[i].Id == ingredientId)
                {
                    return allIngredients[i];
                }
            }
            return null;
        }
    }
} 