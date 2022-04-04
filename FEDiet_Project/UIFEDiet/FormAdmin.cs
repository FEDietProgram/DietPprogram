using FEDiet.BLL.Services;
using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
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
            adminServices = new AdminServices();
            userDetailServices = new UserDetailServices();
            foodServices = new FoodServices();
        }
        User user;
        AdminServices adminServices;
        UserDetailServices userDetailServices;
    
        FoodServices foodServices;
        List<User> users;
        public FormAdmin(User _user)
        {
            InitializeComponent();
            adminServices = new AdminServices();
            userDetailServices = new UserDetailServices();
            foodServices = new FoodServices();
            users=new List<User> ();
            user = _user;
        }

        public void FillCbFoodId()
        {
            List<Food> foods = new List<Food>();
            foods= foodServices.GetAllFoods();
            cbFoodId.DataSource = foods;
            cbFoodId.DisplayMember = "FoodID";
            cbFoodId.ValueMember = "FoodID";
        }

        public void Clear()
        {
            txtFoodName.Text = string.Empty;
            nudCal.Value = 0;
            nudFat.Value = 0;
            nudCarbs.Value = 0;
            nudProtein.Value = 0;
            pbFoodPic.Image = null;
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FillCbFoodId();
            cbFoodId.SelectedIndex = -1;

             users = adminServices.UserList();
          
             lbUsers.DataSource = users;
             lbUsers.DisplayMember ="Name";
             lbUsers.ValueMember = "UserID";
            

        }

     

        private void rbFoods_CheckedChanged(object sender, EventArgs e)
        {
            gbFoods.Location = new Point(x: 18, y: 61);
            gbFoods.Visible = true;
        }

      
        

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
           Form1 frm=new Form1();
            this.Close();
            frm.ShowDialog();
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
                //pbFoodPic.ImageLocation = openFileDialog1.FileName;
            }

        }

        private void cbFoodId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodId.SelectedIndex > 0)
            {
                //filePic = foodServices.GetFoodPicByID((int)cbFoodId.SelectedValue);
                //pbFoodPic.ImageLocation = filePic;

                Food food = foodServices.GetFoodbyId((int)cbFoodId.SelectedValue);
                txtFoodName.Text = food.FoodName;
                nudCal.Value = (decimal)food.CaloryPerOnePortion;
                nudFat.Value = (decimal)food.FatCaloryPerGram;
                nudCarbs.Value = (decimal)food.CarbonhydratesCaloryPerGram;
                nudProtein.Value = (decimal)food.ProteinCaloryPerGram;
                pbFoodPic.ImageLocation = food.FoodPciture;
               

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbFoods.Checked)
            {
                    if (!string.IsNullOrEmpty(txtFoodName.Text) && nudCal.Value != 0 || nudCarbs.Value != 0 || nudFat.Value != 0 || nudProtein.Value != 0)
                    {
                        Food food = new Food();
                        food.FoodName = txtFoodName.Text;
                        food.CaloryPerOnePortion = (double)nudCal.Value;
                        food.FatCaloryPerGram = (double)nudFat.Value;
                        food.CarbonhydratesCaloryPerGram = (double)nudCarbs.Value;
                        food.ProteinCaloryPerGram = (double)nudProtein.Value;
                        food.FoodPciture = filepath;

                        if (adminServices.AddFood(food))
                        { MessageBox.Show("Yiyecek eklendi"); }
                    }
                    else MessageBox.Show("Gerekli bilgileri giriniz");

                }
                FillCbFoodId();
                cbFoodId.SelectedIndex = -1;
                Clear();
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
                if (rbFoods.Checked)
                {
                    int id = (int)cbFoodId.SelectedValue;
                    if (adminServices.DeleteFood(id))
                    { MessageBox.Show("Yiyecek silindi"); }
                }

                FillCbFoodId();
                cbFoodId.SelectedIndex = -1;
                Clear();

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
                if (rbFoods.Checked)
                {
                    int id = (int)cbFoodId.SelectedValue;
                    Food food = foodServices.GetFoodbyId(id);
                    food.FoodName = txtFoodName.Text;
                    food.CaloryPerOnePortion = (double)nudCal.Value;
                    food.FatCaloryPerGram = (double)nudFat.Value;
                    food.CarbonhydratesCaloryPerGram = (double)nudCarbs.Value;
                    food.ProteinCaloryPerGram = (double)nudProtein.Value;
                    food.FoodPciture = filepath;

                    if (adminServices.UpdateFood(food))
                    { MessageBox.Show("Yiyecek güncellendi"); }
                }
                FillCbFoodId();
                cbFoodId.SelectedIndex = -1;
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int UserAge(DateTime date)
        {
            return DateTime.Now.Year - date.Year;
        }
       
        private void btnReports_Click(object sender, EventArgs e)
        {
            FormAdminReports frmReports = new FormAdminReports();
            this.Close();
            frmReports.Show();
        }

        private void lbUsers_MouseClick(object sender, MouseEventArgs e)
        {
            int id = (int)lbUsers.SelectedValue;
            UserDetail userDetail = userDetailServices.GetUserDetailByID(id);
            
                lblGender.Text = user.UserDetail.Gender;

                int age = UserAge(userDetail.Birthdate);
                lblAge.Text = age.ToString();
                lblHeight.Text = userDetail.Height.ToString();
                lblJob.Text = userDetail.Job;
                lblWeight.Text = userDetail.Weight.ToString();
           
            
        }
    }
}
