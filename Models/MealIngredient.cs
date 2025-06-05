namespace FitnessTracker.Models
{
    /// <summary>
    /// Links an ingredient to a meal with a specific quantity in grams.
    /// This is a simple data structure that connects ingredient IDs to their amounts
    /// within a meal recipe. Used by Meal class to store its ingredient composition.
    /// </summary>
    public class MealIngredient
    {
        public int IngredientId { get; set; }
        public double Grams { get; set; }

        public MealIngredient()
        {
        }

        public MealIngredient(int ingredientId, double grams)
        {
            IngredientId = ingredientId;
            Grams = grams;
        }
    }
} 