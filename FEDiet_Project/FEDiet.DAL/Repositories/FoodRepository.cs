using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    internal class FoodRepository
    {
        FEDietDbContext FEDietDbContext;
        public FoodRepository()
        {
            FEDietDbContext = new FEDietDbContext();
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
     

    }
}
