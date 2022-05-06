using FEDiet.BLL.Services;
using FEDiet.Model.Entities;
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
    public partial class FormUserDietDetails : Form
    {
        UserServices userServices;
        public FormUserDietDetails()
        {
            InitializeComponent();
        }
        User user;
        public FormUserDietDetails(User _user)
        {
            InitializeComponent();
            userServices = new UserServices();
            user = _user;
        }

        private void FormUserDietDetails_Load(object sender, EventArgs e)
        {
           
            List<string> goodIdeaList = new List<string>()
            {
                "Brocoli","Spinach","Grilled Fish","Green Tea","Leek with Olive Oil","Tarhana Soup","Milk"
            };
            lbBetter.DataSource= goodIdeaList;  

            List<string> badIdeaList = new List<string>()
            {
                "Fried Patatos","Chocolate","Cola","Pastry","Hamburger","Cake","Cips"
            };
            lbBad.DataSource = badIdeaList;

            double bmi = user.UserDetail.BodyMassIndex;
            lblBMI.Text= bmi.ToString("0.####");

            double fatRate = user.UserDetail.BodyFatRate;
            lblFatrate.Text = fatRate.ToString("0.####");
        }
    }
}
