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
    public partial class FormPregnancy : Form
    {
        public FormPregnancy()
        {
            InitializeComponent();
        }

        private void FormPregnancy_Load(object sender, EventArgs e)
        {
           lblReommen.Visible =false;
          
        }

       
        private void lblCalcium_Click(object sender, EventArgs e)
        {
            lblCalcium.ForeColor = Color.Red;
            lblFe.ForeColor = lblFruit.ForeColor= lblProtein.ForeColor = Color.Black;
            lblInformation.Text = "An additional 600 mg of calcium is recommended for pregnant women who do not receive sunlight or who take calcium below 600 mg daily. Calcium replacement in low-income pregnant women with insufficient calcium intake is beneficial to reduce the risk of gestational hypertension and osteoporosis, leg cramps.";
        }

        private void lblFe_Click(object sender, EventArgs e)
        {
            lblCalcium.ForeColor = lblFruit.ForeColor = lblProtein.ForeColor = Color.Black;
            lblFe.ForeColor= Color.Red;

            lblInformation.Text = "Not all iron-rich foods are created equal. The “heme iron” found in animal foods such as red meat and poultry is more easily absorbed by the body. If you only get iron from vegetables, your body may not be absorbing enough iron. If you think you are at risk of iron deficiency during pregnancy, consult your doctor.";
        }

        private void lblFruit_Click(object sender, EventArgs e)
        {
            lblFe.ForeColor = lblCalcium.ForeColor = lblProtein.ForeColor = Color.Black;
            lblFruit.ForeColor = Color.Red;
            lblInformation.Text = "It is recommended to eat 5 portions of fruit and vegetables per day. Fruits and vegetables; It can be consumed fresh, frozen, dried or squeezed. However, foods containing added sugar and salt should be avoided. At the same time, fruits and vegetables should be thoroughly washed before consumption.";
        }

        private void lblRecom_Click(object sender, EventArgs e)
        {
            lblReommen.Visible = true;
            lblReommen.Text = "-Regulate your eating habits against nausea \n- Take care to consume enough fluids \n - Take into account the headaches that continue after the 20th week \n - Do not neglect the bleeding in the form of blotches.";
        }

        private void lblProtein_Click(object sender, EventArgs e)
        {
            lblFe.ForeColor = lblFruit.ForeColor = lblCalcium.ForeColor = Color.Black;
            lblProtein.ForeColor = Color.Red;
            lblInformation.Text = "The amount of protein that should be taken during the day is 71 grams. A glass of milk contains 10 grams of protein. You can start your protein intake during the day by consuming eggs for breakfast every morning. By consuming lean meats, fish, dried beans, lentils, natural cheeses, nuts such as hazelnuts, peanuts, you can include these foods in the pregnancy nutrition list.";
        }
    }
}
