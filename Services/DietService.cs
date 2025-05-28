using FitnessTracker.Data;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    public class DietService
    {
        private readonly JsonDataManager _dataManager;
        private readonly MealService _mealService;
        private List<DietEntry> _dietEntries;

        public DietService(MealService mealService)
        {
            _dataManager = new JsonDataManager();
            _mealService = mealService;
            _dietEntries = _dataManager.LoadDietEntries();
        }

        public List<DietEntry> GetAllDietEntries()
        {
            return new List<DietEntry>(_dietEntries);
        }

        public List<DietEntry> GetDietEntriesForDate(DateTime date)
        {
            List<DietEntry> results = new List<DietEntry>();

            for (int i = 0; i < _dietEntries.Count; i++)
            {
                if (_dietEntries[i].ConsumedAt.Date == date.Date)
                {
                    results.Add(_dietEntries[i]);
                }
            }

            return results;
        }

        public List<DietEntry> GetDietEntriesForDateRange(DateTime startDate, DateTime endDate)
        {
            List<DietEntry> results = new List<DietEntry>();

            for (int i = 0; i < _dietEntries.Count; i++)
            {
                DateTime entryDate = _dietEntries[i].ConsumedAt.Date;
                if (entryDate >= startDate.Date && entryDate <= endDate.Date)
                {
                    results.Add(_dietEntries[i]);
                }
            }

            return results;
        }

        public void AddDietEntry(DietEntry dietEntry)
        {
            if (dietEntry == null)
            {
                throw new ArgumentNullException(nameof(dietEntry));
            }

            dietEntry.Id = GetNextId();
            _dietEntries.Add(dietEntry);
            SaveDietEntries();
        }

        public void UpdateDietEntry(DietEntry dietEntry)
        {
            if (dietEntry == null)
            {
                throw new ArgumentNullException(nameof(dietEntry));
            }

            for (int i = 0; i < _dietEntries.Count; i++)
            {
                if (_dietEntries[i].Id == dietEntry.Id)
                {
                    _dietEntries[i] = dietEntry;
                    SaveDietEntries();
                    return;
                }
            }

            throw new ArgumentException("Diet entry not found");
        }

        public void DeleteDietEntry(int id)
        {
            for (int i = 0; i < _dietEntries.Count; i++)
            {
                if (_dietEntries[i].Id == id)
                {
                    _dietEntries.RemoveAt(i);
                    SaveDietEntries();
                    return;
                }
            }

            throw new ArgumentException("Diet entry not found");
        }

        public NutritionSummary CalculateDailyNutrition(DateTime date)
        {
            List<DietEntry> dailyEntries = GetDietEntriesForDate(date);
            return CalculateNutritionForEntries(dailyEntries);
        }

        public NutritionSummary CalculateNutritionForDateRange(DateTime startDate, DateTime endDate)
        {
            List<DietEntry> entries = GetDietEntriesForDateRange(startDate, endDate);
            return CalculateNutritionForEntries(entries);
        }

        public Dictionary<DateTime, NutritionSummary> GetDailyNutritionSummary(DateTime startDate, DateTime endDate)
        {
            Dictionary<DateTime, NutritionSummary> dailySummaries = new Dictionary<DateTime, NutritionSummary>();

            DateTime currentDate = startDate.Date;
            while (currentDate <= endDate.Date)
            {
                NutritionSummary dailyNutrition = CalculateDailyNutrition(currentDate);
                dailySummaries[currentDate] = dailyNutrition;
                currentDate = currentDate.AddDays(1);
            }

            return dailySummaries;
        }

        private NutritionSummary CalculateNutritionForEntries(List<DietEntry> entries)
        {
            NutritionSummary totalNutrition = new NutritionSummary();

            for (int i = 0; i < entries.Count; i++)
            {
                DietEntry entry = entries[i];
                Meal? meal = _mealService.GetMealById(entry.MealId);

                if (meal != null)
                {
                    // Use the new weight-based calculation
                    // ServingSize now represents the actual weight in grams
                    double weightInGrams = entry.ServingSize;
                    NutritionSummary mealNutrition = _mealService.CalculateMealNutritionForWeight(meal, weightInGrams);

                    totalNutrition.AddNutrition(
                        mealNutrition.TotalCalories,
                        mealNutrition.TotalProtein,
                        mealNutrition.TotalCarbs,
                        mealNutrition.TotalFat,
                        mealNutrition.TotalFiber
                    );
                }
            }

            return totalNutrition;
        }

        private int GetNextId()
        {
            int maxId = 0;
            for (int i = 0; i < _dietEntries.Count; i++)
            {
                if (_dietEntries[i].Id > maxId)
                {
                    maxId = _dietEntries[i].Id;
                }
            }
            return maxId + 1;
        }

        private void SaveDietEntries()
        {
            _dataManager.SaveDietEntries(_dietEntries);
        }
    }
}