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
            this.rbFoods = new System.Windows.Forms.RadioButton();
            this.gbFoods = new System.Windows.Forms.GroupBox();
            this.btnFoodPic = new System.Windows.Forms.Button();
            this.pbFoodPic = new System.Windows.Forms.PictureBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbFoodId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAdminExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gbFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFoods);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose an operation name:";
            // 
            // rbFoods
            // 
            this.rbFoods.AutoSize = true;
            this.rbFoods.Location = new System.Drawing.Point(16, 28);
            this.rbFoods.Name = "rbFoods";
            this.rbFoods.Size = new System.Drawing.Size(74, 21);
            this.rbFoods.TabIndex = 4;
            this.rbFoods.TabStop = true;
            this.rbFoods.Text = "Foods";
            this.rbFoods.UseVisualStyleBackColor = true;
            this.rbFoods.CheckedChanged += new System.EventHandler(this.rbFoods_CheckedChanged);
            // 
            // gbFoods
            // 
            this.gbFoods.Controls.Add(this.btnFoodPic);
            this.gbFoods.Controls.Add(this.pbFoodPic);
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
            // pbFoodPic
            // 
            this.pbFoodPic.Location = new System.Drawing.Point(281, 30);
            this.pbFoodPic.Name = "pbFoodPic";
            this.pbFoodPic.Size = new System.Drawing.Size(153, 133);
            this.pbFoodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodPic.TabIndex = 15;
            this.pbFoodPic.TabStop = false;
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
            this.nudCal.DecimalPlaces = 2;
            this.nudCal.Location = new System.Drawing.Point(113, 96);
            this.nudCal.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCal.Name = "nudCal";
            this.nudCal.Size = new System.Drawing.Size(134, 22);
            this.nudCal.TabIndex = 7;
            // 
            // nudCarbs
            // 
            this.nudCarbs.DecimalPlaces = 2;
            this.nudCarbs.Location = new System.Drawing.Point(113, 156);
            this.nudCarbs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCarbs.Name = "nudCarbs";
            this.nudCarbs.Size = new System.Drawing.Size(134, 22);
            this.nudCarbs.TabIndex = 6;
            // 
            // nudFat
            // 
            this.nudFat.DecimalPlaces = 2;
            this.nudFat.Location = new System.Drawing.Point(113, 126);
            this.nudFat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(134, 22);
            this.nudFat.TabIndex = 5;
            // 
            // nudProtein
            // 
            this.nudProtein.DecimalPlaces = 2;
            this.nudProtein.Location = new System.Drawing.Point(113, 186);
            this.nudProtein.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(134, 22);
            this.nudProtein.TabIndex = 4;
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
            this.cbFoodId.SelectedIndexChanged += new System.EventHandler(this.cbFoodId_SelectedIndexChanged);
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
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 16;
            this.lbUsers.Location = new System.Drawing.Point(6, 28);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(181, 228);
            this.lbUsers.TabIndex = 13;
            this.lbUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbUsers_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWeight);
            this.groupBox2.Controls.Add(this.lblJob);
            this.groupBox2.Controls.Add(this.lblHeight);
            this.groupBox2.Controls.Add(this.lblGender);
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
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(309, 168);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(13, 17);
            this.lblWeight.TabIndex = 26;
            this.lblWeight.Text = " ";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(309, 135);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(13, 17);
            this.lblJob.TabIndex = 24;
            this.lblJob.Text = " ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(309, 101);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(13, 17);
            this.lblHeight.TabIndex = 23;
            this.lblHeight.Text = " ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(309, 32);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 17);
            this.lblGender.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(205, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 17);
            this.label19.TabIndex = 19;
            this.label19.Text = "Weight:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(208, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "Age:";
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
            this.lblAge.Location = new System.Drawing.Point(309, 67);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 17);
            this.lblAge.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 32);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(500, 661);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.gbFoods);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdminExit);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFoods;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbFoods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.NumericUpDown nudCal;
        private System.Windows.Forms.NumericUpDown nudCarbs;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFoodId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblGender;
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