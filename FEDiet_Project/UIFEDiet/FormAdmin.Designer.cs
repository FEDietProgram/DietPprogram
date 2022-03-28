namespace UIFEDiet
{
    partial class FormAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fbMeals = new System.Windows.Forms.RadioButton();
            this.rbGoals = new System.Windows.Forms.RadioButton();
            this.rbFoods = new System.Windows.Forms.RadioButton();
            this.rbActivities = new System.Windows.Forms.RadioButton();
            this.gbFoods = new System.Windows.Forms.GroupBox();
            this.pbFoodPic = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.nudCal = new System.Windows.Forms.NumericUpDown();
            this.nudCarbs = new System.Windows.Forms.NumericUpDown();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.nudWater = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFoodId = new System.Windows.Forms.ComboBox();
            this.gbActivities = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.nudBurnedCal = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbActId = new System.Windows.Forms.ComboBox();
            this.gbMeals = new System.Windows.Forms.GroupBox();
            this.cbMealId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbGoals = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbGoalId = new System.Windows.Forms.ComboBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAdminExit = new System.Windows.Forms.Button();
            this.btnFoodPic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gbFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).BeginInit();
            this.gbActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurnedCal)).BeginInit();
            this.gbMeals.SuspendLayout();
            this.gbGoals.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fbMeals);
            this.groupBox1.Controls.Add(this.rbGoals);
            this.groupBox1.Controls.Add(this.rbFoods);
            this.groupBox1.Controls.Add(this.rbActivities);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose an operation name:";
            // 
            // fbMeals
            // 
            this.fbMeals.AutoSize = true;
            this.fbMeals.Location = new System.Drawing.Point(6, 27);
            this.fbMeals.Name = "fbMeals";
            this.fbMeals.Size = new System.Drawing.Size(74, 21);
            this.fbMeals.TabIndex = 3;
            this.fbMeals.TabStop = true;
            this.fbMeals.Text = "Meals";
            this.fbMeals.UseVisualStyleBackColor = true;
            this.fbMeals.CheckedChanged += new System.EventHandler(this.fbMeals_CheckedChanged);
            // 
            // rbGoals
            // 
            this.rbGoals.AutoSize = true;
            this.rbGoals.Location = new System.Drawing.Point(368, 27);
            this.rbGoals.Name = "rbGoals";
            this.rbGoals.Size = new System.Drawing.Size(72, 21);
            this.rbGoals.TabIndex = 6;
            this.rbGoals.TabStop = true;
            this.rbGoals.Text = "Goals";
            this.rbGoals.UseVisualStyleBackColor = true;
            this.rbGoals.CheckedChanged += new System.EventHandler(this.rbGoals_CheckedChanged);
            // 
            // rbFoods
            // 
            this.rbFoods.AutoSize = true;
            this.rbFoods.Location = new System.Drawing.Point(119, 27);
            this.rbFoods.Name = "rbFoods";
            this.rbFoods.Size = new System.Drawing.Size(74, 21);
            this.rbFoods.TabIndex = 4;
            this.rbFoods.TabStop = true;
            this.rbFoods.Text = "Foods";
            this.rbFoods.UseVisualStyleBackColor = true;
            this.rbFoods.CheckedChanged += new System.EventHandler(this.rbFoods_CheckedChanged);
            // 
            // rbActivities
            // 
            this.rbActivities.AutoSize = true;
            this.rbActivities.Location = new System.Drawing.Point(232, 27);
            this.rbActivities.Name = "rbActivities";
            this.rbActivities.Size = new System.Drawing.Size(103, 21);
            this.rbActivities.TabIndex = 5;
            this.rbActivities.TabStop = true;
            this.rbActivities.Text = "Activities";
            this.rbActivities.UseVisualStyleBackColor = true;
            this.rbActivities.CheckedChanged += new System.EventHandler(this.rbActivities_CheckedChanged);
            // 
            // gbFoods
            // 
            this.gbFoods.Controls.Add(this.btnFoodPic);
            this.gbFoods.Controls.Add(this.pbFoodPic);
            this.gbFoods.Controls.Add(this.label9);
            this.gbFoods.Controls.Add(this.label8);
            this.gbFoods.Controls.Add(this.label7);
            this.gbFoods.Controls.Add(this.label6);
            this.gbFoods.Controls.Add(this.label5);
            this.gbFoods.Controls.Add(this.label4);
            this.gbFoods.Controls.Add(this.txtFoodName);
            this.gbFoods.Controls.Add(this.nudCal);
            this.gbFoods.Controls.Add(this.nudCarbs);
            this.gbFoods.Controls.Add(this.nudFat);
            this.gbFoods.Controls.Add(this.nudProtein);
            this.gbFoods.Controls.Add(this.nudWater);
            this.gbFoods.Controls.Add(this.label3);
            this.gbFoods.Controls.Add(this.cbFoodId);
            this.gbFoods.Font = new System.Drawing.Font("Verdana Pro Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbFoods.Location = new System.Drawing.Point(18, 61);
            this.gbFoods.Name = "gbFoods";
            this.gbFoods.Size = new System.Drawing.Size(453, 237);
            this.gbFoods.TabIndex = 11;
            this.gbFoods.TabStop = false;
            this.gbFoods.Text = "Edit Foods";
            this.gbFoods.Visible = false;
            // 
            // pbFoodPic
            // 
            this.pbFoodPic.Location = new System.Drawing.Point(281, 30);
            this.pbFoodPic.Name = "pbFoodPic";
            this.pbFoodPic.Size = new System.Drawing.Size(153, 133);
            this.pbFoodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodPic.TabIndex = 15;
            this.pbFoodPic.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "Water%:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Protein%:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Carbs%:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fat%:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(75, 63);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(172, 22);
            this.txtFoodName.TabIndex = 8;
            // 
            // nudCal
            // 
            this.nudCal.Location = new System.Drawing.Point(113, 96);
            this.nudCal.Name = "nudCal";
            this.nudCal.Size = new System.Drawing.Size(134, 22);
            this.nudCal.TabIndex = 7;
            // 
            // nudCarbs
            // 
            this.nudCarbs.Location = new System.Drawing.Point(113, 156);
            this.nudCarbs.Name = "nudCarbs";
            this.nudCarbs.Size = new System.Drawing.Size(134, 22);
            this.nudCarbs.TabIndex = 6;
            // 
            // nudFat
            // 
            this.nudFat.Location = new System.Drawing.Point(113, 126);
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(134, 22);
            this.nudFat.TabIndex = 5;
            // 
            // nudProtein
            // 
            this.nudProtein.Location = new System.Drawing.Point(113, 186);
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(134, 22);
            this.nudProtein.TabIndex = 4;
            // 
            // nudWater
            // 
            this.nudWater.Location = new System.Drawing.Point(113, 214);
            this.nudWater.Name = "nudWater";
            this.nudWater.Size = new System.Drawing.Size(134, 22);
            this.nudWater.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // cbFoodId
            // 
            this.cbFoodId.FormattingEnabled = true;
            this.cbFoodId.Location = new System.Drawing.Point(75, 30);
            this.cbFoodId.Name = "cbFoodId";
            this.cbFoodId.Size = new System.Drawing.Size(172, 22);
            this.cbFoodId.TabIndex = 0;
            // 
            // gbActivities
            // 
            this.gbActivities.Controls.Add(this.label12);
            this.gbActivities.Controls.Add(this.txtActivityName);
            this.gbActivities.Controls.Add(this.nudBurnedCal);
            this.gbActivities.Controls.Add(this.label11);
            this.gbActivities.Controls.Add(this.label10);
            this.gbActivities.Controls.Add(this.cbActId);
            this.gbActivities.Location = new System.Drawing.Point(485, 260);
            this.gbActivities.Name = "gbActivities";
            this.gbActivities.Size = new System.Drawing.Size(418, 143);
            this.gbActivities.TabIndex = 12;
            this.gbActivities.TabStop = false;
            this.gbActivities.Text = "Edit Activities";
            this.gbActivities.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Name:";
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(118, 66);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(159, 24);
            this.txtActivityName.TabIndex = 5;
            // 
            // nudBurnedCal
            // 
            this.nudBurnedCal.Location = new System.Drawing.Point(118, 104);
            this.nudBurnedCal.Name = "nudBurnedCal";
            this.nudBurnedCal.Size = new System.Drawing.Size(159, 24);
            this.nudBurnedCal.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Burned Cal :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID:";
            // 
            // cbActId
            // 
            this.cbActId.FormattingEnabled = true;
            this.cbActId.Location = new System.Drawing.Point(118, 26);
            this.cbActId.Name = "cbActId";
            this.cbActId.Size = new System.Drawing.Size(159, 24);
            this.cbActId.TabIndex = 0;
            // 
            // gbMeals
            // 
            this.gbMeals.Controls.Add(this.cbMealId);
            this.gbMeals.Controls.Add(this.label2);
            this.gbMeals.Controls.Add(this.label1);
            this.gbMeals.Controls.Add(this.txtMealName);
            this.gbMeals.Location = new System.Drawing.Point(485, 127);
            this.gbMeals.Name = "gbMeals";
            this.gbMeals.Size = new System.Drawing.Size(418, 112);
            this.gbMeals.TabIndex = 7;
            this.gbMeals.TabStop = false;
            this.gbMeals.Text = "Edit Meals";
            this.gbMeals.Visible = false;
            // 
            // cbMealId
            // 
            this.cbMealId.FormattingEnabled = true;
            this.cbMealId.Location = new System.Drawing.Point(75, 29);
            this.cbMealId.Name = "cbMealId";
            this.cbMealId.Size = new System.Drawing.Size(172, 24);
            this.cbMealId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txtMealName
            // 
            this.txtMealName.Location = new System.Drawing.Point(75, 68);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(172, 24);
            this.txtMealName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(183, 309);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(122, 39);
            this.btnArrange.TabIndex = 9;
            this.btnArrange.Text = "Arrange";
            this.btnArrange.UseVisualStyleBackColor = true;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbGoals
            // 
            this.gbGoals.Controls.Add(this.label13);
            this.gbGoals.Controls.Add(this.txtGoalName);
            this.gbGoals.Controls.Add(this.label14);
            this.gbGoals.Controls.Add(this.cbGoalId);
            this.gbGoals.Location = new System.Drawing.Point(485, 12);
            this.gbGoals.Name = "gbGoals";
            this.gbGoals.Size = new System.Drawing.Size(418, 101);
            this.gbGoals.TabIndex = 13;
            this.gbGoals.TabStop = false;
            this.gbGoals.Text = "Edit Goals";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Name:";
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(118, 62);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(159, 24);
            this.txtGoalName.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "ID:";
            // 
            // cbGoalId
            // 
            this.cbGoalId.FormattingEnabled = true;
            this.cbGoalId.Location = new System.Drawing.Point(118, 22);
            this.cbGoalId.Name = "cbGoalId";
            this.cbGoalId.Size = new System.Drawing.Size(159, 24);
            this.cbGoalId.TabIndex = 7;
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 16;
            this.lbUsers.Location = new System.Drawing.Point(6, 28);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(181, 228);
            this.lbUsers.TabIndex = 13;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSuccess);
            this.groupBox2.Controls.Add(this.lblWeight);
            this.groupBox2.Controls.Add(this.lblGoal);
            this.groupBox2.Controls.Add(this.lblJob);
            this.groupBox2.Controls.Add(this.lblHeight);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblAge);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbUsers);
            this.groupBox2.Location = new System.Drawing.Point(18, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 263);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(309, 230);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(68, 17);
            this.lblSuccess.TabIndex = 27;
            this.lblSuccess.Text = "label22";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(309, 200);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(68, 17);
            this.lblWeight.TabIndex = 26;
            this.lblWeight.Text = "label23";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(309, 169);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(68, 17);
            this.lblGoal.TabIndex = 25;
            this.lblGoal.Text = "label24";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(309, 135);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(68, 17);
            this.lblJob.TabIndex = 24;
            this.lblJob.Text = "label25";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(309, 101);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(68, 17);
            this.lblHeight.TabIndex = 23;
            this.lblHeight.Text = "label26";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(309, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 17);
            this.label27.TabIndex = 22;
            this.label27.Text = "label27";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(309, 28);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 17);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "label28";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(208, 230);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 17);
            this.label21.TabIndex = 20;
            this.label21.Text = "Success:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(208, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 17);
            this.label19.TabIndex = 19;
            this.label19.Text = "Weight:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(208, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "Goal:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(208, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Job:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(208, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 17);
            this.label18.TabIndex = 16;
            this.label18.Text = "Height:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(208, 62);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(44, 17);
            this.lblAge.TabIndex = 15;
            this.lblAge.Text = "Age:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Gender:";
            // 
            // btnReports
            // 
            this.btnReports.BackgroundImage = global::UIFEDiet.Properties.Resources.report_file_64px;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(24, 612);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(82, 46);
            this.btnReports.TabIndex = 15;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAdminExit
            // 
            this.btnAdminExit.BackgroundImage = global::UIFEDiet.Properties.Resources.close_window_48px;
            this.btnAdminExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdminExit.FlatAppearance.BorderSize = 0;
            this.btnAdminExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminExit.Location = new System.Drawing.Point(397, 612);
            this.btnAdminExit.Name = "btnAdminExit";
            this.btnAdminExit.Size = new System.Drawing.Size(75, 46);
            this.btnAdminExit.TabIndex = 0;
            this.btnAdminExit.UseVisualStyleBackColor = true;
            this.btnAdminExit.Click += new System.EventHandler(this.btnAdminExit_Click);
            // 
            // btnFoodPic
            // 
            this.btnFoodPic.Location = new System.Drawing.Point(281, 179);
            this.btnFoodPic.Name = "btnFoodPic";
            this.btnFoodPic.Size = new System.Drawing.Size(153, 32);
            this.btnFoodPic.TabIndex = 16;
            this.btnFoodPic.Text = "Add Food Picture";
            this.btnFoodPic.UseVisualStyleBackColor = true;
            this.btnFoodPic.Click += new System.EventHandler(this.btnFoodPic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(923, 661);
            this.Controls.Add(this.gbGoals);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.gbFoods);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbActivities);
            this.Controls.Add(this.gbMeals);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdminExit);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFoods.ResumeLayout(false);
            this.gbFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).EndInit();
            this.gbActivities.ResumeLayout(false);
            this.gbActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurnedCal)).EndInit();
            this.gbMeals.ResumeLayout(false);
            this.gbMeals.PerformLayout();
            this.gbGoals.ResumeLayout(false);
            this.gbGoals.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fbMeals;
        private System.Windows.Forms.RadioButton rbGoals;
        private System.Windows.Forms.RadioButton rbFoods;
        private System.Windows.Forms.RadioButton rbActivities;
        private System.Windows.Forms.GroupBox gbMeals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbMealId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMealName;
        private System.Windows.Forms.GroupBox gbFoods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.NumericUpDown nudCal;
        private System.Windows.Forms.NumericUpDown nudCarbs;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.NumericUpDown nudWater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFoodId;
        private System.Windows.Forms.GroupBox gbActivities;
        private System.Windows.Forms.GroupBox gbGoals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.NumericUpDown nudBurnedCal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbActId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbGoalId;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.PictureBox pbFoodPic;
        private System.Windows.Forms.Button btnFoodPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}