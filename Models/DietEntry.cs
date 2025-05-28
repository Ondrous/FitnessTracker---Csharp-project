using System;

namespace FitnessTracker.Models
{
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