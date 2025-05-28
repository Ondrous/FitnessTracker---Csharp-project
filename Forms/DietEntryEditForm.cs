using FitnessTracker.Models;
using FitnessTracker.Services;

namespace FitnessTracker.Forms
{
    public partial class DietEntryEditForm : Form
    {
        private readonly MealService _mealService;
        private readonly List<Meal> _availableMeals;
        private DietEntry _dietEntry;

        public DietEntry DietEntry => _dietEntry;

        public DietEntryEditForm(DietEntry dietEntry, MealService mealService)
        {
            _dietEntry = dietEntry;
            _mealService = mealService;
            _availableMeals = _mealService.GetAllMeals();

            InitializeComponent();
            LoadMeals();
            LoadDietEntryData();
        }

        private void LoadMeals()
        {
            mealComboBox.Items.Clear();

            for (int i = 0; i < _availableMeals.Count; i++)
            {
                mealComboBox.Items.Add(_availableMeals[i].Name);
            }
        }

        private void LoadDietEntryData()
        {
            // Set the date
            datePicker.Value = _dietEntry.ConsumedAt.Date;

            // Set the time
            timePicker.Value = _dietEntry.ConsumedAt;

            // Set the serving size (ServingSize now directly represents grams)
            servingSizeNumeric.Value = (decimal)_dietEntry.ServingSize;

            // Set the selected meal
            Meal? currentMeal = _mealService.GetMealById(_dietEntry.MealId);
            if (currentMeal != null)
            {
                for (int i = 0; i < _availableMeals.Count; i++)
                {
                    if (_availableMeals[i].Id == currentMeal.Id)
                    {
                        mealComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (mealComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a meal.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the diet entry
            int selectedMealIndex = mealComboBox.SelectedIndex;
            Meal selectedMeal = _availableMeals[selectedMealIndex];

            DateTime selectedDate = datePicker.Value.Date;
            DateTime selectedTime = timePicker.Value;
            DateTime consumedAt = selectedDate.Add(selectedTime.TimeOfDay);

            // ServingSize now directly represents grams (no conversion needed)
            double servingSizeInGrams = (double)servingSizeNumeric.Value;

            _dietEntry.MealId = selectedMeal.Id;
            _dietEntry.ConsumedAt = consumedAt;
            _dietEntry.ServingSize = servingSizeInGrams;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}