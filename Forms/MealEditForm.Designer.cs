namespace FitnessTracker.Forms
{
    partial class MealEditForm
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
            ingredientLabel = new Label();
            _ingredientComboBox = new ComboBox();
            gramsLabel = new Label();
            _gramsNumeric = new NumericUpDown();
            _addIngredientButton = new Button();
            ingredientsLabel = new Label();
            _ingredientsGrid = new DataGridView();
            IngredientIdColumn = new DataGridViewTextBoxColumn();
            IngredientNameColumn = new DataGridViewTextBoxColumn();
            GramsColumn = new DataGridViewTextBoxColumn();
            _removeIngredientButton = new Button();
            _okButton = new Button();
            _cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)_gramsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_ingredientsGrid).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(20, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(72, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Meal Name:";
            // 
            // _nameTextBox
            // 
            _nameTextBox.Location = new Point(120, 18);
            _nameTextBox.Name = "_nameTextBox";
            _nameTextBox.Size = new Size(300, 23);
            _nameTextBox.TabIndex = 1;
            // 
            // ingredientLabel
            // 
            ingredientLabel.AutoSize = true;
            ingredientLabel.Location = new Point(20, 60);
            ingredientLabel.Name = "ingredientLabel";
            ingredientLabel.Size = new Size(89, 15);
            ingredientLabel.TabIndex = 2;
            ingredientLabel.Text = "Add Ingredient:";
            // 
            // _ingredientComboBox
            // 
            _ingredientComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _ingredientComboBox.FormattingEnabled = true;
            _ingredientComboBox.Location = new Point(120, 58);
            _ingredientComboBox.Name = "_ingredientComboBox";
            _ingredientComboBox.Size = new Size(200, 23);
            _ingredientComboBox.TabIndex = 3;
            // 
            // gramsLabel
            // 
            gramsLabel.AutoSize = true;
            gramsLabel.Location = new Point(330, 60);
            gramsLabel.Name = "gramsLabel";
            gramsLabel.Size = new Size(44, 15);
            gramsLabel.TabIndex = 4;
            gramsLabel.Text = "Grams:";
            // 
            // _gramsNumeric
            // 
            _gramsNumeric.DecimalPlaces = 1;
            _gramsNumeric.Location = new Point(380, 58);
            _gramsNumeric.Maximum = new decimal(new int[] { (int)Models.NutritionConstants.MAX_SERVING_SIZE_GRAMS, 0, 0, 0 });
            _gramsNumeric.Minimum = new decimal(new int[] { (int)Models.NutritionConstants.MIN_SERVING_SIZE_GRAMS, 0, 0, 65536 });
            _gramsNumeric.Name = "_gramsNumeric";
            _gramsNumeric.Size = new Size(80, 23);
            _gramsNumeric.TabIndex = 5;
            _gramsNumeric.Value = new decimal(new int[] { (int)Models.NutritionConstants.DEFAULT_SERVING_SIZE_GRAMS, 0, 0, 0 });
            // 
            // _addIngredientButton
            // 
            _addIngredientButton.Location = new Point(470, 58);
            _addIngredientButton.Name = "_addIngredientButton";
            _addIngredientButton.Size = new Size(60, 25);
            _addIngredientButton.TabIndex = 6;
            _addIngredientButton.Text = "Add";
            _addIngredientButton.UseVisualStyleBackColor = true;
            _addIngredientButton.Click += AddIngredientButton_Click;
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Location = new Point(20, 100);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(101, 15);
            ingredientsLabel.TabIndex = 7;
            ingredientsLabel.Text = "Meal Ingredients:";
            // 
            // _ingredientsGrid
            // 
            _ingredientsGrid.AllowUserToAddRows = false;
            _ingredientsGrid.AllowUserToDeleteRows = false;
            _ingredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _ingredientsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _ingredientsGrid.Columns.AddRange(new DataGridViewColumn[] { IngredientIdColumn, IngredientNameColumn, GramsColumn });
            _ingredientsGrid.Location = new Point(20, 120);
            _ingredientsGrid.MultiSelect = false;
            _ingredientsGrid.Name = "_ingredientsGrid";
            _ingredientsGrid.ReadOnly = true;
            _ingredientsGrid.RowTemplate.Height = 25;
            _ingredientsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _ingredientsGrid.Size = new Size(540, 250);
            _ingredientsGrid.TabIndex = 8;
            // 
            // IngredientIdColumn
            // 
            IngredientIdColumn.HeaderText = "ID";
            IngredientIdColumn.Name = "IngredientIdColumn";
            IngredientIdColumn.ReadOnly = true;
            IngredientIdColumn.Visible = false;
            // 
            // IngredientNameColumn
            // 
            IngredientNameColumn.HeaderText = "Ingredient";
            IngredientNameColumn.Name = "IngredientNameColumn";
            IngredientNameColumn.ReadOnly = true;
            // 
            // GramsColumn
            // 
            GramsColumn.HeaderText = "Grams";
            GramsColumn.Name = "GramsColumn";
            GramsColumn.ReadOnly = true;
            // 
            // _removeIngredientButton
            // 
            _removeIngredientButton.Location = new Point(20, 380);
            _removeIngredientButton.Name = "_removeIngredientButton";
            _removeIngredientButton.Size = new Size(120, 30);
            _removeIngredientButton.TabIndex = 9;
            _removeIngredientButton.Text = "Remove Selected";
            _removeIngredientButton.UseVisualStyleBackColor = true;
            _removeIngredientButton.Click += RemoveIngredientButton_Click;
            // 
            // _okButton
            // 
            _okButton.Location = new Point(400, 420);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(80, 30);
            _okButton.TabIndex = 10;
            _okButton.Text = "OK";
            _okButton.UseVisualStyleBackColor = true;
            _okButton.Click += OkButton_Click;
            // 
            // _cancelButton
            // 
            _cancelButton.Location = new Point(490, 420);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(80, 30);
            _cancelButton.TabIndex = 11;
            _cancelButton.Text = "Cancel";
            _cancelButton.UseVisualStyleBackColor = true;
            _cancelButton.Click += CancelButton_Click;
            // 
            // MealEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 470);
            Controls.Add(_cancelButton);
            Controls.Add(_okButton);
            Controls.Add(_removeIngredientButton);
            Controls.Add(_ingredientsGrid);
            Controls.Add(ingredientsLabel);
            Controls.Add(_addIngredientButton);
            Controls.Add(_gramsNumeric);
            Controls.Add(gramsLabel);
            Controls.Add(_ingredientComboBox);
            Controls.Add(ingredientLabel);
            Controls.Add(_nameTextBox);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MealEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Meal";
            ((System.ComponentModel.ISupportInitialize)_gramsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)_ingredientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox _nameTextBox;
        private Label ingredientLabel;
        private ComboBox _ingredientComboBox;
        private Label gramsLabel;
        private NumericUpDown _gramsNumeric;
        private Button _addIngredientButton;
        private Label ingredientsLabel;
        private DataGridView _ingredientsGrid;
        private DataGridViewTextBoxColumn IngredientIdColumn;
        private DataGridViewTextBoxColumn IngredientNameColumn;
        private DataGridViewTextBoxColumn GramsColumn;
        private Button _removeIngredientButton;
        private Button _okButton;
        private Button _cancelButton;
    }
} 