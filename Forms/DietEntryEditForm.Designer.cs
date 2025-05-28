namespace FitnessTracker.Forms
{
    partial class DietEntryEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            dateLabel = new Label();
            datePicker = new DateTimePicker();
            timeLabel = new Label();
            timePicker = new DateTimePicker();
            mealLabel = new Label();
            mealComboBox = new ComboBox();
            servingLabel = new Label();
            servingSizeNumeric = new NumericUpDown();
            gramsLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)servingSizeNumeric).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(142, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Edit Diet Entry";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(20, 70);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(34, 15);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(70, 68);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(120, 23);
            datePicker.TabIndex = 2;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(210, 70);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(36, 15);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "Time:";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(260, 68);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(100, 23);
            timePicker.TabIndex = 4;
            // 
            // mealLabel
            // 
            mealLabel.AutoSize = true;
            mealLabel.Location = new Point(20, 110);
            mealLabel.Name = "mealLabel";
            mealLabel.Size = new Size(35, 15);
            mealLabel.TabIndex = 5;
            mealLabel.Text = "Meal:";
            // 
            // mealComboBox
            // 
            mealComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mealComboBox.FormattingEnabled = true;
            mealComboBox.Location = new Point(70, 108);
            mealComboBox.Name = "mealComboBox";
            mealComboBox.Size = new Size(290, 23);
            mealComboBox.TabIndex = 6;
            // 
            // servingLabel
            // 
            servingLabel.AutoSize = true;
            servingLabel.Location = new Point(20, 150);
            servingLabel.Name = "servingLabel";
            servingLabel.Size = new Size(73, 15);
            servingLabel.TabIndex = 7;
            servingLabel.Text = "Portion Size:";
            // 
            // servingSizeNumeric
            // 
            servingSizeNumeric.DecimalPlaces = 0;
            servingSizeNumeric.Increment = new decimal(new int[] { (int)Models.NutritionConstants.SERVING_SIZE_INCREMENT_GRAMS, 0, 0, 0 });
            servingSizeNumeric.Location = new Point(110, 148);
            servingSizeNumeric.Maximum = new decimal(new int[] { (int)Models.NutritionConstants.MAX_SERVING_SIZE_GRAMS, 0, 0, 0 });
            servingSizeNumeric.Minimum = new decimal(new int[] { (int)Models.NutritionConstants.MIN_SERVING_SIZE_GRAMS, 0, 0, 0 });
            servingSizeNumeric.Name = "servingSizeNumeric";
            servingSizeNumeric.Size = new Size(80, 23);
            servingSizeNumeric.TabIndex = 8;
            servingSizeNumeric.Value = new decimal(new int[] { (int)Models.NutritionConstants.DEFAULT_SERVING_SIZE_GRAMS, 0, 0, 0 });
            // 
            // gramsLabel
            // 
            gramsLabel.AutoSize = true;
            gramsLabel.Location = new Point(200, 150);
            gramsLabel.Name = "gramsLabel";
            gramsLabel.Size = new Size(39, 15);
            gramsLabel.TabIndex = 9;
            gramsLabel.Text = "grams";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGreen;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(200, 200);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(80, 30);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.LightCoral;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Location = new Point(290, 200);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(80, 30);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // DietEntryEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 260);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(gramsLabel);
            Controls.Add(servingSizeNumeric);
            Controls.Add(servingLabel);
            Controls.Add(mealComboBox);
            Controls.Add(mealLabel);
            Controls.Add(timePicker);
            Controls.Add(timeLabel);
            Controls.Add(datePicker);
            Controls.Add(dateLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DietEntryEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Diet Entry";
            ((System.ComponentModel.ISupportInitialize)servingSizeNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label dateLabel;
        private DateTimePicker datePicker;
        private Label timeLabel;
        private DateTimePicker timePicker;
        private Label mealLabel;
        private ComboBox mealComboBox;
        private Label servingLabel;
        private NumericUpDown servingSizeNumeric;
        private Label gramsLabel;
        private Button saveButton;
        private Button cancelButton;
    }
} 