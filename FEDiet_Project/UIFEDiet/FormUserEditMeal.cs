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
    public partial class FormUserEditMeal : Form
    {
        public FormUserEditMeal()
        {
            InitializeComponent();
            mealServices = new MealServices();
            foodServices = new FoodServices();
            foodList = new List<Food>();
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
            foodList = new List<Food>();

        }

        public void FillCb()
        {
            cbMeal.Items.Add(MealName.Dinner);
            cbMeal.Items.Add(MealName.Lunch);
            cbMeal.Items.Add(MealName.Breakfast);
            cbMeal.Items.Add(MealName.Snack);

            cbMealName.Items.Add(MealName.Dinner);
            cbMealName.Items.Add(MealName.Lunch);
            cbMealName.Items.Add(MealName.Breakfast);
            cbMealName.Items.Add(MealName.Snack);

            cbPorsion.Items.Add(Portion.Quarter);
            cbPorsion.Items.Add(Portion.Half);
            cbPorsion.Items.Add(Portion.Single);
        }

        private void FormUserEditMeal_Load(object sender, EventArgs e)
        {

            FillCb();

            try
            { 
                cbFood.DataSource = foodServices.GetAllFoods();
                cbFood.DisplayMember = "FoodName";
                cbFood.ValueMember = "FoodID";
                             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FillListView();  
        }

        public void FillListView()
        {
            mealServices = new MealServices();
            lvMeals.Items.Clear();
            List<Meal> mealList = new List<Meal>();
            mealList = mealServices.GetMealsByDate(dtpDate.Value, user);

            foreach (Meal meal in mealList)
            {
              
                foreach (Food food in mealServices.FoodsOfMeal(meal))
                {
                    ListViewItem list = new ListViewItem();

                    list.Text = meal.MealName;
                    list.Tag = food.FoodID;
                    list.SubItems.Add(food.FoodName);
                    list.SubItems.Add(food.Portion.ToString());
                    list.SubItems.Add((food.CaloryPerOnePortion * food.Quantity).ToString());
                    lvMeals.Items.Add(list);
                }
              
            }
        }

        public void Clear()
        {
            cbMeal.SelectedIndex = cbFood.SelectedIndex = cbPorsion.SelectedIndex = -1;
            nudQty.Value = 0;
            pbFood.Image = null;
            lbFoods.Items.Clear();

        }

        Meal meal;
        List<Food> foodList;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (meal != null)
                {
                    if (cbFood.SelectedIndex != -1)
                    {
                        Food food = (Food)cbFood.SelectedItem;
                        food.Portion = cbPorsion.Text;
                        food.Quantity = (double)nudQty.Value;
                        foodServices.UpdateFoodForUser(food);
                        foodList = AddFoodsToList(food);//***
                    }
                    else
                    {
                        MessageBox.Show("Please choose a food");
                    }

                    lbFoods.Items.Clear();
                    foreach (var item in foodList)
                    {
                        lbFoods.Items.Add(item.FoodName);
                    }
                }
                else MessageBox.Show("Öğün oluşturduktan sonra yemek ekleyiniz");
                
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Food> AddFoodsToList(Food food)
        {
            foodList.Add(food);
            return foodList;
        }

        private void btnCreateMeal_Click(object sender, EventArgs e)
        {
            if (cbMeal.SelectedIndex != -1)
            {
                string mealName = cbMeal.SelectedItem.ToString();
                meal = new Meal();
                meal.MealName = mealName;
                meal.MealTime = DateTime.Now;

                if (mealServices.AddUserMeal(user, meal))
                { MessageBox.Show("öğün oluştu"); }
            }
            else
            {
                MessageBox.Show("Öğün seçiniz.");
            }

        }
        private void btnCompleteMeal_Click(object sender, EventArgs e)
        {


            if (foodList.Count>0)
            {
                if (mealServices.CreateMeal(meal, foodList))
                { MessageBox.Show("yemek eklendi"); }

                FillListView();
   
            }
            else
            {
                MessageBox.Show("Lütfen bir yiyecek seçiniz");
            }
            Clear();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //foodServices = new FoodServices();
                //int foodid = (int)lvMeals.SelectedItems[0].Tag; // food
                //int updatedfoodid = (int)cbFood.SelectedValue;

                //Food food = foodServices.GetFoodbyId(foodid);
                //food.Portion = cbPorsion.Text;
                //food.Quantity = (double)nudQty.Value;
                //int mealid =mealServices.MealIdByName(cbMeal.Text, user);
                //Meal meal = mealServices.GetMealByID(mealid);
                int id = (int)lvMeals.SelectedItems[0].Tag;
                Food food = foodServices.GetFoodbyId(id);
                int mealid = mealServices.MealIdByName(cbMeal.Text, user);
                Meal meal = mealServices.GetMealByID(mealid);

                if (foodServices.RemoveFoodFromUser(user, id))
                {

                    bool deleted = false;
                    if (foodServices.FoodsOfMeal(meal, meal.MealTime, user).Count == 0)
                    {
                        deleted = true;

                    }
                    if (deleted == true)
                    {
                        Food _food = (Food)cbFood.SelectedItem;
                        _food.Portion = cbPorsion.Text;
                        _food.Quantity = (double)nudQty.Value;
                        if (foodServices.UpdateFoodForUser(_food))
                        {
                            foodList = AddFoodsToList(_food);
                            if (mealServices.CreateMeal(meal, foodList))
                            {
                                MessageBox.Show("yemek güncellendi");
                                FillListView();
                            }
                        }                       
                    }
                }

                //if (foodServices.UpdateFoodOfUser(user,id,food))
                //{
                //    MessageBox.Show("yemek güncelelndi");
                //}
                //else MessageBox.Show("yemek güncellenemedi");
                //FillListView();

                //if(cbMeal.Text!=meal.MealName)
                //{                   
                //    if(mealServices.UpdateMealOfUser(user, meal))
                //    {
                //        MessageBox.Show("yemek güncellendi");
                //    }
                //}
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
                int id = (int)lvMeals.SelectedItems[0].Tag;
                Food food = foodServices.GetFoodbyId(id);
                int mealid = mealServices.MealIdByName(cbMeal.Text, user);
                Meal meal = mealServices.GetMealByID(mealid);

                  if (foodServices.RemoveFoodFromUser(user, id))
                  {                   
                        MessageBox.Show("yemek silindi");
                          FillListView();

                         if (foodServices.FoodsOfMeal(meal, meal.MealTime, user).Count == 0)
                         {
                            if (mealServices.RemoveMealFromUser(user, meal))
                            {
                                MessageBox.Show("Meal has been deleteted since no more food in it");
                            }

                             return;
                        
                         }
                  
                        
                  }
                  else MessageBox.Show("yemek silinemedi");
                Clear();
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
                //if (cbMealName.SelectedIndex > 0 && user.Meals.Contains(cbMealName.SelectedItem))
                //{
                lvMeals.Items.Clear();
                List<Meal> mealList; //= new List<Meal>();
                mealList = mealServices.GetMealsByDate(dtpDate.Value, user, cbMealName.Text);

                foreach (Meal meal in mealList)
                {
                    meal.MealName = cbMealName.Text;
                    foreach (Food food in mealServices.FoodsOfMeal(meal))
                    {
                        ListViewItem list = new ListViewItem();
                        list.Text = meal.MealName;
                        list.Tag = food.FoodID;
                        list.SubItems.Add(food.FoodName);
                        list.SubItems.Add(food.Portion.ToString());
                        list.SubItems.Add((food.CaloryPerOnePortion * food.Quantity).ToString());
                        lvMeals.Items.Add(list);
                    }

                }
                //  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFood.SelectedIndex >0)
            {
                int id = (int)cbFood.SelectedValue;
                Food food = foodServices.GetFoodbyId(id);
                pbFood.ImageLocation = food.FoodPciture;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormUser frm=new FormUser(user);
            this.Close();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillListView();
        }

        private void lvMeals_MouseClick(object sender, MouseEventArgs e)
        {
            if(lvMeals.SelectedItems[0].Tag!=null)
            {
                int id = (int)lvMeals.SelectedItems[0].Tag;
                Food food = foodServices.GetFoodbyId(id);
                cbFood.Text = food.FoodName;
                nudQty.Value = (decimal)food.Quantity;
                cbPorsion.Text = food.Portion;
                pbFood.ImageLocation = food.FoodPciture;
                cbMeal.Text = lvMeals.SelectedItems[0].Text;
            }
           
        }

        private void FormUserEditMeal_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
