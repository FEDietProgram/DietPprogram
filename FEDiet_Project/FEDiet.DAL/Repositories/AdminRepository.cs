using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class AdminRepository
    {
        FEDietDbContext FEDietDbContext;
        public AdminRepository()
        {
            FEDietDbContext = new FEDietDbContext();    
        }
        
        //Edit meals
        public int AddMeal(Meal meal) 
        {
            FEDietDbContext.Meals.Add(meal);
          return  FEDietDbContext.SaveChanges();
        }
        public int UpdateMeal(Meal meal)
        {
            Meal meal1 = FEDietDbContext.Meals.Find(meal.MealID);
            meal1.MealName = meal.MealName;
            return FEDietDbContext.SaveChanges();   
        }
        public int DeleteMeal(Meal meal)
        {
            Meal meal1 = FEDietDbContext.Meals.Find(meal.MealID);
            FEDietDbContext.Meals.Remove(meal1);
            return FEDietDbContext.SaveChanges();   
        }

        //Edit foods
        public int AddFood(Food food)
        {
            FEDietDbContext.Foods.Add(food);
            return FEDietDbContext.SaveChanges();
        }
        public int UpdateFood(Food food)
        {
            Food food1 = FEDietDbContext.Foods.Find(food.FoodID);
            food1.FoodName = food.FoodName;
            food1.Calorie = food.Calorie;
            food1.Neutrition = food.Neutrition;
            food1.CarbRate = food.CarbRate;
            food1.FatRate = food.FatRate;   
            food1.ProteinRate = food.ProteinRate;
            food1.FoodPictures = food.FoodPictures;
            return FEDietDbContext.SaveChanges();
        }
        public int DeleteFood(int foodid)
        {
            Food food1 = FEDietDbContext.Foods.Find(foodid);
            FEDietDbContext.Foods.Remove(food1);
            return FEDietDbContext.SaveChanges();
        }

        //Edit Goals
        public int AddGoal(Goal goal)
        {
            FEDietDbContext.Goals.Add(goal);
            return FEDietDbContext.SaveChanges();
        }
        public int UpdateGoal(int goalid)
        {
            Goal goal1 = FEDietDbContext.Goals.Find(goalid);
            goal1.Name = goal1.Name;
            return FEDietDbContext.SaveChanges();
        }
        public int DeleteGoal(int goalid)
        {
            Goal goal1 = FEDietDbContext.Goals.Find(goalid);
            FEDietDbContext.Goals.Remove(goal1);
            return FEDietDbContext.SaveChanges();
        }

        //Edit Activity
        public int AddActivity(Activity activity)
        {
            FEDietDbContext.Activities.Add(activity);
            return FEDietDbContext.SaveChanges();
        }
        public int UpdateActivity(Activity activity)
        {
            Activity activity1 = FEDietDbContext.Activities.Find(activity.ActivityID);
            activity1.ActivityName = activity1.ActivityName;
            return FEDietDbContext.SaveChanges();
        }
        public int DeleteActivity(Activity activity)
        {
            Activity activity1 = FEDietDbContext.Activities.Find(activity.ActivityID);
            FEDietDbContext.Activities.Remove(activity1);
            return FEDietDbContext.SaveChanges();
        }

        // Raporlar
       
        public object UserListbyCalorie()        {

            object userMeals = FEDietDbContext.Meals.GroupBy(x => new { x.Users }).Select(g => new
            {
                users = g.Key.Users,
                sum = g.Sum(y => y.TotalCalorie)
            }).OrderByDescending(z => z.sum).ToList();

            return userMeals;

        }

        public object UserMostConsumedFoods()//tüketilme miktarına göre yemek listesi
        {
            var foodList = FEDietDbContext.Foods.Where(x => x.Meals == (FEDietDbContext.Users.Select(y => y.Meals)).ToList()).GroupBy(z => new { z.FoodID }).Select(g => new
            {
                foodID = g.Key.FoodID,
                count = g.Count()

            }).OrderByDescending(a => a.count).ToList();

            return foodList;
        }

        public object MealListbyCal()//öğünlere göre toplam kalori(garip bi rapor silebilirisn istersen)
        {
            var mealList = FEDietDbContext.Meals.GroupBy(x => x.MealName).Select(g => new
            {
                MealName = g.Key,
                sumcal = g.Sum(y => y.TotalCalorie)
            }).ToList();

            return mealList;    
        }

        public object UserListbyWeight()//?? kilo sırasına göre kullanıcılar
        {
            var userList = FEDietDbContext.UserDetails.Select(x=> new {
                x.Weight,
                x.User.FirstName,
                x.User.LastName
            }
            ).OrderByDescending(x=>x.Weight).ToList();


            return userList;
        }

        public object UserListByActivityTime()
        {
            var userList=FEDietDbContext.Activities.GroupBy(x=> new {x.Users}).Select(g => new
            {
                Users = g.Key,
                time=g.Sum(x=>x.ActivityTime)
            }).OrderByDescending(x=>x.time).ToList();


            return userList;
        }

  


    }
}
