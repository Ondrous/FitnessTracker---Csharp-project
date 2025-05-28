namespace FitnessTracker.Controls
{
    partial class DietTrackingControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.mealLabel = new System.Windows.Forms.Label();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.servingLabel = new System.Windows.Forms.Label();
            this.servingSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.gramsLabel = new System.Windows.Forms.Label();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.entriesLabel = new System.Windows.Forms.Label();
            this.entriesGrid = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServingSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaloriesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editEntryButton = new System.Windows.Forms.Button();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.summaryTitleLabel = new System.Windows.Forms.Label();
            this.nutritionSummaryLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servingSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(127, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Diet Tracking";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(20, 70);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 15);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(70, 68);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 23);
            this.datePicker.TabIndex = 2;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(20, 110);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(36, 15);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(70, 108);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(100, 23);
            this.timePicker.TabIndex = 4;
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(190, 110);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(35, 15);
            this.mealLabel.TabIndex = 5;
            this.mealLabel.Text = "Meal:";
            // 
            // mealComboBox
            // 
            this.mealComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Location = new System.Drawing.Point(240, 108);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(150, 23);
            this.mealComboBox.TabIndex = 6;
            // 
            // servingLabel
            // 
            this.servingLabel.AutoSize = true;
            this.servingLabel.Location = new System.Drawing.Point(410, 90);
            this.servingLabel.Name = "servingLabel";
            this.servingLabel.Size = new System.Drawing.Size(73, 15);
            this.servingLabel.TabIndex = 7;
            this.servingLabel.Text = "Portion Size:";
            // 
            // servingSizeNumeric
            // 
            this.servingSizeNumeric.DecimalPlaces = 0;
            this.servingSizeNumeric.Increment = new decimal(new int[] {
            (int)Models.NutritionConstants.SERVING_SIZE_INCREMENT_GRAMS,
            0,
            0,
            0});
            this.servingSizeNumeric.Location = new System.Drawing.Point(410, 108);
            this.servingSizeNumeric.Maximum = new decimal(new int[] {
            (int)Models.NutritionConstants.MAX_SERVING_SIZE_GRAMS,
            0,
            0,
            0});
            this.servingSizeNumeric.Minimum = new decimal(new int[] {
            (int)Models.NutritionConstants.MIN_SERVING_SIZE_GRAMS,
            0,
            0,
            0});
            this.servingSizeNumeric.Name = "servingSizeNumeric";
            this.servingSizeNumeric.Size = new System.Drawing.Size(80, 23);
            this.servingSizeNumeric.TabIndex = 8;
            this.servingSizeNumeric.Value = new decimal(new int[] {
            (int)Models.NutritionConstants.DEFAULT_SERVING_SIZE_GRAMS,
            0,
            0,
            0});
            // 
            // gramsLabel
            // 
            this.gramsLabel.AutoSize = true;
            this.gramsLabel.Location = new System.Drawing.Point(500, 110);
            this.gramsLabel.Name = "gramsLabel";
            this.gramsLabel.Size = new System.Drawing.Size(39, 15);
            this.gramsLabel.TabIndex = 9;
            this.gramsLabel.Text = "grams";
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(550, 105);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(100, 30);
            this.addEntryButton.TabIndex = 10;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // entriesLabel
            // 
            this.entriesLabel.AutoSize = true;
            this.entriesLabel.Location = new System.Drawing.Point(20, 160);
            this.entriesLabel.Name = "entriesLabel";
            this.entriesLabel.Size = new System.Drawing.Size(86, 15);
            this.entriesLabel.TabIndex = 11;
            this.entriesLabel.Text = "Today's Meals:";
            // 
            // entriesGrid
            // 
            this.entriesGrid.AllowUserToAddRows = false;
            this.entriesGrid.AllowUserToDeleteRows = false;
            this.entriesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.TimeColumn,
            this.MealNameColumn,
            this.ServingSizeColumn,
            this.CaloriesColumn});
            this.entriesGrid.Location = new System.Drawing.Point(20, 180);
            this.entriesGrid.MultiSelect = false;
            this.entriesGrid.Name = "entriesGrid";
            this.entriesGrid.ReadOnly = true;
            this.entriesGrid.RowTemplate.Height = 25;
            this.entriesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entriesGrid.Size = new System.Drawing.Size(850, 300);
            this.entriesGrid.TabIndex = 12;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // MealNameColumn
            // 
            this.MealNameColumn.HeaderText = "Meal";
            this.MealNameColumn.Name = "MealNameColumn";
            this.MealNameColumn.ReadOnly = true;
            // 
            // ServingSizeColumn
            // 
            this.ServingSizeColumn.HeaderText = "Portion Size (g)";
            this.ServingSizeColumn.Name = "ServingSizeColumn";
            this.ServingSizeColumn.ReadOnly = true;
            // 
            // CaloriesColumn
            // 
            this.CaloriesColumn.HeaderText = "Calories";
            this.CaloriesColumn.Name = "CaloriesColumn";
            this.CaloriesColumn.ReadOnly = true;
            // 
            // editEntryButton
            // 
            this.editEntryButton.Location = new System.Drawing.Point(20, 490);
            this.editEntryButton.Name = "editEntryButton";
            this.editEntryButton.Size = new System.Drawing.Size(100, 30);
            this.editEntryButton.TabIndex = 13;
            this.editEntryButton.Text = "Edit Entry";
            this.editEntryButton.UseVisualStyleBackColor = true;
            this.editEntryButton.Click += new System.EventHandler(this.editEntryButton_Click);
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Location = new System.Drawing.Point(130, 490);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(100, 30);
            this.deleteEntryButton.TabIndex = 14;
            this.deleteEntryButton.Text = "Delete Entry";
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // summaryTitleLabel
            // 
            this.summaryTitleLabel.AutoSize = true;
            this.summaryTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.summaryTitleLabel.Location = new System.Drawing.Point(20, 540);
            this.summaryTitleLabel.Name = "summaryTitleLabel";
            this.summaryTitleLabel.Size = new System.Drawing.Size(158, 20);
            this.summaryTitleLabel.TabIndex = 15;
            this.summaryTitleLabel.Text = "Nutrition Summary:";
            // 
            // nutritionSummaryLabel
            // 
            this.nutritionSummaryLabel.AutoSize = true;
            this.nutritionSummaryLabel.Location = new System.Drawing.Point(20, 570);
            this.nutritionSummaryLabel.Name = "nutritionSummaryLabel";
            this.nutritionSummaryLabel.Size = new System.Drawing.Size(0, 15);
            this.nutritionSummaryLabel.TabIndex = 16;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(20, 750);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 30);
            this.goBackButton.TabIndex = 17;
            this.goBackButton.Text = "← Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // DietTrackingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.nutritionSummaryLabel);
            this.Controls.Add(this.summaryTitleLabel);
            this.Controls.Add(this.deleteEntryButton);
            this.Controls.Add(this.editEntryButton);
            this.Controls.Add(this.entriesGrid);
            this.Controls.Add(this.entriesLabel);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.gramsLabel);
            this.Controls.Add(this.servingSizeNumeric);
            this.Controls.Add(this.servingLabel);
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "DietTrackingControl";
            this.Size = new System.Drawing.Size(900, 800);
            ((System.ComponentModel.ISupportInitialize)(this.servingSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.ComboBox mealComboBox;
        private System.Windows.Forms.Label servingLabel;
        private System.Windows.Forms.NumericUpDown servingSizeNumeric;
        private System.Windows.Forms.Label gramsLabel;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Label entriesLabel;
        private System.Windows.Forms.DataGridView entriesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServingSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaloriesColumn;
        private System.Windows.Forms.Button editEntryButton;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.Label summaryTitleLabel;
        private System.Windows.Forms.Label nutritionSummaryLabel;
        private System.Windows.Forms.Button goBackButton;
    }
} 