namespace FitnessTracker.Models
{
    /// <summary>
    /// Aggregates nutritional values for meals, diet entries, or daily totals.
    /// Provides methods to add nutrition values together and reset totals.
    /// Used throughout the app to calculate and display combined nutrition information
    /// from multiple sources like ingredients in a meal or meals in a day.
    /// </summary>
    public class NutritionSummary
    {
        public double TotalCalories { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarbs { get; set; }
        public double TotalFat { get; set; }
        public double TotalFiber { get; set; }

        public NutritionSummary()
        {
        }

        public NutritionSummary(double calories, double protein, double carbs, double fat, double fiber)
        {
            TotalCalories = calories;
            TotalProtein = protein;
            TotalCarbs = carbs;
            TotalFat = fat;
            TotalFiber = fiber;
        }

        public void AddNutrition(double calories, double protein, double carbs, double fat, double fiber)
        {
            TotalCalories += calories;
            TotalProtein += protein;
            TotalCarbs += carbs;
            TotalFat += fat;
            TotalFiber += fiber;
        }

        public void Reset()
        {
            TotalCalories = 0;
            TotalProtein = 0;
            TotalCarbs = 0;
            TotalFat = 0;
            TotalFiber = 0;
        }
    }
}