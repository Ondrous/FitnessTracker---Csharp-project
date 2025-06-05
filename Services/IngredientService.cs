using FitnessTracker.Data;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    /// <summary>
    /// Manages all ingredient-related operations including CRUD operations and search.
    /// Uses JsonDataManager for data persistence and maintains an in-memory list
    /// for fast access. Provides validation for ingredient data and generates
    /// unique IDs. Used by MealService to get ingredient data for nutrition calculations.
    /// </summary>
    public class IngredientService
    {
        private readonly JsonDataManager _dataManager;
        private List<Ingredient> _ingredients;

        public IngredientService()
        {
            _dataManager = new JsonDataManager();
            _ingredients = _dataManager.LoadIngredients();

            // No longer initialize default ingredients
            // Start with empty list if no JSON file exists
        }

        public List<Ingredient> GetAllIngredients()
        {
            return new List<Ingredient>(_ingredients);
        }

        public Ingredient? GetIngredientById(int id)
        {
            for (int i = 0; i < _ingredients.Count; i++)
            {
                if (_ingredients[i].Id == id)
                {
                    return _ingredients[i];
                }
            }
            return null;
        }

        public List<Ingredient> SearchIngredients(string searchTerm)
        {
            List<Ingredient> results = new List<Ingredient>();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return GetAllIngredients();
            }

            string lowerSearchTerm = searchTerm.ToLower();

            for (int i = 0; i < _ingredients.Count; i++)
            {
                if (_ingredients[i].Name.ToLower().Contains(lowerSearchTerm))
                {
                    results.Add(_ingredients[i]);
                }
            }

            return results;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if (ingredient == null)
            {
                throw new ArgumentNullException(nameof(ingredient));
            }

            if (string.IsNullOrWhiteSpace(ingredient.Name))
            {
                throw new ArgumentException("Ingredient name cannot be empty");
            }

            ingredient.Id = GetNextId();
            _ingredients.Add(ingredient);
            SaveIngredients();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            if (ingredient == null)
            {
                throw new ArgumentNullException(nameof(ingredient));
            }

            for (int i = 0; i < _ingredients.Count; i++)
            {
                if (_ingredients[i].Id == ingredient.Id)
                {
                    _ingredients[i] = ingredient;
                    SaveIngredients();
                    return;
                }
            }

            throw new ArgumentException("Ingredient not found");
        }

        public void DeleteIngredient(int id)
        {
            for (int i = 0; i < _ingredients.Count; i++)
            {
                if (_ingredients[i].Id == id)
                {
                    _ingredients.RemoveAt(i);
                    SaveIngredients();
                    return;
                }
            }

            throw new ArgumentException("Ingredient not found");
        }

        private int GetNextId()
        {
            int maxId = 0;
            for (int i = 0; i < _ingredients.Count; i++)
            {
                if (_ingredients[i].Id > maxId)
                {
                    maxId = _ingredients[i].Id;
                }
            }
            return maxId + 1;
        }

        private void SaveIngredients()
        {
            _dataManager.SaveIngredients(_ingredients);
        }
    }
}