using System;

namespace FitnessTracker.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CaloriesPer100g { get; set; }
        public double ProteinPer100g { get; set; }
        public double CarbsPer100g { get; set; }
        public double FatPer100g { get; set; }
        public double FiberPer100g { get; set; }

        public Ingredient()
        {
            Name = string.Empty;
        }

        public Ingredient(int id, string name, double calories, double protein, double carbs, double fat, double fiber)
        {
            Id = id;
            Name = name;
            CaloriesPer100g = calories;
            ProteinPer100g = protein;
            CarbsPer100g = carbs;
            FatPer100g = fat;
            FiberPer100g = fiber;
        }

        public double CalculateCalories(double grams)
        {
            return (CaloriesPer100g * grams) / NutritionConstants.REFERENCE_WEIGHT_GRAMS;
        }

        public double CalculateProtein(double grams)
        {
            return (ProteinPer100g * grams) / NutritionConstants.REFERENCE_WEIGHT_GRAMS;
        }

        public double CalculateCarbs(double grams)
        {
            return (CarbsPer100g * grams) / NutritionConstants.REFERENCE_WEIGHT_GRAMS;
        }

        public double CalculateFat(double grams)
        {
            return (FatPer100g * grams) / NutritionConstants.REFERENCE_WEIGHT_GRAMS;
        }

        public double CalculateFiber(double grams)
        {
            return (FiberPer100g * grams) / NutritionConstants.REFERENCE_WEIGHT_GRAMS;
        }
    }
} 