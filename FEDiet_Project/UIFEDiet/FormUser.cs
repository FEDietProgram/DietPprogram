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
    public partial class FormUser : Form
    {
        UserServices userServices;
        UserDetailServices userDetailServices;
        WaterServices waterServices;
        AdminServices adminServices;
        MealServices mealServices;
        ActivityServices activityServices;
        public FormUser()
        {
            InitializeComponent();
        }

        User _user;
        public FormUser(User user)
        {
            InitializeComponent();
            userServices = new UserServices();
            userDetailServices = new UserDetailServices();
            waterServices = new WaterServices();
            adminServices = new AdminServices();    
            mealServices = new MealServices();
            activityServices = new ActivityServices();
            _user = user;
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            try
            {
                lblUserName.Text = "Welcome " + _user.FirstName;
                lblUserWeight.Text = "Your weight is " + _user.UserDetail.Weight.ToString();
                lblUserGoal.Text = "Your goal is " + _user.Goal.Name;
         

                lblGrass.Text = userServices.UserFatRate(dtDay.Value, _user).ToString();
                lblCarb.Text = userServices.UserCarbRate(dtDay.Value, _user).ToString();
                lblWater.Text = userServices.UserWaterRate(dtDay.Value, _user).ToString();
                lblProtein.Text = userServices.UserProteinRate(dtDay.Value, _user).ToString();
                pBSuccessRate.Value = Convert.ToInt32(adminServices.GetSuccessRate(_user.UserID));
                lblDUserConsCal.Text = mealServices.DailyCalori(_user, dtDay.Value).ToString();
                lblDuserBurnCal.Text = activityServices.BurnedCalory(_user, dtDay.Value).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            try
            {
                Water water = new Water();
                int cup = (int)numWater.Value;
                waterServices.WaterAdd(_user, water, cup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            FormUserEditMeal frmMeal=new FormUserEditMeal(_user);
            frmMeal.ShowDialog();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FormUserEditActivity frmActivity = new FormUserEditActivity(_user);
          
            frmActivity.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAboutUs frmAbout = new FormAboutUs();
            frmAbout.ShowDialog();  
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSignUp frmSignUp = new FormSignUp(_user);
            frmSignUp.ShowDialog();
        }
    }
}
