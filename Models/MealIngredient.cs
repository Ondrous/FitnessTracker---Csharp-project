namespace FitnessTracker.Models
{
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