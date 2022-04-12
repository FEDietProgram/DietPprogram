using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFEDiet
{
    public partial class FormAboutUs : Form
    {
        public FormAboutUs()
        {
            InitializeComponent();
        }

        private void FormAboutUs_Load(object sender, EventArgs e)
        {
            rtxtAboutUs.Text = "FEDiet is a special program for users older than 12 years old who want to conserve his/her daily calory consumption. In addition, by using FEDiet it is also possible to fallow the micronutrients of consumed foods. This feature support users to have diet in reasonable way. Fatma Eraslan and Esra Yazıcı who are talented software developers create FEDiet program by considering people healthy diet. The algorithm behind this programe is able to calculate daily calory of user confidentially.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FEDietProgram/DietPprogram");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/esra-y-66893ab4/");
        }
    }
}
