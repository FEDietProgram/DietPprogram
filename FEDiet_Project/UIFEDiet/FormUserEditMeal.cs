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
    public partial class FormUserEditMeal : Form
    {
        public FormUserEditMeal()
        {
            InitializeComponent();
        }
        User user;
        MealServices mealServices;
        FoodServices foodServices;
        public FormUserEditMeal(User _user)
        {
            InitializeComponent();
            mealServices = new MealServices();  
            foodServices = new FoodServices();
            user = _user;              
        }

        private void FormUserEditMeal_Load(object sender, EventArgs e)
        {
            try
            {
              var list=  mealServices.GetUserMealList(user);
                cbFood.DataSource = foodServices.GetAllFoods();
                cbFood.DisplayMember = "FoodName";
                cbFood.ValueMember = "FoodID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cbMealName.DataSource = mealServices.GetUserMealList(user);
            cbMealName.DisplayMember = "MealName";
            cbMealName.ValueMember = "MealID";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)lvMeals.SelectedItems[0].Tag;
                Meal meal = mealServices.GetMealByID(id);
                if( mealServices.AddMealbyUser(user, meal)>0)
                { MessageBox.Show("Yemek eklendi"); }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)lvMeals.SelectedItems[0].Tag;
                Meal meal = mealServices.GetMealByID(id);
                List<Meal> Meallist = (List<Meal>)mealServices.GetUserMealList(user);
                foreach (var item in Meallist)
                {
                    if (item.MealID == meal.MealID)
                    {
                        meal = item;
                    }
                }

                foodServices.FoodsOfMeal(meal, dtpDate.Value, user);

                mealServices.UpdateMealbyUser(user, meal);

                WriteFoodsToListview(meal);

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
                int id = (int)lvMeals.SelectedItems[0].Tag;
                Meal meal = mealServices.GetMealByID(id);

                if (mealServices.DeleteMealbyUser(user,meal)>0)
                { MessageBox.Show("Öğün eklendi"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMealName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMealName.SelectedIndex > 0 && user.Meals.Contains(cbMealName.SelectedItem))
                {
                    mealServices.GetFoodsByMealName(user, cbMealName.SelectedText, dtpDate.Value);

                    Meal meal = mealServices.GetMealByID((int)cbMealName.SelectedValue);

                    WriteFoodsToListview(meal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }


        public void WriteFoodsToListview(Meal meal)
        {
            lvMeals.Items.Clear();
            foreach (var item in meal.Foods)
            {
                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = item.FoodName;
                viewItem.SubItems.Add(meal.FoodPortion.ToString());
                viewItem.SubItems.Add(meal.MealName);
                viewItem.SubItems.Add(item.Calorie.ToString());
                viewItem.Tag = meal;
                lvMeals.Items.Add(viewItem);
            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbFood.Image = null;
            byte[] foodBytes = foodServices.FoodPicture((int)cbFood.SelectedValue);

            MemoryStream ms = new MemoryStream(foodBytes);
            pbFood.Image=Image.FromStream(ms);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormUser frm=new FormUser();
            this.Close();
            frm.ShowDialog();
        }
    }
}
