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
    public partial class FormDiabetes : Form
    {
        public FormDiabetes()
        {
            InitializeComponent();
        }


        private void lblCarbs_Click(object sender, EventArgs e)
        {
            lblLif.ForeColor = lblmg3.ForeColor= Color.Black;
            lblCarbs.ForeColor = Color.Red;   
            lblInformation.Text = "Healthy (complex) carbohydrates: White bread, pasta, rice, corn, cereal, fruit (instead of sugary foods), vegetables, whole grains, legumes (beans, chickpeas, peas, and lentils), and low-fat dairy products";

        }

        private void lblmg3_Click(object sender, EventArgs e)
        {
            lblLif.ForeColor = lblCarbs.ForeColor = Color.Black;
            lblmg3.ForeColor = Color.Red;
            lblInformation.Text = "Omega 3 fatty acids have a positive effect on maternal health and infant development when consumed appropriately and under the supervision of a doctor during pregnancy. Omega 3 is known to reduce the risk of pregnancy poisoning, premature birth, low birth weight baby delivery and postpartum depression.  ";
        }

        private void lblLif_Click(object sender, EventArgs e)
        {
            lblCarbs.ForeColor = lblmg3.ForeColor = Color.Black;
            lblLif.ForeColor = Color.Red;
            lblInformation.Text = "Foods rich in fiber: Vegetables, fruits, nuts, legumes(beans, chickpeas and peas), whole wheat flour and wheat bran products.";
        }

        private void lblOil_Click(object sender, EventArgs e)
        {
            lblFail.ForeColor = Color.Black;
            lblOil.ForeColor = Color.Red;   
            lblInformation2.Text = "Good fats: Mono and polyunsaturated fats should be preferred. Almond, walnut, olive, olive oil, etc. (it should be noted that the calorie content of oils is high).";
        }

        private void lblFail_Click(object sender, EventArgs e)
        {
            lblFail.ForeColor = Color.Red;
            lblOil.ForeColor = Color.Black;
            lblInformation2.Text = "- Saturated fats\n- Trans fats\n- Cholesterol\n- Salt";
        }

        private void lblRecommen_Click(object sender, EventArgs e)
        {
            lblRecom.Text = "-healthy diet and regular exercise \n-Regular heart, cholesterol and blood pressure control \n-Insulin and kidney function monitoring\n-Regular foot care against diabetic foot risk \n-Regular eye screening before vision defects occur";
        }
    }
}
