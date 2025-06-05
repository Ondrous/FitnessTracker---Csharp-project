using System;
using System.Windows.Forms;
using FitnessTracker.Services;
using FitnessTracker.Controls;

namespace FitnessTracker
{
    /// <summary>
    /// Main application window that acts as a navigation hub between different features.
    /// Initializes all service dependencies and manages the display of different UserControls
    /// for ingredients, meals, diet tracking, and statistics. Handles navigation events
    /// and ensures proper cleanup when switching between different sections of the app.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IngredientService _ingredientService;
        private readonly MealService _mealService;
        private readonly DietService _dietService;
        private UserControl? _currentControl;

        public MainForm()
        {
            InitializeComponent();
            
            // initialize services
            _ingredientService = new IngredientService();
            _mealService = new MealService(_ingredientService);
            _dietService = new DietService(_mealService);
            
            // show main menu by default
            ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            ClearContent(); // clears the main content panel
            
            // show the main menu controls (they are already defined in the designer)
            titleLabel.Visible = true;
            ingredientsButton.Visible = true;
            mealsButton.Visible = true;
            dietButton.Visible = true;
            statisticsButton.Visible = true;
        }

        private void ShowControl(UserControl control)
        {
            ClearContent(); // clears the main content panel first
            
            // hide main menu controls
            titleLabel.Visible = false;
            ingredientsButton.Visible = false;
            mealsButton.Visible = false;
            dietButton.Visible = false;
            statisticsButton.Visible = false;
            
            _currentControl = control;
            control.Dock = DockStyle.Fill; // docks the control to fill the panel
            _contentPanel.Controls.Add(control);
            
            // subscribe to gobackrequested event if the control supports it
            if (control is IngredientControl ingredientControl)
            {
                ingredientControl.GoBackRequested += (s, e) => ShowMainMenu();
            }
            else if (control is MealControl mealControl)
            {
                mealControl.GoBackRequested += (s, e) => ShowMainMenu();
            }
            else if (control is DietTrackingControl dietControl)
            {
                dietControl.GoBackRequested += (s, e) => ShowMainMenu();
            }
            else if (control is StatisticsControl statsControl)
            {
                statsControl.GoBackRequested += (s, e) => ShowMainMenu();
            }
        }

        private void ClearContent()
        {
            if (_currentControl != null)
            {
                // unsubscribe from events to prevent memory leaks
                if (_currentControl is IngredientControl ingredientControl)
                {
                    ingredientControl.GoBackRequested -= (s, e) => ShowMainMenu();
                }
                else if (_currentControl is MealControl mealControl)
                {
                    mealControl.GoBackRequested -= (s, e) => ShowMainMenu();
                }
                else if (_currentControl is DietTrackingControl dietControl)
                {
                    dietControl.GoBackRequested -= (s, e) => ShowMainMenu();
                }
                else if (_currentControl is StatisticsControl statsControl)
                {
                    statsControl.GoBackRequested -= (s, e) => ShowMainMenu();
                }
                
                _contentPanel.Controls.Remove(_currentControl); // remove the current control from the panel
                _currentControl = null; // reset the current control reference
            }
        }

        // event handlers for the buttons (referenced in the designer)
        private void IngredientsButton_Click(object sender, EventArgs e)
        {
            ShowControl(new IngredientControl(_ingredientService)); // shows the ingredient management control
        }

        private void MealsButton_Click(object sender, EventArgs e)
        {
            ShowControl(new MealControl(_mealService, _ingredientService)); // shows the meal management control
        }

        private void DietButton_Click(object sender, EventArgs e)
        {
            ShowControl(new DietTrackingControl(_dietService, _mealService)); // shows the diet tracking control
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            ShowControl(new StatisticsControl(_dietService)); // shows the statistics control
        }
    }
} 