using FitnessTracker.Data;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    /// <summary>
    /// Manages meal operations and provides nutrition calculations for meals.
    /// Depends on IngredientService to get ingredient data for calculations.
    /// Handles meal CRUD operations and calculates nutrition values both for entire
    /// meals and for specific serving sizes. Used by DietService for diet tracking.
    /// </summary>
    public class MealService
    {
        private readonly JsonDataManager _dataManager;
        private readonly IngredientService _ingredientService;
        private List<Meal> _meals;

        public MealService(IngredientService ingredientService)
        {
            _dataManager = new JsonDataManager();
            _ingredientService = ingredientService;
            _meals = _dataManager.LoadMeals();
        }

        public List<Meal> GetAllMeals()
        {
            return new List<Meal>(_meals);
        }

        public Meal? GetMealById(int id)
        {
            for (int i = 0; i < _meals.Count; i++)
            {
                if (_meals[i].Id == id)
                {
                    return _meals[i];
                }
            }
            return null;
        }

        public List<Meal> SearchMeals(string searchTerm)
        {
            List<Meal> results = new List<Meal>();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return GetAllMeals();
            }

            string lowerSearchTerm = searchTerm.ToLower();

            for (int i = 0; i < _meals.Count; i++)
            {
                if (_meals[i].Name.ToLower().Contains(lowerSearchTerm))
                {
                    results.Add(_meals[i]);
                }
            }

            return results;
        }

        public void AddMeal(Meal meal)
        {
            if (meal == null)
            {
                throw new ArgumentNullException(nameof(meal));
            }

            if (string.IsNullOrWhiteSpace(meal.Name))
            {
                throw new ArgumentException("Meal name cannot be empty");
            }

            meal.Id = GetNextId();
            _meals.Add(meal);
            SaveMeals();
        }

        public void UpdateMeal(Meal meal)
        {
            if (meal == null)
            {
                throw new ArgumentNullException(nameof(meal));
            }

            for (int i = 0; i < _meals.Count; i++)
            {
                if (_meals[i].Id == meal.Id)
                {
                    _meals[i] = meal;
                    SaveMeals();
                    return;
                }
            }

            throw new ArgumentException("Meal not found");
        }

        public void DeleteMeal(int id)
        {
            for (int i = 0; i < _meals.Count; i++)
            {
                if (_meals[i].Id == id)
                {
                    _meals.RemoveAt(i);
                    SaveMeals();
                    return;
                }
            }

            throw new ArgumentException("Meal not found");
        }

        /// <summary>
        /// Calculates nutrition for the entire meal (all ingredients combined)
        /// </summary>
        public NutritionSummary CalculateMealNutrition(Meal meal)
        {
            if (meal == null)
            {
                return new NutritionSummary();
            }

            NutritionSummary summary = new NutritionSummary();

            for (int i = 0; i < meal.Ingredients.Count; i++)
            {
                MealIngredient mealIngredient = meal.Ingredients[i];
                Ingredient? ingredient = _ingredientService.GetIngredientById(mealIngredient.IngredientId);

                if (ingredient != null)
                {
                    double calories = ingredient.CalculateCalories(mealIngredient.Grams);
                    double protein = ingredient.CalculateProtein(mealIngredient.Grams);
                    double carbs = ingredient.CalculateCarbs(mealIngredient.Grams);
                    double fat = ingredient.CalculateFat(mealIngredient.Grams);
                    double fiber = ingredient.CalculateFiber(mealIngredient.Grams);

                    summary.AddNutrition(calories, protein, carbs, fat, fiber);
                }
            }

            return summary;
        }

        /// <summary>
        /// Calculates nutrition for a specific weight of the meal in grams
        /// </summary>
        public NutritionSummary CalculateMealNutritionForWeight(Meal meal, double weightInGrams)
        {
            if (meal == null || weightInGrams <= 0)
            {
                return new NutritionSummary();
            }

            List<Ingredient> allIngredients = _ingredientService.GetAllIngredients();

            double caloriesPer100g = meal.GetCaloriesPer100g(allIngredients);
            double proteinPer100g = meal.GetProteinPer100g(allIngredients);
            double carbsPer100g = meal.GetCarbsPer100g(allIngredients);
            double fatPer100g = meal.GetFatPer100g(allIngredients);
            double fiberPer100g = meal.GetFiberPer100g(allIngredients);

            double multiplier = weightInGrams / NutritionConstants.REFERENCE_WEIGHT_GRAMS;

            NutritionSummary summary = new NutritionSummary();
            summary.AddNutrition(
                caloriesPer100g * multiplier,
                proteinPer100g * multiplier,
                carbsPer100g * multiplier,
                fatPer100g * multiplier,
                fiberPer100g * multiplier
            );

            return summary;
        }

        /// <summary>
        /// Gets nutrition information per 100g of the meal
        /// </summary>
        public NutritionSummary GetMealNutritionPer100g(Meal meal)
        {
            if (meal == null)
            {
                return new NutritionSummary();
            }

            List<Ingredient> allIngredients = _ingredientService.GetAllIngredients();

            double caloriesPer100g = meal.GetCaloriesPer100g(allIngredients);
            double proteinPer100g = meal.GetProteinPer100g(allIngredients);
            double carbsPer100g = meal.GetCarbsPer100g(allIngredients);
            double fatPer100g = meal.GetFatPer100g(allIngredients);
            double fiberPer100g = meal.GetFiberPer100g(allIngredients);

            NutritionSummary summary = new NutritionSummary();
            summary.AddNutrition(caloriesPer100g, proteinPer100g, carbsPer100g, fatPer100g, fiberPer100g);

            return summary;
        }

        private int GetNextId()
        {
            int maxId = 0;
            for (int i = 0; i < _meals.Count; i++)
            {
                if (_meals[i].Id > maxId)
                {
                    maxId = _meals[i].Id;
                }
            }
            return maxId + 1;
        }

        private void SaveMeals()
        {
            _dataManager.SaveMeals(_meals);
        }
    }
}