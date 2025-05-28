namespace FitnessTracker.Forms
{
    partial class IngredientEditForm
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
            nameLabel = new Label();
            _nameTextBox = new TextBox();
            caloriesLabel = new Label();
            _caloriesNumeric = new NumericUpDown();
            _calculateCaloriesButton = new Button();
            proteinLabel = new Label();
            _proteinNumeric = new NumericUpDown();
            carbsLabel = new Label();
            _carbsNumeric = new NumericUpDown();
            fatLabel = new Label();
            _fatNumeric = new NumericUpDown();
            fiberLabel = new Label();
            _fiberNumeric = new NumericUpDown();
            _okButton = new Button();
            _cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)_caloriesNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_proteinNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_carbsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_fatNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_fiberNumeric).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(20, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // _nameTextBox
            // 
            _nameTextBox.Location = new Point(120, 18);
            _nameTextBox.Name = "_nameTextBox";
            _nameTextBox.Size = new Size(250, 23);
            _nameTextBox.TabIndex = 1;
            // 
            // caloriesLabel
            // 
            caloriesLabel.AutoSize = true;
            caloriesLabel.Location = new Point(20, 60);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(82, 15);
            caloriesLabel.TabIndex = 2;
            caloriesLabel.Text = "Calories/100g:";
            // 
            // _caloriesNumeric
            // 
            _caloriesNumeric.DecimalPlaces = 1;
            _caloriesNumeric.Location = new Point(120, 58);
            _caloriesNumeric.Maximum = new decimal(new int[] { (int)Models.NutritionConstants.MAX_CALORIES_PER_100G, 0, 0, 0 });
            _caloriesNumeric.Name = "_caloriesNumeric";
            _caloriesNumeric.Size = new Size(100, 23);
            _caloriesNumeric.TabIndex = 3;
            // 
            // _calculateCaloriesButton
            // 
            _calculateCaloriesButton.BackColor = Color.LightBlue;
            _calculateCaloriesButton.FlatStyle = FlatStyle.Flat;
            _calculateCaloriesButton.Location = new Point(230, 58);
            _calculateCaloriesButton.Name = "_calculateCaloriesButton";
            _calculateCaloriesButton.Size = new Size(140, 23);
            _calculateCaloriesButton.TabIndex = 4;
            _calculateCaloriesButton.Text = "Calculate from Macros";
            _calculateCaloriesButton.UseVisualStyleBackColor = false;
            _calculateCaloriesButton.Click += CalculateCaloriesButton_Click;
            // 
            // proteinLabel
            // 
            proteinLabel.AutoSize = true;
            proteinLabel.Location = new Point(20, 100);
            proteinLabel.Name = "proteinLabel";
            proteinLabel.Size = new Size(79, 15);
            proteinLabel.TabIndex = 5;
            proteinLabel.Text = "Protein/100g:";
            // 
            // _proteinNumeric
            // 
            _proteinNumeric.DecimalPlaces = 1;
            _proteinNumeric.Location = new Point(120, 98);
            _proteinNumeric.Maximum = new decimal(new int[] { (int)Models.NutritionConstants.MAX_MACRONUTRIENT_PER_100G, 0, 0, 0 });
            _proteinNumeric.Name = "_proteinNumeric";
            _proteinNumeric.Size = new Size(100, 23);
            _proteinNumeric.TabIndex = 6;
            // 
            // carbsLabel
            // 
            carbsLabel.AutoSize = true;
            carbsLabel.Location = new Point(20, 140);
            carbsLabel.Name = "carbsLabel";
            carbsLabel.Size = new Size(72, 15);
            carbsLabel.TabIndex = 7;
            carbsLabel.Text = "Carbs/100g:";
            // 
            // _carbsNumeric
            // 
            _carbsNumeric.DecimalPlaces = 1;
            _carbsNumeric.Location = new Point(120, 138);
            _carbsNumeric.Maximum = new decimal(new int[] { (int)Models.NutritionConstants.MAX_MACRONUTRIENT_PER_100G, 0, 0, 0 });
            _carbsNumeric.Name = "_carbsNumeric";
            _carbsNumeric.Size = new Size(100, 23);
            _carbsNumeric.TabIndex = 8;
            // 
            // fatLabel
            // 
            fatLabel.AutoSize = true;
            fatLabel.Location = new Point(20, 180);
            fatLabel.Name = "fatLabel";
            fatLabel.Size = new Size(60, 15);
            fatLabel.TabIndex = 9;
            fatLabel.Text = "Fat/100g:";
            // 
            // _fatNumeric
            // 
            _fatNumeric.DecimalPlaces = 1;
            _fatNumeric.Location = new Point(120, 178);
            _fatNumeric.Maximum = new decimal(new int[] { (int)Models.NutritionConstants.MAX_MACRONUTRIENT_PER_100G, 0, 0, 0 });
            _fatNumeric.Name = "_fatNumeric";
            _fatNumeric.Size = new Size(100, 23);
            _fatNumeric.TabIndex = 10;
            // 
            // fiberLabel
            // 
            fiberLabel.AutoSize = true;
            fiberLabel.Location = new Point(20, 220);
            fiberLabel.Name = "fiberLabel";
            fiberLabel.Size = new Size(67, 15);
            fiberLabel.TabIndex = 11;
            fiberLabel.Text = "Fiber/100g:";
            // 
            // _fiberNumeric
            // 
            _fiberNumeric.DecimalPlaces = 1;
            _fiberNumeric.Location = new Point(120, 218);
            _fiberNumeric.Maximum = new decimal(new int[] { (int)Models.NutritionConstants.MAX_MACRONUTRIENT_PER_100G, 0, 0, 0 });
            _fiberNumeric.Name = "_fiberNumeric";
            _fiberNumeric.Size = new Size(100, 23);
            _fiberNumeric.TabIndex = 12;
            // 
            // _okButton
            // 
            _okButton.Location = new Point(200, 270);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(80, 30);
            _okButton.TabIndex = 13;
            _okButton.Text = "OK";
            _okButton.UseVisualStyleBackColor = true;
            _okButton.Click += OkButton_Click;
            // 
            // _cancelButton
            // 
            _cancelButton.Location = new Point(290, 270);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(80, 30);
            _cancelButton.TabIndex = 14;
            _cancelButton.Text = "Cancel";
            _cancelButton.UseVisualStyleBackColor = true;
            _cancelButton.Click += CancelButton_Click;
            // 
            // IngredientEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 320);
            Controls.Add(_cancelButton);
            Controls.Add(_okButton);
            Controls.Add(_fiberNumeric);
            Controls.Add(fiberLabel);
            Controls.Add(_fatNumeric);
            Controls.Add(fatLabel);
            Controls.Add(_carbsNumeric);
            Controls.Add(carbsLabel);
            Controls.Add(_proteinNumeric);
            Controls.Add(proteinLabel);
            Controls.Add(_calculateCaloriesButton);
            Controls.Add(_caloriesNumeric);
            Controls.Add(caloriesLabel);
            Controls.Add(_nameTextBox);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IngredientEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Ingredient";
            ((System.ComponentModel.ISupportInitialize)_caloriesNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)_proteinNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)_carbsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)_fatNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)_fiberNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox _nameTextBox;
        private Label caloriesLabel;
        private NumericUpDown _caloriesNumeric;
        private Button _calculateCaloriesButton;
        private Label proteinLabel;
        private NumericUpDown _proteinNumeric;
        private Label carbsLabel;
        private NumericUpDown _carbsNumeric;
        private Label fatLabel;
        private NumericUpDown _fatNumeric;
        private Label fiberLabel;
        private NumericUpDown _fiberNumeric;
        private Button _okButton;
        private Button _cancelButton;
    }
} 