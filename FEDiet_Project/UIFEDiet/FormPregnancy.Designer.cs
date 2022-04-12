namespace UIFEDiet
{
    partial class FormPregnancy
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
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblFe = new System.Windows.Forms.Label();
            this.lblCalcium = new System.Windows.Forms.Label();
            this.lblReommen = new System.Windows.Forms.Label();
            this.lblRecom = new System.Windows.Forms.Label();
            this.lblFruit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(12, 266);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(68, 17);
            this.lblProtein.TabIndex = 0;
            this.lblProtein.Text = "Protein";
            this.lblProtein.Click += new System.EventHandler(this.lblProtein_Click);
            // 
            // lblFe
            // 
            this.lblFe.AutoSize = true;
            this.lblFe.Location = new System.Drawing.Point(215, 266);
            this.lblFe.Name = "lblFe";
            this.lblFe.Size = new System.Drawing.Size(27, 17);
            this.lblFe.TabIndex = 1;
            this.lblFe.Text = "Fe";
            this.lblFe.Click += new System.EventHandler(this.lblFe_Click);
            // 
            // lblCalcium
            // 
            this.lblCalcium.AutoSize = true;
            this.lblCalcium.Location = new System.Drawing.Point(113, 266);
            this.lblCalcium.Name = "lblCalcium";
            this.lblCalcium.Size = new System.Drawing.Size(72, 17);
            this.lblCalcium.TabIndex = 2;
            this.lblCalcium.Text = "Calcium";
            this.lblCalcium.Click += new System.EventHandler(this.lblCalcium_Click);
            // 
            // lblReommen
            // 
            this.lblReommen.Location = new System.Drawing.Point(36, 510);
            this.lblReommen.Name = "lblReommen";
            this.lblReommen.Size = new System.Drawing.Size(409, 142);
            this.lblReommen.TabIndex = 3;
            // 
            // lblRecom
            // 
            this.lblRecom.AutoSize = true;
            this.lblRecom.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblRecom.Location = new System.Drawing.Point(59, 473);
            this.lblRecom.Name = "lblRecom";
            this.lblRecom.Size = new System.Drawing.Size(332, 17);
            this.lblRecom.TabIndex = 5;
            this.lblRecom.Text = "Recomendations for Healthy Pregnancy";
            this.lblRecom.Click += new System.EventHandler(this.lblRecom_Click);
            // 
            // lblFruit
            // 
            this.lblFruit.AutoSize = true;
            this.lblFruit.Location = new System.Drawing.Point(276, 266);
            this.lblFruit.Name = "lblFruit";
            this.lblFruit.Size = new System.Drawing.Size(186, 17);
            this.lblFruit.TabIndex = 6;
            this.lblFruit.Text = "Fruits and Vegetables";
            this.lblFruit.Click += new System.EventHandler(this.lblFruit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana Pro Black", 9F);
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recommendations for total  weight gain during pregnancy by prepregnancy BMI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIFEDiet.Properties.Resources.pregnancytablo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblInformation
            // 
            this.lblInformation.Location = new System.Drawing.Point(15, 299);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(447, 147);
            this.lblInformation.TabIndex = 18;
            // 
            // FormPregnancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFruit);
            this.Controls.Add(this.lblRecom);
            this.Controls.Add(this.lblReommen);
            this.Controls.Add(this.lblCalcium);
            this.Controls.Add(this.lblFe);
            this.Controls.Add(this.lblProtein);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPregnancy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPregnancy";
            this.Load += new System.EventHandler(this.FormPregnancy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblFe;
        private System.Windows.Forms.Label lblCalcium;
        private System.Windows.Forms.Label lblReommen;
        private System.Windows.Forms.Label lblRecom;
        private System.Windows.Forms.Label lblFruit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInformation;
    }
}