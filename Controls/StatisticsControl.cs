using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FitnessTracker.Models;
using FitnessTracker.Services;

namespace FitnessTracker.Controls
{
    public partial class StatisticsControl : UserControl
    {
        private readonly DietService _dietService;

        public event EventHandler? GoBackRequested;

        public StatisticsControl(DietService dietService)
        {
            _dietService = dietService;
            InitializeComponent();
            SetDefaultDateRange();
        }

        private void SetDefaultDateRange()
        {
            endDatePicker.Value = DateTime.Today;
            startDatePicker.Value = DateTime.Today.AddDays(-7);
        }

        private void weeklyButton_Click(object sender, EventArgs e)
        {
            endDatePicker.Value = DateTime.Today;
            startDatePicker.Value = DateTime.Today.AddDays(-7);
        }

        private void monthlyButton_Click(object sender, EventArgs e)
        {
            endDatePicker.Value = DateTime.Today;
            startDatePicker.Value = DateTime.Today.AddDays(-30);
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be later than end date.", "Invalid Date Range", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GenerateStatisticsReport(startDate, endDate);
        }

        private void GenerateStatisticsReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                Dictionary<DateTime, NutritionSummary> dailySummaries = 
                    _dietService.GetDailyNutritionSummary(startDate, endDate);

                PopulateStatisticsGrid(dailySummaries);
                GeneratePeriodSummary(dailySummaries, startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating statistics: " + ex.Message, "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateStatisticsGrid(Dictionary<DateTime, NutritionSummary> dailySummaries)
        {
            statisticsGrid.Rows.Clear();

            foreach (KeyValuePair<DateTime, NutritionSummary> kvp in dailySummaries)
            {
                DateTime date = kvp.Key;
                NutritionSummary nutrition = kvp.Value;

                statisticsGrid.Rows.Add(
                    date.ToString("yyyy-MM-dd"),
                    nutrition.TotalCalories.ToString("F1"),
                    nutrition.TotalProtein.ToString("F1"),
                    nutrition.TotalCarbs.ToString("F1"),
                    nutrition.TotalFat.ToString("F1"),
                    nutrition.TotalFiber.ToString("F1")
                );
            }
        }

        private void GeneratePeriodSummary(Dictionary<DateTime, NutritionSummary> dailySummaries, 
                                         DateTime startDate, DateTime endDate)
        {
            if (dailySummaries.Count == 0)
            {
                summaryLabel.Text = "No data available for the selected period.";
                return;
            }

            NutritionSummary totalNutrition = new NutritionSummary();
            int daysWithData = 0;

            foreach (KeyValuePair<DateTime, NutritionSummary> kvp in dailySummaries)
            {
                NutritionSummary dayNutrition = kvp.Value;
                if (dayNutrition.TotalCalories > 0)
                {
                    totalNutrition.AddNutrition(
                        dayNutrition.TotalCalories,
                        dayNutrition.TotalProtein,
                        dayNutrition.TotalCarbs,
                        dayNutrition.TotalFat,
                        dayNutrition.TotalFiber
                    );
                    daysWithData++;
                }
            }

            if (daysWithData == 0)
            {
                summaryLabel.Text = "No nutrition data recorded for the selected period.";
                return;
            }

            double avgCalories = totalNutrition.TotalCalories / daysWithData;
            double avgProtein = totalNutrition.TotalProtein / daysWithData;
            double avgCarbs = totalNutrition.TotalCarbs / daysWithData;
            double avgFat = totalNutrition.TotalFat / daysWithData;
            double avgFiber = totalNutrition.TotalFiber / daysWithData;

            int totalDays = (endDate - startDate).Days + 1;

            string summaryText = $"Period: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd} ({totalDays} days)\n" +
                               $"Days with recorded data: {daysWithData}\n\n" +
                               $"TOTAL CONSUMPTION:\n" +
                               $"Total Calories: {totalNutrition.TotalCalories:F1}\n" +
                               $"Total Protein: {totalNutrition.TotalProtein:F1}g\n" +
                               $"Total Carbs: {totalNutrition.TotalCarbs:F1}g\n" +
                               $"Total Fat: {totalNutrition.TotalFat:F1}g\n" +
                               $"Total Fiber: {totalNutrition.TotalFiber:F1}g\n\n" +
                               $"DAILY AVERAGES:\n" +
                               $"Avg Calories: {avgCalories:F1}\n" +
                               $"Avg Protein: {avgProtein:F1}g\n" +
                               $"Avg Carbs: {avgCarbs:F1}g\n" +
                               $"Avg Fat: {avgFat:F1}g\n" +
                               $"Avg Fiber: {avgFiber:F1}g";

            summaryLabel.Text = summaryText;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            GoBackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
} 