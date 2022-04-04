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
            if (userCal<=0)
            {
                MessageBox.Show("Günlük almanız gereken kaloriye ulaştınız.", "Hedef Kaloriye Ulaşıldı");
                lblDuserCal.ForeColor=Color.Red;
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
                ListViewItem list = new ListViewItem();
                list.Text = meal.MealName;
                list.SubItems.Add(meal.MealCalory.ToString());
                list.SubItems.Add(meal.MealTime.ToString());

                foreach (Food item in mealServices.FoodsOfMeal(meal))
                {
                    list.SubItems.Add(item.FoodName);
                    list.SubItems.Add(item.Portion);
                    list.SubItems.Add(item.Quantity.ToString());
                }

                lwTodaysMeals.Items.Add(list);
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

        private void lnklblUserReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUserReports frmReports = new FormUserReports(_user);
            frmReports.ShowDialog();    
        }

       
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 50;
            lblFalling.Visible = true;
            lblFalling.Text = "Tıklayın";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
            do
            {
                lblFalling.Top += 50;
                if (lblFalling.Top == 210)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    break;
                }

            } while (lblFalling.Top == 210 || timer1.Enabled == false);
           
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Vücut yağ oranınız = {_user.UserDetail.BodyFatRate} \nVücut kütle indeksiniz = {_user.UserDetail.BodyMassIndex}", "Kullanıcı bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
