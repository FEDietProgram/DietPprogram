using FEDiet.BLL.Services;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFEDiet
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        User user;
        AdminServices adminServices;
        UserServices userServices;
        public FormAdmin(User _user)
        {
            InitializeComponent();
            adminServices = new AdminServices();
            userServices = new UserServices();
            user = _user;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            gbFoods.Visible = gbGoals.Visible = gbActivities.Visible = gbMeals.Visible  = false;
            this.Size = new Size(500, 700);

            List<User> users = userServices.UserList();
            foreach (User user in users)
            {
                lbUsers.DataSource = user;
                lbUsers.DisplayMember = user.FirstName+" "+user.LastName;
                lbUsers.ValueMember = user.UserID.ToString();
            }

        }

        private void fbMeals_CheckedChanged(object sender, EventArgs e)
        {
            gbMeals.Location = new Point(x:18, y: 61) ;

            gbFoods.Visible = gbGoals.Visible = gbActivities.Visible = false;
            gbMeals.Visible = true;

        }

        private void rbFoods_CheckedChanged(object sender, EventArgs e)
        {
            gbFoods.Location = new Point(x: 18, y: 61);
            gbMeals.Visible = gbGoals.Visible = gbActivities.Visible = false;
            gbFoods.Visible = true;
        }

        private void rbActivities_CheckedChanged(object sender, EventArgs e)
        {
            gbActivities.Location = new Point(x: 18, y: 61);
            gbMeals.Visible = gbGoals.Visible = gbFoods.Visible = false;
            gbActivities.Visible = true;
        }

        private void rbGoals_CheckedChanged(object sender, EventArgs e)
        {
            gbGoals.Location = new Point(x: 18, y: 61);
            gbMeals.Visible = gbFoods.Visible = gbActivities.Visible = false;
            gbGoals.Visible = true;
        }

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string filepath;
        private void btnFoodPic_Click(object sender, EventArgs e)
        {            

            openFileDialog1.Title = "Choose food image";
            openFileDialog1.Filter = "image files (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbFoodPic.Image = Image.FromFile(openFileDialog1.FileName);
                filepath = openFileDialog1.FileName;
            }                 
                
        }


        byte[] picArray;
        public void SaveFoodPicture()
        {
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            picArray = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbFoods.Checked)
                {
                        Food food = new Food();
                        food.FoodName = txtFoodName.Text;
                        food.Calorie = nudCal.Value;
                        food.FatRate = nudFat.Value;
                        food.CarbRate = nudCarbs.Value;
                        food.ProteinRate = nudProtein.Value;
                        food.WaterRate = nudWater.Value;
                        food.FoodPictures = picArray;

                        if (adminServices.AddFood(food) > 0)
                        { MessageBox.Show("Yieyecek eklendi"); }
                   
                }

                if(rbActivities.Checked)
                {
                    Activity activity = new Activity();
                    activity.ActivityName = txtActivityName.Text;
                    activity.BurnedCaloriePerHour=(int)nudBurnedCal.Value;
                   if(adminServices.AddActivity(activity)>0)
                    { MessageBox.Show("Aktivite eklendi"); }
                }

                if(rbGoals.Checked)
                {
                    Goal goal = new Goal(); 
                    goal.Name=txtGoalName.Text;
                    if(adminServices.AddGoal(goal) > 0)
                    { MessageBox.Show("Hedef Eklendi"); }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbFoods.Checked)
                {
                    int id = (int)cbFoodId.SelectedValue;
                    if (adminServices.DeleteFood(id) > 0)
                    { MessageBox.Show("Yiyecek silindi"); }
                }

                if(rbActivities.Checked)
                {
                    int id=(int)cbActId.SelectedValue;
                    Activity activity= adminServices.GetActivityByID(id);
                    if(adminServices.DeleteActivity(activity)>0)
                    { MessageBox.Show("Aktivite silindi"); }
                }

                if(rbGoals.Checked)
                {
                    int id = (int)cbGoalId.SelectedValue;
                    if(adminServices.DeleteGoal(id)>0)
                    { MessageBox.Show("Aktivite silindi"); }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbFoods.Checked)
                {
                    int id = (int)cbFoodId.SelectedValue;
                    Food food = adminServices.GetFoodbyId(id);
                    food.FoodName = txtFoodName.Text;
                    food.Calorie = nudCal.Value;
                    food.FatRate = nudFat.Value;
                    food.CarbRate = nudCarbs.Value;
                    food.ProteinRate = nudProtein.Value;
                    food.WaterRate = nudWater.Value;
                    food.FoodPictures = picArray;

                    if (adminServices.UpdateFood(food) > 0)
                    { MessageBox.Show("Yiyecek güncellendi"); }
                }

                if(rbActivities.Checked)
                {
                    int id = (int)cbActId.SelectedValue;
                    Activity activity = adminServices.GetActivityByID(id);
                    activity.ActivityName = txtActivityName.Text;
                    activity.BurnedCaloriePerHour=(int)nudBurnedCal.Value;
                    if(adminServices.UpdateActivity(activity)>0)
                    { MessageBox.Show("Aktivite güncellendi"); }
                }

                if(rbGoals.Checked)
                {
                    int id = (int)cbActId.SelectedValue;
                    Goal goal= adminServices.GetGoalById(id);
                    goal.Name = txtGoalName.Text;
                    if(adminServices.UpdateGoal(id)>0)
                    {
                        MessageBox.Show("Hedef bilgisi güncellendi");
                    }
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user.UserDetail.Gender == true) lblGender.Text = "Female";
            else lblGender.Text = "Male";

            int age = userServices.UserAge(user.UserDetail.BirthDate);
            lblAge.Text=age.ToString();
            lblHeight.Text=user.UserDetail.Height.ToString();
            lblJob.Text=user.UserDetail.Job;
            lblWeight.Text=user.UserDetail.Weight.ToString();
            lblSuccess.Text = adminServices.GetSuccessRate((int)user.UserID).ToString();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormAdminReports frmReports = new FormAdminReports();
            frmReports.ShowDialog();
        }
    }
}
