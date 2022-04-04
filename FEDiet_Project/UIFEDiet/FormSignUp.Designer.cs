namespace UIFEDiet
{
    partial class FormSignUp
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
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.dtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.numBoy = new System.Windows.Forms.NumericUpDown();
            this.numKilo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblPasswStrength = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.nudNeck = new System.Windows.Forms.NumericUpDown();
            this.nudWaist = new System.Windows.Forms.NumericUpDown();
            this.nudHip = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.btnBackClick = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(338, 133);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(65, 21);
            this.rbErkek.TabIndex = 38;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Male";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // dtDogumTarih
            // 
            this.dtDogumTarih.Location = new System.Drawing.Point(131, 166);
            this.dtDogumTarih.Name = "dtDogumTarih";
            this.dtDogumTarih.Size = new System.Drawing.Size(297, 24);
            this.dtDogumTarih.TabIndex = 37;
            // 
            // numBoy
            // 
            this.numBoy.Location = new System.Drawing.Point(127, 283);
            this.numBoy.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numBoy.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBoy.Name = "numBoy";
            this.numBoy.Size = new System.Drawing.Size(70, 24);
            this.numBoy.TabIndex = 36;
            this.numBoy.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numKilo
            // 
            this.numKilo.Location = new System.Drawing.Point(354, 283);
            this.numKilo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKilo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKilo.Name = "numKilo";
            this.numKilo.Size = new System.Drawing.Size(70, 24);
            this.numKilo.TabIndex = 35;
            this.numKilo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Weight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Job:";
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(170, 133);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(85, 21);
            this.rbKadin.TabIndex = 32;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Female";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Birthdate:";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(131, 212);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(296, 24);
            this.txtMeslek.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gender:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(131, 62);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(296, 24);
            this.txtSoyad.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Surname:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(131, 16);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(296, 24);
            this.txtAd.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(198, 397);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(191, 24);
            this.txtPassword.TabIndex = 44;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Repeat Password:";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(198, 446);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(191, 24);
            this.txtPassword2.TabIndex = 46;
            // 
            // lblPasswStrength
            // 
            this.lblPasswStrength.AutoSize = true;
            this.lblPasswStrength.ForeColor = System.Drawing.Color.Red;
            this.lblPasswStrength.Location = new System.Drawing.Point(406, 400);
            this.lblPasswStrength.Name = "lblPasswStrength";
            this.lblPasswStrength.Size = new System.Drawing.Size(52, 17);
            this.lblPasswStrength.TabIndex = 47;
            this.lblPasswStrength.Text = "weak";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "E-Mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 24);
            this.txtEmail.TabIndex = 49;
            // 
            // nudNeck
            // 
            this.nudNeck.Location = new System.Drawing.Point(88, 331);
            this.nudNeck.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNeck.Name = "nudNeck";
            this.nudNeck.Size = new System.Drawing.Size(60, 24);
            this.nudNeck.TabIndex = 50;
            this.nudNeck.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudWaist
            // 
            this.nudWaist.Location = new System.Drawing.Point(234, 331);
            this.nudWaist.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudWaist.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWaist.Name = "nudWaist";
            this.nudWaist.Size = new System.Drawing.Size(60, 24);
            this.nudWaist.TabIndex = 51;
            this.nudWaist.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudHip
            // 
            this.nudHip.Location = new System.Drawing.Point(363, 331);
            this.nudHip.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudHip.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHip.Name = "nudHip";
            this.nudHip.Size = new System.Drawing.Size(60, 24);
            this.nudHip.TabIndex = 52;
            this.nudHip.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Neck:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(304, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Hip:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(163, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 55;
            this.label15.Text = "Waist:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "In cm:";
            // 
            // chkTerms
            // 
            this.chkTerms.AutoSize = true;
            this.chkTerms.Location = new System.Drawing.Point(44, 496);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(250, 21);
            this.chkTerms.TabIndex = 57;
            this.chkTerms.Text = "I agree to the terms of use";
            this.chkTerms.UseVisualStyleBackColor = true;
            // 
            // btnBackClick
            // 
            this.btnBackClick.BackgroundImage = global::UIFEDiet.Properties.Resources.back_100px2;
            this.btnBackClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackClick.FlatAppearance.BorderSize = 0;
            this.btnBackClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackClick.Location = new System.Drawing.Point(373, 585);
            this.btnBackClick.Name = "btnBackClick";
            this.btnBackClick.Size = new System.Drawing.Size(99, 64);
            this.btnBackClick.TabIndex = 58;
            this.btnBackClick.UseVisualStyleBackColor = true;
            this.btnBackClick.Click += new System.EventHandler(this.btnBackClick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIFEDiet.Properties.Resources.Body_Positive_Female_100px1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 576);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Transparent;
            this.btnKayit.BackgroundImage = global::UIFEDiet.Properties.Resources.signup;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKayit.FlatAppearance.BorderSize = 0;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Location = new System.Drawing.Point(142, 523);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(152, 83);
            this.btnKayit.TabIndex = 25;
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnBackClick);
            this.Controls.Add(this.chkTerms);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudHip);
            this.Controls.Add(this.nudWaist);
            this.Controls.Add(this.nudNeck);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPasswStrength);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.dtDogumTarih);
            this.Controls.Add(this.numBoy);
            this.Controls.Add(this.numKilo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbKadin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMeslek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignUp";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.DateTimePicker dtDogumTarih;
        private System.Windows.Forms.NumericUpDown numBoy;
        private System.Windows.Forms.NumericUpDown numKilo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblPasswStrength;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown nudNeck;
        private System.Windows.Forms.NumericUpDown nudWaist;
        private System.Windows.Forms.NumericUpDown nudHip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Button btnBackClick;
    }
}