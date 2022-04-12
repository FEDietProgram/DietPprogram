using FEDiet.BLL.Services;
using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
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
            groupBox1.Visible = false;
            if (_user.UserDetail.UserSituation == SpecialSituation.Diabetes.ToString())
            {
                groupBox1.Visible = true;
                groupBox1.Text = "CHO insulin dose";
                lblSpecialSit.Text = (userServices.UserCarbRate(dtDay.Value, _user) / 10).ToString();
            }
            else if (_user.UserDetail.UserSituation == SpecialSituation.Pregnant.ToString())
            {
                groupBox1.Visible = true;
                groupBox1.Text = " Ideal weight gain";
                int week = userDetailServices.CalculatePregnancyWeek(_user.UserDetail);
                MessageBox.Show(week.ToString());
                double idealpregnancyweightgain=0;
                switch (week)
                {
                    case 1: case 2: case 3: case 4: idealpregnancyweightgain = 0.5; break;
                    case 5: case 6: case 7: case 8: idealpregnancyweightgain = 1.0; break;
                    case 9: case 10: case 11: case 12: idealpregnancyweightgain = 1.5; break;
                    case 13: case 14: case 15: case 16: idealpregnancyweightgain = 3; break;
                    case 17: case 18: case 19: case 20: idealpregnancyweightgain = 4.5; break;
                    case 21: case 22: case 23: case 24: idealpregnancyweightgain = 6.5; break;
                    case 25: case 26: case 27: case 28: idealpregnancyweightgain = 9; break;
                    case 29: case 30: case 31: case 32: idealpregnancyweightgain = 11; break;
                    case 33: case 34: case 35: case 36: idealpregnancyweightgain = 13; break;
                    case 37: case 38: case 39: case 40: idealpregnancyweightgain = 15.5; break;    

                }
                lblSpecialSit.Text = $"Week {userDetailServices.CalculatePregnancyWeek(_user.UserDetail)} \n Ideal weight gain: {idealpregnancyweightgain}";
            }
            RefreshLabels();
            FillListView();

        }

        public void RefreshLabels()
        {
            lblUserName.Text = $"Welcolme {_user.Name}";
            lblWeight.Text = _user.UserDetail.Weight.ToString();
            lblDailyCalory.Text = userDetailServices.UserPerdayCalorie(_user.UserDetail).ToString();
            double userCal = ((double)userDetailServices.UserPerdayCalorie(_user.UserDetail) - mealServices.UserDailyConsumedCal(_user));
            lblDuserCal.Text = userCal.ToString();
            if (userCal <= 0)
            {
                MessageBox.Show("You are reached your daily calory", "Daily Calory Is Reached");
                lblDuserCal.ForeColor = Color.Red;
            }
            lblCarb.Text = userServices.UserCarbRate(dtDay.Value, _user).ToString();
            lblGrass.Text = userServices.UserFatRate(dtDay.Value, _user).ToString();
            lblProtein.Text = userServices.UserProteinRate(dtDay.Value, _user).ToString();
            lblConsumedCalory.Text = mealServices.UserDailyConsumedCal(_user).ToString();
        }


        public void FillListView()
        {
            lwTodaysMeals.Items.Clear();
            List<Meal> mealList = new List<Meal>();
            mealList = mealServices.GetMealsByDate(dtDay.Value, _user);

            foreach (Meal meal in mealList)
            {
                foreach (Food item in mealServices.FoodsOfMeal(meal))
                {
                    ListViewItem list = new ListViewItem();
                    list.Text = meal.MealName;
                    list.SubItems.Add(meal.MealCalory.ToString());
                    list.SubItems.Add(meal.MealTime.ToString());
                    list.SubItems.Add(item.FoodName);
                    list.SubItems.Add(item.Portion);
                    list.SubItems.Add(item.Quantity.ToString());
                    lwTodaysMeals.Items.Add(list);
                }                
            }

        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.ShowDialog();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            FormUserEditMeal frmMeal=new FormUserEditMeal(_user);
            this.Close();
            frmMeal.Show();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FormUserEditActivity frmActivity = new FormUserEditActivity(_user);
            this.Close();
            frmActivity.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAboutUs frmAbout = new FormAboutUs();
            frmAbout.ShowDialog();  
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSignUp frmSignUp = new FormSignUp(_user);
            this.Close();
            frmSignUp.Show();
        }

        private void lnklblUserReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUserReports frmReports = new FormUserReports(_user);
            this.Close();
            frmReports.Show();    
        }                           

        private void lblFalling_LocationChanged(object sender, EventArgs e)
        {
            //   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLabels();
            FillListView();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if(_user.UserDetail.UserSituation==SpecialSituation.Pregnant.ToString())
            {
                FormPregnancy frm=new FormPregnancy();
                frm.Show();
            }
            else if(_user.UserDetail.UserSituation == SpecialSituation.Diabetes.ToString())
            {
                FormDiabetes frm =new FormDiabetes();   
                frm.Show();
            }

        }
    }
}
