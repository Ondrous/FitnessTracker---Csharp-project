namespace FitnessTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _contentPanel = new Panel();
            statisticsButton = new Button();
            dietButton = new Button();
            mealsButton = new Button();
            ingredientsButton = new Button();
            titleLabel = new Label();
            _contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _contentPanel
            // 
            _contentPanel.BackColor = Color.White;
            _contentPanel.Controls.Add(statisticsButton);
            _contentPanel.Controls.Add(dietButton);
            _contentPanel.Controls.Add(mealsButton);
            _contentPanel.Controls.Add(ingredientsButton);
            _contentPanel.Controls.Add(titleLabel);
            _contentPanel.Dock = DockStyle.Fill;
            _contentPanel.Location = new Point(0, 0);
            _contentPanel.Name = "_contentPanel";
            _contentPanel.Size = new Size(1104, 812);
            _contentPanel.TabIndex = 0;
            // 
            // statisticsButton
            // 
            statisticsButton.BackColor = Color.WhiteSmoke;
            statisticsButton.FlatStyle = FlatStyle.Flat;
            statisticsButton.Font = new Font("Segoe UI", 12F);
            statisticsButton.Location = new Point(573, 385);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(200, 60);
            statisticsButton.TabIndex = 4;
            statisticsButton.Text = "View Statistics";
            statisticsButton.UseVisualStyleBackColor = false;
            statisticsButton.Click += StatisticsButton_Click;
            // 
            // dietButton
            // 
            dietButton.BackColor = Color.WhiteSmoke;
            dietButton.FlatStyle = FlatStyle.Flat;
            dietButton.Font = new Font("Segoe UI", 12F);
            dietButton.Location = new Point(323, 385);
            dietButton.Name = "dietButton";
            dietButton.Size = new Size(200, 60);
            dietButton.TabIndex = 3;
            dietButton.Text = "Diet Tracking";
            dietButton.UseVisualStyleBackColor = false;
            dietButton.Click += DietButton_Click;
            // 
            // mealsButton
            // 
            mealsButton.BackColor = Color.WhiteSmoke;
            mealsButton.FlatStyle = FlatStyle.Flat;
            mealsButton.Font = new Font("Segoe UI", 12F);
            mealsButton.Location = new Point(573, 285);
            mealsButton.Name = "mealsButton";
            mealsButton.Size = new Size(200, 60);
            mealsButton.TabIndex = 2;
            mealsButton.Text = "Manage Meals";
            mealsButton.UseVisualStyleBackColor = false;
            mealsButton.Click += MealsButton_Click;
            // 
            // ingredientsButton
            // 
            ingredientsButton.BackColor = Color.WhiteSmoke;
            ingredientsButton.FlatStyle = FlatStyle.Flat;
            ingredientsButton.Font = new Font("Segoe UI", 12F);
            ingredientsButton.Location = new Point(323, 285);
            ingredientsButton.Name = "ingredientsButton";
            ingredientsButton.Size = new Size(200, 60);
            ingredientsButton.TabIndex = 1;
            ingredientsButton.Text = "Manage Ingredients";
            ingredientsButton.UseVisualStyleBackColor = false;
            ingredientsButton.Click += IngredientsButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(427, 110);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(241, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Fitness Tracker";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 812);
            Controls.Add(_contentPanel);
            Name = "MainForm";
            Text = "Fitness Tracker - Main Menu";
            WindowState = FormWindowState.Maximized;
            _contentPanel.ResumeLayout(false);
            _contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel _contentPanel;
        private Label titleLabel;
        private Button ingredientsButton;
        private Button mealsButton;
        private Button dietButton;
        private Button statisticsButton;
    }
} 