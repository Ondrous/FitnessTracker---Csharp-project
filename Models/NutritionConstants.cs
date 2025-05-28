namespace FitnessTracker.Models
{
    /// <summary>
    /// Contains all nutrition-related constants used throughout the application
    /// </summary>
    public static class NutritionConstants
    {
        /// <summary>
        /// Calories per gram of protein (standard nutritional value)
        /// </summary>
        public const double CALORIES_PER_GRAM_PROTEIN = 4.0;

        /// <summary>
        /// Calories per gram of carbohydrates (standard nutritional value)
        /// </summary>
        public const double CALORIES_PER_GRAM_CARBS = 4.0;

        /// <summary>
        /// Calories per gram of fat (standard nutritional value)
        /// </summary>
        public const double CALORIES_PER_GRAM_FAT = 9.0;

        /// <summary>
        /// Standard reference weight for nutritional values (grams)
        /// </summary>
        public const double REFERENCE_WEIGHT_GRAMS = 100.0;

        /// <summary>
        /// Default serving size for meal ingredients (grams)
        /// </summary>
        public const double DEFAULT_SERVING_SIZE_GRAMS = 100.0;

        /// <summary>
        /// Minimum serving size allowed (grams)
        /// </summary>
        public const double MIN_SERVING_SIZE_GRAMS = 1.0;

        /// <summary>
        /// Maximum serving size allowed (grams)
        /// </summary>
        public const double MAX_SERVING_SIZE_GRAMS = 2000.0;

        /// <summary>
        /// Serving size increment for UI controls (grams)
        /// </summary>
        public const double SERVING_SIZE_INCREMENT_GRAMS = 10.0;

        /// <summary>
        /// Maximum calories per 100g for ingredient validation
        /// </summary>
        public const double MAX_CALORIES_PER_100G = 9999.0;

        /// <summary>
        /// Maximum macronutrient value per 100g for ingredient validation
        /// </summary>
        public const double MAX_MACRONUTRIENT_PER_100G = 999.0;

        /// <summary>
        /// Percentage multiplier for converting decimal ratios to percentages
        /// </summary>
        public const double PERCENTAGE_MULTIPLIER = 100.0;
    }
} 