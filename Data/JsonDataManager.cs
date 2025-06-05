using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FitnessTracker.Models;

namespace FitnessTracker.Data
{
    /// <summary>
    /// Handles all data persistence operations using JSON files for storage.
    /// Saves and loads ingredients, meals, and diet entries to/from JSON files
    /// in the Data directory. Acts as the data access layer that isolates
    /// the rest of the app from storage details. Uses System.Text.Json for serialization.
    /// </summary>
    public class JsonDataManager
    {
        private readonly string _dataDirectory;
        private readonly string _ingredientsFile;
        private readonly string _mealsFile;
        private readonly string _dietEntriesFile;

        public JsonDataManager()
        {
            _dataDirectory = Path.Combine(Environment.CurrentDirectory, "Data");
            _ingredientsFile = Path.Combine(_dataDirectory, "ingredients.json");
            _mealsFile = Path.Combine(_dataDirectory, "meals.json");
            _dietEntriesFile = Path.Combine(_dataDirectory, "diet_entries.json");

            EnsureDataDirectoryExists();
        }

        private void EnsureDataDirectoryExists()
        {
            if (!Directory.Exists(_dataDirectory))
            {
                Directory.CreateDirectory(_dataDirectory);
            }
        }

        public List<Ingredient> LoadIngredients()
        {
            try
            {
                if (!File.Exists(_ingredientsFile))
                {
                    return new List<Ingredient>();
                }

                string jsonContent = File.ReadAllText(_ingredientsFile);
                if (string.IsNullOrWhiteSpace(jsonContent))
                {
                    return new List<Ingredient>();
                }

                List<Ingredient>? ingredients = JsonSerializer.Deserialize<List<Ingredient>>(jsonContent);
                return ingredients ?? new List<Ingredient>();
            }
            catch (Exception)
            {
                return new List<Ingredient>();
            }
        }

        public void SaveIngredients(List<Ingredient> ingredients)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true  // SHOULD BE GLOBAL CONSTANT!!
                };

                string jsonContent = JsonSerializer.Serialize(ingredients, options);
                File.WriteAllText(_ingredientsFile, jsonContent);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to save ingredients: " + ex.Message);
            }
        }

        public List<Meal> LoadMeals()
        {
            try
            {
                if (!File.Exists(_mealsFile))
                {
                    return new List<Meal>();
                }

                string jsonContent = File.ReadAllText(_mealsFile);
                if (string.IsNullOrWhiteSpace(jsonContent))
                {
                    return new List<Meal>();
                }

                List<Meal>? meals = JsonSerializer.Deserialize<List<Meal>>(jsonContent);
                return meals ?? new List<Meal>();
            }
            catch (Exception)
            {
                return new List<Meal>();
            }
        }

        public void SaveMeals(List<Meal> meals)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonContent = JsonSerializer.Serialize(meals, options);
                File.WriteAllText(_mealsFile, jsonContent);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to save meals: " + ex.Message);
            }
        }

        public List<DietEntry> LoadDietEntries()
        {
            try
            {
                if (!File.Exists(_dietEntriesFile))
                {
                    return new List<DietEntry>();
                }

                string jsonContent = File.ReadAllText(_dietEntriesFile);
                if (string.IsNullOrWhiteSpace(jsonContent))
                {
                    return new List<DietEntry>();
                }

                List<DietEntry>? dietEntries = JsonSerializer.Deserialize<List<DietEntry>>(jsonContent);
                return dietEntries ?? new List<DietEntry>();
            }
            catch (Exception)
            {
                return new List<DietEntry>();
            }
        }

        public void SaveDietEntries(List<DietEntry> dietEntries)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonContent = JsonSerializer.Serialize(dietEntries, options);
                File.WriteAllText(_dietEntriesFile, jsonContent);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to save diet entries: " + ex.Message);
            }
        }
    }
} 