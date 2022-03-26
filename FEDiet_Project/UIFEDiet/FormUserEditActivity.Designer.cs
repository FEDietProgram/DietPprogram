namespace UIFEDiet
{
    partial class FormUserEditActivity
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
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbActivities = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.grbActivities.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbActivity
            // 
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Location = new System.Drawing.Point(168, 84);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(200, 24);
            this.cbActivity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activity Name:";
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(168, 130);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(200, 24);
            this.nudTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::UIFEDiet.Properties.Resources.add_100px;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(223, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 80);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grbActivities
            // 
            this.grbActivities.Controls.Add(this.label5);
            this.grbActivities.Controls.Add(this.dtpDate);
            this.grbActivities.Controls.Add(this.listView1);
            this.grbActivities.Controls.Add(this.button1);
            this.grbActivities.Controls.Add(this.button2);
            this.grbActivities.Location = new System.Drawing.Point(17, 307);
            this.grbActivities.Name = "grbActivities";
            this.grbActivities.Size = new System.Drawing.Size(445, 325);
            this.grbActivities.TabIndex = 18;
            this.grbActivities.TabStop = false;
            this.grbActivities.Text = "Activities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date to edit:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(196, 40);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(233, 24);
            this.dtpDate.TabIndex = 19;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 183);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Aktivity";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Calories Burned";
            this.columnHeader3.Width = 137;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::UIFEDiet.Properties.Resources.delete2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(360, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 51);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::UIFEDiet.Properties.Resources.update;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(293, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 53);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormUserEditActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.grbActivities);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbActivity);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserEditActivity";
            this.Text = "FormUserEditActivity";
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.grbActivities.ResumeLayout(false);
            this.grbActivities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbActivities;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}