namespace FitnessTracker.Models
{
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