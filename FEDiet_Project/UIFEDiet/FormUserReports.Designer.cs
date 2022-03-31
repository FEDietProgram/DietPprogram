namespace UIFEDiet
{
    partial class FormUserReports
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
            this.rbDayly = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBestDay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMaxWater = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMaxCarbs = new System.Windows.Forms.Label();
            this.lblMaxFat = new System.Windows.Forms.Label();
            this.lblMaxPro = new System.Windows.Forms.Label();
            this.lblFailedDay = new System.Windows.Forms.Label();
            this.lblFavMeal = new System.Windows.Forms.Label();
            this.lblMaxCalFood = new System.Windows.Forms.Label();
            this.lblFavFood = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDetailedReports = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbDayly
            // 
            this.rbDayly.AutoSize = true;
            this.rbDayly.Location = new System.Drawing.Point(12, 12);
            this.rbDayly.Name = "rbDayly";
            this.rbDayly.Size = new System.Drawing.Size(128, 21);
            this.rbDayly.TabIndex = 0;
            this.rbDayly.TabStop = true;
            this.rbDayly.Text = "Daily Report";
            this.rbDayly.UseVisualStyleBackColor = true;
            this.rbDayly.CheckedChanged += new System.EventHandler(this.rbDayly_CheckedChanged);
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(156, 13);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(146, 21);
            this.rbWeekly.TabIndex = 1;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly Report";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(320, 13);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(152, 21);
            this.rbMonthly.TabIndex = 2;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly Report";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(459, 269);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBestDay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblMaxWater);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblMaxCarbs);
            this.groupBox1.Controls.Add(this.lblMaxFat);
            this.groupBox1.Controls.Add(this.lblMaxPro);
            this.groupBox1.Controls.Add(this.lblFailedDay);
            this.groupBox1.Controls.Add(this.lblFavMeal);
            this.groupBox1.Controls.Add(this.lblMaxCalFood);
            this.groupBox1.Controls.Add(this.lblFavFood);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 313);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Statistics";
            // 
            // lblBestDay
            // 
            this.lblBestDay.AutoSize = true;
            this.lblBestDay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBestDay.Location = new System.Drawing.Point(169, 40);
            this.lblBestDay.Name = "lblBestDay";
            this.lblBestDay.Size = new System.Drawing.Size(68, 17);
            this.lblBestDay.TabIndex = 17;
            this.lblBestDay.Text = "label13";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(6, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Best day:";
            // 
            // lblMaxWater
            // 
            this.lblMaxWater.AutoSize = true;
            this.lblMaxWater.Location = new System.Drawing.Point(169, 245);
            this.lblMaxWater.Name = "lblMaxWater";
            this.lblMaxWater.Size = new System.Drawing.Size(68, 17);
            this.lblMaxWater.TabIndex = 15;
            this.lblMaxWater.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Max water rich:";
            // 
            // lblMaxCarbs
            // 
            this.lblMaxCarbs.AutoSize = true;
            this.lblMaxCarbs.Location = new System.Drawing.Point(169, 219);
            this.lblMaxCarbs.Name = "lblMaxCarbs";
            this.lblMaxCarbs.Size = new System.Drawing.Size(68, 17);
            this.lblMaxCarbs.TabIndex = 13;
            this.lblMaxCarbs.Text = "label10";
            // 
            // lblMaxFat
            // 
            this.lblMaxFat.AutoSize = true;
            this.lblMaxFat.Location = new System.Drawing.Point(169, 193);
            this.lblMaxFat.Name = "lblMaxFat";
            this.lblMaxFat.Size = new System.Drawing.Size(68, 17);
            this.lblMaxFat.TabIndex = 12;
            this.lblMaxFat.Text = "label11";
            // 
            // lblMaxPro
            // 
            this.lblMaxPro.AutoSize = true;
            this.lblMaxPro.Location = new System.Drawing.Point(169, 166);
            this.lblMaxPro.Name = "lblMaxPro";
            this.lblMaxPro.Size = new System.Drawing.Size(68, 17);
            this.lblMaxPro.TabIndex = 11;
            this.lblMaxPro.Text = "label12";
            // 
            // lblFailedDay
            // 
            this.lblFailedDay.AutoSize = true;
            this.lblFailedDay.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFailedDay.Location = new System.Drawing.Point(169, 280);
            this.lblFailedDay.Name = "lblFailedDay";
            this.lblFailedDay.Size = new System.Drawing.Size(68, 17);
            this.lblFailedDay.TabIndex = 10;
            this.lblFailedDay.Text = "label13";
            // 
            // lblFavMeal
            // 
            this.lblFavMeal.AutoSize = true;
            this.lblFavMeal.Location = new System.Drawing.Point(169, 102);
            this.lblFavMeal.Name = "lblFavMeal";
            this.lblFavMeal.Size = new System.Drawing.Size(68, 17);
            this.lblFavMeal.TabIndex = 9;
            this.lblFavMeal.Text = "label14";
            // 
            // lblMaxCalFood
            // 
            this.lblMaxCalFood.AutoSize = true;
            this.lblMaxCalFood.Location = new System.Drawing.Point(169, 140);
            this.lblMaxCalFood.Name = "lblMaxCalFood";
            this.lblMaxCalFood.Size = new System.Drawing.Size(58, 17);
            this.lblMaxCalFood.TabIndex = 8;
            this.lblMaxCalFood.Text = "label9";
            // 
            // lblFavFood
            // 
            this.lblFavFood.AutoSize = true;
            this.lblFavFood.Location = new System.Drawing.Point(169, 75);
            this.lblFavFood.Name = "lblFavFood";
            this.lblFavFood.Size = new System.Drawing.Size(58, 17);
            this.lblFavFood.TabIndex = 7;
            this.lblFavFood.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max carbs rich:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max fat rich:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max protein rich:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(6, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Failed day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Favorite meal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max calory taken:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorite food:";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::UIFEDiet.Properties.Resources.back_50px;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(409, 609);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 43);
            this.btnBack.TabIndex = 20;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIFEDiet.Properties.Resources._201_Elements_of_the_Human_Body_02_svg;
            this.pictureBox1.Location = new System.Drawing.Point(281, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnDetailedReports
            // 
            this.btnDetailedReports.BackgroundImage = global::UIFEDiet.Properties.Resources.Graph_Report_100px;
            this.btnDetailedReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetailedReports.FlatAppearance.BorderSize = 0;
            this.btnDetailedReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailedReports.Location = new System.Drawing.Point(320, 590);
            this.btnDetailedReports.Name = "btnDetailedReports";
            this.btnDetailedReports.Size = new System.Drawing.Size(86, 77);
            this.btnDetailedReports.TabIndex = 5;
            this.btnDetailedReports.UseVisualStyleBackColor = true;
            // 
            // FormUserReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDetailedReports);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.rbDayly);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserReports";
            this.Text = "FormUserReports";
            this.Load += new System.EventHandler(this.FormUserReports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDayly;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxCarbs;
        private System.Windows.Forms.Label lblMaxFat;
        private System.Windows.Forms.Label lblMaxPro;
        private System.Windows.Forms.Label lblFailedDay;
        private System.Windows.Forms.Label lblFavMeal;
        private System.Windows.Forms.Label lblMaxCalFood;
        private System.Windows.Forms.Label lblFavFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxWater;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDetailedReports;
        private System.Windows.Forms.Label lblBestDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
    }
}