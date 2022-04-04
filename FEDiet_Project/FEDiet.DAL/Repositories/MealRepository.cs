using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class MealRepository
    {
        FEDietDbContext db;
        public MealRepository()
        {
            db = new FEDietDbContext();
        }


        public bool Add(Meal meal)
        {
            db.Meals.Add(meal);
            return db.SaveChanges() > 0;
        }

        public bool AddUserMeal(User _user,Meal _meal)
        {
            User user = db.Users.Find(_user.UserID);
            user.Meals.Add(_meal);
            return db.SaveChanges() > 0;
        }


        public bool CreateMeal(Meal _meal, List<Food> foodlist)
        {

            Meal meal = db.Meals.Find(_meal.MealID);
            
            foreach (var food in foodlist)
            {
                Food _food = db.Foods.Find(food.FoodID);
               
                meal.Foods.Add(_food);
            }
            meal.MealCalory = MealCalorie(meal);
           return db.SaveChanges()>0;
       
        }

        public object GetUserMealList(User user)
        {
            return db.Users.Where(x=>x.UserID == user.UserID).Select(x=>x.Meals).ToList();
        }

        public Meal GetMealByID(int mealID)
        {
            return db.Meals.Where(x => x.MealID == mealID).FirstOrDefault();
        }

        public List<Meal> GetMealsByDate(DateTime mealtime, User _user)
        {
            List<Meal> meallist = new List<Meal>();
            User user=db.Users.Find(_user.UserID);
            foreach (var item in user.Meals)
            {
                meallist = db.Meals.Where(x=>x.MealTime.Day == mealtime.Day).ToList();
            }

            return meallist;
        }

         public List<Meal> GetMealsByDate(DateTime mealtime, User _user,string mealName)//gelen mealname e göre
        {
            List<Meal> meallist = new List<Meal>();
            User user = db.Users.Find(_user.UserID);
            foreach (Meal item in user.Meals)
            {
                meallist = db.Meals.Where(x => x.MealTime.Day == mealtime.Day && x.MealName==mealName).ToList();
            }

            return meallist;
        }

        public double MealCalorie(Meal _meal)
        {
            Meal meal = db.Meals.Find(_meal.MealID);
            double calorie = 0;
            foreach (Food item in meal.Foods)
            {
                Food food=db.Foods.Find(item.FoodID);
                switch (food.Portion)
                {
                    case "Single": calorie += (food.CaloryPerOnePortion)*food.Quantity; break;
                    case "Half": calorie += (food.CaloryPerOnePortion*0.50)*food.Quantity; break;
                    case "Quarter": calorie += (food.CaloryPerOnePortion*0.25)*food.Quantity; break;
                    default:
                        break;
                }
                
            }
            return calorie;
        }

        public double UserDailyConsumedCal(User user)
        {
            double dailycal = 0;
            User _user = db.Users.Find(user.UserID);

            foreach (Meal item in _user.Meals)
            {
                Meal meal = db.Meals.Where(x=>x.MealTime.Day == DateTime.Now.Day && x.MealID == item.MealID).FirstOrDefault();
                dailycal += MealCalorie(meal);
            }
            return dailycal;
        }

        public List<Food> FoodsOfMeal(Meal meal)
        {
            Meal _meal = db.Meals.Find(meal.MealID);
            return _meal.Foods.ToList();
        }

        public int MealIdByName(string mealname,User user)
        {
            User _user = db.Users.Find(user.UserID);
            int id = 0;
            foreach (Meal item in _user.Meals)
            {
                Meal meal = db.Meals.Find(item.MealID);
                if(meal.MealName==mealname && meal.MealID==item.MealID)
                {
                    id= item.MealID; 
                }
            } 
            return id;
        }

        public bool RemoveMealFromUser(User _user, Meal meal)
        {
            User user = db.Users.Find(_user.UserID);
            List<Meal> meals = user.Meals.ToList();
            foreach (Meal item in meals)
            {
                if (item.MealID == meal.MealID)
                {
                    user.Meals.Remove(item);
                }
            }

            return db.SaveChanges() > 0;
        }

        public bool UpdateMealOfUser(User _user, Meal meal)
        {
            User user = db.Users.Find(_user.UserID);
            foreach (Meal item in user.Meals)
            {
                if (item.MealID == meal.MealID)
                {
                    item.MealName = meal.MealName;
                    item.MealTime = meal.MealTime;
                }
            }

            return db.SaveChanges() > 0;
        }

    }
}
