namespace FitnessTracker.Controls
{
    partial class IngredientControl
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ingredientsGrid = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaloriesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProteinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarbsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(234, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Manage Ingredients";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(20, 70);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search ingredients...";
            this.searchTextBox.Size = new System.Drawing.Size(300, 23);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(330, 70);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 25);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 110);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 30);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add New";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(130, 110);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 30);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(240, 110);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 30);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ingredientsGrid
            // 
            this.ingredientsGrid.AllowUserToAddRows = false;
            this.ingredientsGrid.AllowUserToDeleteRows = false;
            this.ingredientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.CaloriesColumn,
            this.ProteinColumn,
            this.CarbsColumn,
            this.FatColumn,
            this.FiberColumn});
            this.ingredientsGrid.Location = new System.Drawing.Point(20, 160);
            this.ingredientsGrid.MultiSelect = false;
            this.ingredientsGrid.Name = "ingredientsGrid";
            this.ingredientsGrid.ReadOnly = true;
            this.ingredientsGrid.RowTemplate.Height = 25;
            this.ingredientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingredientsGrid.Size = new System.Drawing.Size(850, 400);
            this.ingredientsGrid.TabIndex = 6;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // CaloriesColumn
            // 
            this.CaloriesColumn.HeaderText = "Calories/100g";
            this.CaloriesColumn.Name = "CaloriesColumn";
            this.CaloriesColumn.ReadOnly = true;
            // 
            // ProteinColumn
            // 
            this.ProteinColumn.HeaderText = "Protein/100g";
            this.ProteinColumn.Name = "ProteinColumn";
            this.ProteinColumn.ReadOnly = true;
            // 
            // CarbsColumn
            // 
            this.CarbsColumn.HeaderText = "Carbs/100g";
            this.CarbsColumn.Name = "CarbsColumn";
            this.CarbsColumn.ReadOnly = true;
            // 
            // FatColumn
            // 
            this.FatColumn.HeaderText = "Fat/100g";
            this.FatColumn.Name = "FatColumn";
            this.FatColumn.ReadOnly = true;
            // 
            // FiberColumn
            // 
            this.FiberColumn.HeaderText = "Fiber/100g";
            this.FiberColumn.Name = "FiberColumn";
            this.FiberColumn.ReadOnly = true;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(20, 580);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 30);
            this.goBackButton.TabIndex = 7;
            this.goBackButton.Text = "← Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // IngredientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.ingredientsGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "IngredientControl";
            this.Size = new System.Drawing.Size(900, 630);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView ingredientsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaloriesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProteinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarbsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiberColumn;
        private System.Windows.Forms.Button goBackButton;
    }
} 