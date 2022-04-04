using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class FoodRepository
    {
        FEDietDbContext FEDietDbContext;
        public FoodRepository()
        {
            FEDietDbContext = new FEDietDbContext();
        }

        public bool AddFoodToUser(Food _food)
        {
            Food food = FEDietDbContext.Foods.Find(_food.FoodID);
            food.Portion = _food.Portion;
            food.Quantity = _food.Quantity;

            return FEDietDbContext.SaveChanges() > 0;
        }


     
        public List<Food> ListFoodsAcoordingToMeal(DateTime mealtime, Meal meal, User user)
        {
            List<Food> foodlist = new List<Food>(); 
            foreach (Meal item in user.Meals)
            {
                meal = item;
                item.MealTime = mealtime;
                foreach (Food food in meal.Foods)
                {
                    foodlist.Add(food); 
                }
            }
            return foodlist;
           
        }

        public List<Food> ListFoodsbyUser(User user)
        {
            List<Food> foodlist = new List<Food>();

            foreach (Meal item in user.Meals)
            {
                foreach (Food food in item.Foods)
                {
                    foodlist.Add(food);
                }
            }
            return foodlist;
        }
        //id ye göre food getir
        public Food GetFoodbyId (int id)
        {
            return FEDietDbContext.Foods.Find(id);
        }

        public string GetFoodPicByID(int id)
        {
            return FEDietDbContext.Foods.Where(x => x.FoodID == id).Select(x => x.FoodPciture).FirstOrDefault();
        }
  

        public List<Food> GetAllFoods()
        {
            return FEDietDbContext.Foods.ToList();
        }

        public bool UpdateFoodForUser(Food _food)
        {
            Food food = FEDietDbContext.Foods.Find(_food.FoodID);
            food.Portion = _food.Portion;
            food.Quantity = _food.Quantity;
            return FEDietDbContext.SaveChanges() > 0;
        }

        public bool RemoveFoodFromUser(User _user,int id)
        {
            User user = FEDietDbContext.Users.Find(_user.UserID);
            Food food = GetFoodbyId(id);
            foreach (Meal item in user.Meals)
            {
                if (item.Foods.Contains(food))
                {
                    item.Foods.Remove(food);
                }
            }

            return FEDietDbContext.SaveChanges() >0;
        }


        public bool UpdateFoodOfUser(User _user, int id,Food newfood)
        {
            User user = FEDietDbContext.Users.Find(_user.UserID);
            Food food = GetFoodbyId(id);
            foreach (Meal item in user.Meals)
            {
                List<Food> foodList = item.Foods.Where(x=>x.FoodID==food.FoodID).ToList();
              
                    foreach (Food _food in foodList)
                    {
                        _food.FoodName = newfood.FoodName;
                        _food.Portion = newfood.Portion;
                        _food.Quantity = newfood.Quantity;
                    }                 
            }

            return FEDietDbContext.SaveChanges() > 0;
        }


    }
}
