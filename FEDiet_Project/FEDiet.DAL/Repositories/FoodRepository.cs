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
        public byte[] GetFoodPicByName(int id)
        {
            byte[] pic = null;
            if (id != 0)
            {
                pic = FEDietDbContext.Foods.Where(x => x.FoodID == id).Select(x=>x.FoodPictures).FirstOrDefault();
            }

            return pic;
        }

        public List<Food> GetAllFoods()
        {
            return FEDietDbContext.Foods.ToList();
        }






       
     

    }
}
