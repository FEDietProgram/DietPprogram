using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    internal class MealRepository
    {
        FEDietDbContext FEDietDbContext;
        public MealRepository()
        {
            FEDietDbContext = new FEDietDbContext();
        }

        public object GetUserMealList(User user)
        {
            return FEDietDbContext.Users.Where(x=>x.UserID == user.UserID).Select(x=>x.Meals).ToList();
        }

        public object GetMealsbyName(User user, string mealname)
        {
            return FEDietDbContext.Meals.Where(x => x.MealName == mealname && x.Users.Contains(user)).ToList();
        }

        public Meal GetMealByID(int mealID)
        {
            return FEDietDbContext.Meals.Where(x => x.MealID == mealID).FirstOrDefault();
        }

        public object GetMealsByDate(DateTime mealtime, User user)
        {
            return FEDietDbContext.Meals.Where(x => x.MealTime == mealtime && x.Users.Contains(user)).ToList();
        }

        public decimal MealCalorie(User user, Meal _meal)
        {
            Meal meal = FEDietDbContext.Meals.Where(x => x.MealID == _meal.MealID && x.Users.Contains(user)).FirstOrDefault();
            if (meal != null)
            {
                foreach (Food item in meal.Foods)
                {
                    meal.TotalCalorie += item.Calorie;
                }
            }

            return meal.TotalCalorie;
                 
        }

        public decimal DailyCalori(User user, Meal _meal, DateTime time)
        {
            var mealList = FEDietDbContext.Meals.Where(x=>x.Users.Contains(user) && x.MealTime.Day == time.Day).ToList();
            decimal dailyCalorie = 0;
            if (mealList.Count > 0)
            {
                foreach (Meal item in mealList)
                {
                    dailyCalorie += item.TotalCalorie;
                }
            }

            return dailyCalorie;

        }

        public decimal WeeklyCalori(User user, Meal _meal, DateTime time1, DateTime time2)
        {
            var mealList = FEDietDbContext.Meals.Where(x => x.Users.Contains(user) && (time1 <= x.MealTime  && x.MealTime <= time2)).ToList();
            decimal dailyCalorie = 0;
            if (mealList.Count > 0)
            {
                foreach (Meal item in mealList)
                {
                    dailyCalorie += item.TotalCalorie;
                }
            }

            return dailyCalorie;

        }

        public decimal MountlyCalori(User user, Meal _meal, DateTime time1)
        {
            var mealList = FEDietDbContext.Meals.Where(x => x.Users.Contains(user) && (x.MealTime.Month == time1.Month)).ToList();
            decimal dailyCalorie = 0;
            if (mealList.Count > 0)
            {
                foreach (Meal item in mealList)
                {
                    dailyCalorie += item.TotalCalorie;
                }
            }

            return dailyCalorie;

        }

    }
}
