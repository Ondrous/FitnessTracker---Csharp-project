namespace FitnessTracker.Controls
{
    partial class StatisticsControl
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
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.weeklyButton = new System.Windows.Forms.Button();
            this.monthlyButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.statisticsGrid = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaloriesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProteinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarbsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryTitleLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(213, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nutrition Statistics";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(20, 70);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(64, 15);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "Start Date:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(100, 68);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(150, 23);
            this.startDatePicker.TabIndex = 2;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(270, 70);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(57, 15);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(350, 68);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(150, 23);
            this.endDatePicker.TabIndex = 4;
            // 
            // weeklyButton
            // 
            this.weeklyButton.Location = new System.Drawing.Point(520, 65);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(100, 30);
            this.weeklyButton.TabIndex = 5;
            this.weeklyButton.Text = "Last 7 Days";
            this.weeklyButton.UseVisualStyleBackColor = true;
            this.weeklyButton.Click += new System.EventHandler(this.weeklyButton_Click);
            // 
            // monthlyButton
            // 
            this.monthlyButton.Location = new System.Drawing.Point(630, 65);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(100, 30);
            this.monthlyButton.TabIndex = 6;
            this.monthlyButton.Text = "Last 30 Days";
            this.monthlyButton.UseVisualStyleBackColor = true;
            this.monthlyButton.Click += new System.EventHandler(this.monthlyButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(750, 65);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(120, 30);
            this.generateReportButton.TabIndex = 7;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AutoSize = true;
            this.statisticsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statisticsLabel.Location = new System.Drawing.Point(20, 120);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(189, 17);
            this.statisticsLabel.TabIndex = 8;
            this.statisticsLabel.Text = "Daily Nutrition Statistics:";
            // 
            // statisticsGrid
            // 
            this.statisticsGrid.AllowUserToAddRows = false;
            this.statisticsGrid.AllowUserToDeleteRows = false;
            this.statisticsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statisticsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.CaloriesColumn,
            this.ProteinColumn,
            this.CarbsColumn,
            this.FatColumn,
            this.FiberColumn});
            this.statisticsGrid.Location = new System.Drawing.Point(20, 140);
            this.statisticsGrid.MultiSelect = false;
            this.statisticsGrid.Name = "statisticsGrid";
            this.statisticsGrid.ReadOnly = true;
            this.statisticsGrid.RowTemplate.Height = 25;
            this.statisticsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statisticsGrid.Size = new System.Drawing.Size(950, 400);
            this.statisticsGrid.TabIndex = 9;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // CaloriesColumn
            // 
            this.CaloriesColumn.HeaderText = "Calories";
            this.CaloriesColumn.Name = "CaloriesColumn";
            this.CaloriesColumn.ReadOnly = true;
            // 
            // ProteinColumn
            // 
            this.ProteinColumn.HeaderText = "Protein (g)";
            this.ProteinColumn.Name = "ProteinColumn";
            this.ProteinColumn.ReadOnly = true;
            // 
            // CarbsColumn
            // 
            this.CarbsColumn.HeaderText = "Carbs (g)";
            this.CarbsColumn.Name = "CarbsColumn";
            this.CarbsColumn.ReadOnly = true;
            // 
            // FatColumn
            // 
            this.FatColumn.HeaderText = "Fat (g)";
            this.FatColumn.Name = "FatColumn";
            this.FatColumn.ReadOnly = true;
            // 
            // FiberColumn
            // 
            this.FiberColumn.HeaderText = "Fiber (g)";
            this.FiberColumn.Name = "FiberColumn";
            this.FiberColumn.ReadOnly = true;
            // 
            // summaryTitleLabel
            // 
            this.summaryTitleLabel.AutoSize = true;
            this.summaryTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.summaryTitleLabel.Location = new System.Drawing.Point(20, 560);
            this.summaryTitleLabel.Name = "summaryTitleLabel";
            this.summaryTitleLabel.Size = new System.Drawing.Size(125, 17);
            this.summaryTitleLabel.TabIndex = 10;
            this.summaryTitleLabel.Text = "Period Summary:";
            // 
            // summaryLabel
            // 
            this.summaryLabel.BackColor = System.Drawing.Color.LightBlue;
            this.summaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summaryLabel.Location = new System.Drawing.Point(20, 580);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(950, 120);
            this.summaryLabel.TabIndex = 11;
            this.summaryLabel.Text = "No data available";
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(20, 720);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 30);
            this.goBackButton.TabIndex = 12;
            this.goBackButton.Text = "← Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // StatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.summaryTitleLabel);
            this.Controls.Add(this.statisticsGrid);
            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.monthlyButton);
            this.Controls.Add(this.weeklyButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "StatisticsControl";
            this.Size = new System.Drawing.Size(1000, 770);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.Button monthlyButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.DataGridView statisticsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaloriesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProteinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarbsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiberColumn;
        private System.Windows.Forms.Label summaryTitleLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Button goBackButton;
    }
} 