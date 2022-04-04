﻿namespace UIFEDiet
{
    partial class FormUserEditMeal
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMeal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbPorsion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvMeals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbFoods = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMealName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbFoods = new System.Windows.Forms.ListBox();
            this.btnCreateMeal = new System.Windows.Forms.Button();
            this.btnCompleteMeal = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.grbFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity:";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(107, 169);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(200, 24);
            this.nudQty.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meal:";
            // 
            // cbMeal
            // 
            this.cbMeal.FormattingEnabled = true;
            this.cbMeal.Location = new System.Drawing.Point(107, 12);
            this.cbMeal.Name = "cbMeal";
            this.cbMeal.Size = new System.Drawing.Size(200, 24);
            this.cbMeal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Food:";
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(107, 126);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(200, 24);
            this.cbFood.TabIndex = 10;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // cbPorsion
            // 
            this.cbPorsion.FormattingEnabled = true;
            this.cbPorsion.Location = new System.Drawing.Point(107, 199);
            this.cbPorsion.Name = "cbPorsion";
            this.cbPorsion.Size = new System.Drawing.Size(200, 24);
            this.cbPorsion.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Porsion:";
            // 
            // lvMeals
            // 
            this.lvMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMeals.FullRowSelect = true;
            this.lvMeals.GridLines = true;
            this.lvMeals.HideSelection = false;
            this.lvMeals.Location = new System.Drawing.Point(0, 65);
            this.lvMeals.Name = "lvMeals";
            this.lvMeals.Size = new System.Drawing.Size(429, 183);
            this.lvMeals.TabIndex = 16;
            this.lvMeals.UseCompatibleStateImageBehavior = false;
            this.lvMeals.View = System.Windows.Forms.View.Details;
            this.lvMeals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMeals_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Meal";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Food";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Porsion";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Calories";
            this.columnHeader4.Width = 121;
            // 
            // grbFoods
            // 
            this.grbFoods.Controls.Add(this.button1);
            this.grbFoods.Controls.Add(this.label6);
            this.grbFoods.Controls.Add(this.cbMealName);
            this.grbFoods.Controls.Add(this.label5);
            this.grbFoods.Controls.Add(this.dtpDate);
            this.grbFoods.Controls.Add(this.lvMeals);
            this.grbFoods.Controls.Add(this.btnDelete);
            this.grbFoods.Controls.Add(this.btnUpdate);
            this.grbFoods.Location = new System.Drawing.Point(21, 300);
            this.grbFoods.Name = "grbFoods";
            this.grbFoods.Size = new System.Drawing.Size(450, 315);
            this.grbFoods.TabIndex = 17;
            this.grbFoods.TabStop = false;
            this.grbFoods.Text = "Foods";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::UIFEDiet.Properties.Resources.refresh_64px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(255, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 53);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Meal Name:";
            // 
            // cbMealName
            // 
            this.cbMealName.FormattingEnabled = true;
            this.cbMealName.Location = new System.Drawing.Point(116, 271);
            this.cbMealName.Name = "cbMealName";
            this.cbMealName.Size = new System.Drawing.Size(121, 24);
            this.cbMealName.TabIndex = 19;
            this.cbMealName.SelectedIndexChanged += new System.EventHandler(this.cbMealName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date to edit:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(173, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(256, 24);
            this.dtpDate.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::UIFEDiet.Properties.Resources.delete2;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(390, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 51);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::UIFEDiet.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(320, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 53);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbFoods
            // 
            this.lbFoods.FormattingEnabled = true;
            this.lbFoods.ItemHeight = 16;
            this.lbFoods.Location = new System.Drawing.Point(321, 210);
            this.lbFoods.Name = "lbFoods";
            this.lbFoods.Size = new System.Drawing.Size(120, 84);
            this.lbFoods.TabIndex = 23;
            // 
            // btnCreateMeal
            // 
            this.btnCreateMeal.BackgroundImage = global::UIFEDiet.Properties.Resources.plate_100px;
            this.btnCreateMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreateMeal.FlatAppearance.BorderSize = 0;
            this.btnCreateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMeal.Location = new System.Drawing.Point(137, 40);
            this.btnCreateMeal.Name = "btnCreateMeal";
            this.btnCreateMeal.Size = new System.Drawing.Size(102, 83);
            this.btnCreateMeal.TabIndex = 24;
            this.btnCreateMeal.UseVisualStyleBackColor = true;
            this.btnCreateMeal.Click += new System.EventHandler(this.btnCreateMeal_Click);
            // 
            // btnCompleteMeal
            // 
            this.btnCompleteMeal.BackgroundImage = global::UIFEDiet.Properties.Resources.shallow_pan_of_food_48px;
            this.btnCompleteMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompleteMeal.FlatAppearance.BorderSize = 0;
            this.btnCompleteMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteMeal.Location = new System.Drawing.Point(137, 229);
            this.btnCompleteMeal.Name = "btnCompleteMeal";
            this.btnCompleteMeal.Size = new System.Drawing.Size(111, 59);
            this.btnCompleteMeal.TabIndex = 20;
            this.btnCompleteMeal.UseVisualStyleBackColor = true;
            this.btnCompleteMeal.Click += new System.EventHandler(this.btnCompleteMeal_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::UIFEDiet.Properties.Resources.back_100px;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(408, 611);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 56);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(321, 15);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(121, 98);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFood.TabIndex = 18;
            this.pbFood.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::UIFEDiet.Properties.Resources.add_100px;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(331, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 77);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormUserEditMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(483, 666);
            this.Controls.Add(this.btnCreateMeal);
            this.Controls.Add(this.lbFoods);
            this.Controls.Add(this.btnCompleteMeal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbFood);
            this.Controls.Add(this.grbFoods);
            this.Controls.Add(this.cbPorsion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMeal);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserEditMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserEditMeal";
            this.Load += new System.EventHandler(this.FormUserEditMeal_Load);
            this.Click += new System.EventHandler(this.FormUserEditMeal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.grbFoods.ResumeLayout(false);
            this.grbFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMeal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbPorsion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvMeals;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox grbFoods;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pbFood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMealName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCompleteMeal;
        private System.Windows.Forms.ListBox lbFoods;
        private System.Windows.Forms.Button btnCreateMeal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
    }
}