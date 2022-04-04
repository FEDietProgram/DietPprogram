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
            //lbBetter.DataSource = userServices.BetterFoodList(user);
            //lbBetter.DisplayMember = "FoodName";
            //lbBad.DataSource=userServices.BadFoodList(user);
            //lbBad.DisplayMember = "FoodName";

            lblBMI.Text= user.UserDetail.BodyMassIndex.ToString();
            lblFatrate.Text=user.UserDetail.BodyFatRate.ToString(); 
        }
    }
}
