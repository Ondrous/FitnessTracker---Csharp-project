using System;

namespace FitnessTracker.Models
{
    /// <summary>
    /// Records when and how much of a specific meal was consumed.
    /// Links a meal to a consumption time and serving size (in grams).
    /// This is what creates the actual diet log - each entry represents
    /// one instance of eating a meal. Used by DietService for tracking daily nutrition.
    /// </summary>
    public class DietEntry
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public DateTime ConsumedAt { get; set; }
        public double ServingSize { get; set; }

        public DietEntry()
        {
            ConsumedAt = DateTime.Now;
            ServingSize = 1.0;
        }

        public DietEntry(int id, int mealId, DateTime consumedAt, double servingSize)
        {
            Id = id;
            MealId = mealId;
            ConsumedAt = consumedAt;
            ServingSize = servingSize;
        }
    }
} 