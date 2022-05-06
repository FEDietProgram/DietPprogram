namespace UIFEDiet
{
    partial class FormDiabetes
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
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblmg3 = new System.Windows.Forms.Label();
            this.lblLif = new System.Windows.Forms.Label();
            this.lblOil = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblRecommen = new System.Windows.Forms.Label();
            this.lblRecom = new System.Windows.Forms.Label();
            this.lblInformation2 = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Location = new System.Drawing.Point(12, 31);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(137, 17);
            this.lblCarbs.TabIndex = 0;
            this.lblCarbs.Text = "Carbonhydrates";
            this.lblCarbs.Click += new System.EventHandler(this.lblCarbs_Click);
            // 
            // lblmg3
            // 
            this.lblmg3.AutoSize = true;
            this.lblmg3.Location = new System.Drawing.Point(217, 31);
            this.lblmg3.Name = "lblmg3";
            this.lblmg3.Size = new System.Drawing.Size(56, 17);
            this.lblmg3.TabIndex = 1;
            this.lblmg3.Text = "OMG3";
            this.lblmg3.Click += new System.EventHandler(this.lblmg3_Click);
            // 
            // lblLif
            // 
            this.lblLif.AutoSize = true;
            this.lblLif.Location = new System.Drawing.Point(353, 31);
            this.lblLif.Name = "lblLif";
            this.lblLif.Size = new System.Drawing.Size(28, 17);
            this.lblLif.TabIndex = 3;
            this.lblLif.Text = "Lif";
            this.lblLif.Click += new System.EventHandler(this.lblLif_Click);
            // 
            // lblOil
            // 
            this.lblOil.AutoSize = true;
            this.lblOil.Location = new System.Drawing.Point(17, 249);
            this.lblOil.Name = "lblOil";
            this.lblOil.Size = new System.Drawing.Size(132, 17);
            this.lblOil.TabIndex = 5;
            this.lblOil.Text = "Unharmed Fats";
            this.lblOil.Click += new System.EventHandler(this.lblOil_Click);
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Location = new System.Drawing.Point(277, 249);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(135, 17);
            this.lblFail.TabIndex = 8;
            this.lblFail.Text = "Stay away from";
            this.lblFail.Click += new System.EventHandler(this.lblFail_Click);
            // 
            // lblRecommen
            // 
            this.lblRecommen.AutoSize = true;
            this.lblRecommen.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblRecommen.Location = new System.Drawing.Point(59, 474);
            this.lblRecommen.Name = "lblRecommen";
            this.lblRecommen.Size = new System.Drawing.Size(321, 17);
            this.lblRecommen.TabIndex = 10;
            this.lblRecommen.Text = "Suggestions for people have diabetes:";
            this.lblRecommen.Click += new System.EventHandler(this.lblRecommen_Click);
            // 
            // lblRecom
            // 
            this.lblRecom.Location = new System.Drawing.Point(53, 523);
            this.lblRecom.Name = "lblRecom";
            this.lblRecom.Size = new System.Drawing.Size(359, 90);
            this.lblRecom.TabIndex = 11;
            // 
            // lblInformation2
            // 
            this.lblInformation2.Location = new System.Drawing.Point(37, 302);
            this.lblInformation2.Name = "lblInformation2";
            this.lblInformation2.Size = new System.Drawing.Size(385, 151);
            this.lblInformation2.TabIndex = 12;
            // 
            // lblInformation
            // 
            this.lblInformation.Location = new System.Drawing.Point(40, 70);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(372, 142);
            this.lblInformation.TabIndex = 13;
            // 
            // FormDiabetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblInformation2);
            this.Controls.Add(this.lblRecom);
            this.Controls.Add(this.lblRecommen);
            this.Controls.Add(this.lblFail);
            this.Controls.Add(this.lblOil);
            this.Controls.Add(this.lblLif);
            this.Controls.Add(this.lblmg3);
            this.Controls.Add(this.lblCarbs);
            this.Font = new System.Drawing.Font("Verdana Pro Black", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDiabetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiabetes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblmg3;
        private System.Windows.Forms.Label lblLif;
        private System.Windows.Forms.Label lblOil;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblRecommen;
        private System.Windows.Forms.Label lblRecom;
        private System.Windows.Forms.Label lblInformation2;
        private System.Windows.Forms.Label lblInformation;
    }
}