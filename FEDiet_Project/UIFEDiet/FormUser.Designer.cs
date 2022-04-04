namespace UIFEDiet
{
    partial class FormUser
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserWeight = new System.Windows.Forms.Label();
            this.lblDuserCal = new System.Windows.Forms.Label();
            this.lblDUserConsCal = new System.Windows.Forms.Label();
            this.lblGrass = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarb = new System.Windows.Forms.Label();
            this.btnMeal = new System.Windows.Forms.Button();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.lnklblUserReports = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblFalling = new System.Windows.Forms.Label();
            this.lwTodaysMeals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblConsumedCalory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDailyCalory = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(18, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(177, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Welcome User Name";
            // 
            // lblUserWeight
            // 
            this.lblUserWeight.AutoSize = true;
            this.lblUserWeight.Location = new System.Drawing.Point(18, 53);
            this.lblUserWeight.Name = "lblUserWeight";
            this.lblUserWeight.Size = new System.Drawing.Size(111, 17);
            this.lblUserWeight.TabIndex = 1;
            this.lblUserWeight.Text = "Your weight:";
            // 
            // lblDuserCal
            // 
            this.lblDuserCal.AutoSize = true;
            this.lblDuserCal.Location = new System.Drawing.Point(103, 178);
            this.lblDuserCal.Name = "lblDuserCal";
            this.lblDuserCal.Size = new System.Drawing.Size(78, 17);
            this.lblDuserCal.TabIndex = 5;
            this.lblDuserCal.Text = "Daily cal";
            // 
            // lblDUserConsCal
            // 
            this.lblDUserConsCal.AutoSize = true;
            this.lblDUserConsCal.Location = new System.Drawing.Point(18, 303);
            this.lblDUserConsCal.Name = "lblDUserConsCal";
            this.lblDUserConsCal.Size = new System.Drawing.Size(153, 17);
            this.lblDUserConsCal.TabIndex = 6;
            this.lblDUserConsCal.Text = "Consumed Calory:";
            // 
            // lblGrass
            // 
            this.lblGrass.AutoSize = true;
            this.lblGrass.Location = new System.Drawing.Point(343, 105);
            this.lblGrass.Name = "lblGrass";
            this.lblGrass.Size = new System.Drawing.Size(34, 17);
            this.lblGrass.TabIndex = 8;
            this.lblGrass.Text = "Fat";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(388, 105);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(68, 17);
            this.lblProtein.TabIndex = 10;
            this.lblProtein.Text = "Protein";
            // 
            // lblCarb
            // 
            this.lblCarb.AutoSize = true;
            this.lblCarb.Location = new System.Drawing.Point(276, 105);
            this.lblCarb.Name = "lblCarb";
            this.lblCarb.Size = new System.Drawing.Size(45, 17);
            this.lblCarb.TabIndex = 9;
            this.lblCarb.Text = "Carb";
            // 
            // btnMeal
            // 
            this.btnMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeal.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMeal.Location = new System.Drawing.Point(272, 206);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(172, 63);
            this.btnMeal.TabIndex = 16;
            this.btnMeal.Text = "MEAL";
            this.btnMeal.UseVisualStyleBackColor = true;
            this.btnMeal.Click += new System.EventHandler(this.btnMeal_Click);
            // 
            // dtDay
            // 
            this.dtDay.Location = new System.Drawing.Point(21, 354);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(234, 24);
            this.dtDay.TabIndex = 18;
            // 
            // lnklblUserReports
            // 
            this.lnklblUserReports.AutoSize = true;
            this.lnklblUserReports.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnklblUserReports.LinkColor = System.Drawing.Color.DarkOrange;
            this.lnklblUserReports.Location = new System.Drawing.Point(178, 620);
            this.lnklblUserReports.Name = "lnklblUserReports";
            this.lnklblUserReports.Size = new System.Drawing.Size(132, 17);
            this.lnklblUserReports.TabIndex = 21;
            this.lnklblUserReports.TabStop = true;
            this.lnklblUserReports.Text = "See my reports";
            this.lnklblUserReports.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblUserReports_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(18, 620);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 17);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About FADiet";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblFalling
            // 
            this.lblFalling.AutoSize = true;
            this.lblFalling.BackColor = System.Drawing.Color.Transparent;
            this.lblFalling.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblFalling.Location = new System.Drawing.Point(223, 10);
            this.lblFalling.Name = "lblFalling";
            this.lblFalling.Size = new System.Drawing.Size(0, 17);
            this.lblFalling.TabIndex = 28;
            this.lblFalling.LocationChanged += new System.EventHandler(this.lblFalling_LocationChanged);
            // 
            // lwTodaysMeals
            // 
            this.lwTodaysMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lwTodaysMeals.GridLines = true;
            this.lwTodaysMeals.HideSelection = false;
            this.lwTodaysMeals.Location = new System.Drawing.Point(22, 424);
            this.lwTodaysMeals.Name = "lwTodaysMeals";
            this.lwTodaysMeals.Size = new System.Drawing.Size(422, 154);
            this.lwTodaysMeals.TabIndex = 29;
            this.lwTodaysMeals.UseCompatibleStateImageBehavior = false;
            this.lwTodaysMeals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Meal";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calorie";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Meal Time";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Foood";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Portion";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            // 
            // lblConsumedCalory
            // 
            this.lblConsumedCalory.AutoSize = true;
            this.lblConsumedCalory.Location = new System.Drawing.Point(178, 303);
            this.lblConsumedCalory.Name = "lblConsumedCalory";
            this.lblConsumedCalory.Size = new System.Drawing.Size(58, 17);
            this.lblConsumedCalory.TabIndex = 30;
            this.lblConsumedCalory.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Your Daily Calory:";
            // 
            // lblDailyCalory
            // 
            this.lblDailyCalory.AutoSize = true;
            this.lblDailyCalory.Location = new System.Drawing.Point(177, 83);
            this.lblDailyCalory.Name = "lblDailyCalory";
            this.lblDailyCalory.Size = new System.Drawing.Size(58, 17);
            this.lblDailyCalory.TabIndex = 32;
            this.lblDailyCalory.Text = "label3";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(136, 53);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(58, 17);
            this.lblWeight.TabIndex = 33;
            this.lblWeight.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Meals of today:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::UIFEDiet.Properties.Resources.refresh_64px1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(376, 372);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 46);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::UIFEDiet.Properties.Resources.sign_out_100px;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(363, 595);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 67);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::UIFEDiet.Properties.Resources.settings_100px1;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(394, 9);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 61);
            this.btnSettings.TabIndex = 19;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UIFEDiet.Properties.Resources.beef_64px;
            this.pictureBox5.Location = new System.Drawing.Point(394, 125);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UIFEDiet.Properties.Resources.butter_48px;
            this.pictureBox3.Location = new System.Drawing.Point(332, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UIFEDiet.Properties.Resources.carbohydrates_40px;
            this.pictureBox2.Location = new System.Drawing.Point(272, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIFEDiet.Properties.Resources._187_1872707_light_circle_clip_art_circle_frame_design_png;
            this.pictureBox1.Location = new System.Drawing.Point(22, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblDailyCalory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConsumedCalory);
            this.Controls.Add(this.lwTodaysMeals);
            this.Controls.Add(this.lblFalling);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lnklblUserReports);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.dtDay);
            this.Controls.Add(this.btnMeal);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblCarb);
            this.Controls.Add(this.lblGrass);
            this.Controls.Add(this.lblDUserConsCal);
            this.Controls.Add(this.lblDuserCal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUserWeight);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserWeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDuserCal;
        private System.Windows.Forms.Label lblDUserConsCal;
        private System.Windows.Forms.Label lblGrass;
        private System.Windows.Forms.Label lblCarb;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnMeal;
        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lnklblUserReports;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblFalling;
        private System.Windows.Forms.ListView lwTodaysMeals;
        private System.Windows.Forms.Label lblConsumedCalory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDailyCalory;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnRefresh;
    }
}