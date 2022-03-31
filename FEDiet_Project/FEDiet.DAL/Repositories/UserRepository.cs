using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FEDiet.DAL.Repositories
{
    public class UserRepository
    {
        FEDietDbContext FEDietDbContext;
        
        public UserRepository()
        {
            FEDietDbContext = new FEDietDbContext();           
        }

        public int UserSignUp(User user)
        {
            FEDietDbContext.Users.Add(user);
            return FEDietDbContext.SaveChanges();
        }

        public int UpdateUser(User _user)
        {
            User user= FEDietDbContext.Users.Find(_user);

            user.FirstName = _user.FirstName;
            user.LastName = _user.LastName;
            user.Email = _user.Email;
            user.Goal = _user.Goal;
            user.UserDetail.Job = _user.UserDetail.Job;
            user.UserDetail.Weight = _user.UserDetail.Weight;   
            user.UserDetail.Height = _user.UserDetail.Height;
            user.UserDetail.NeckWidth=user.UserDetail.NeckWidth;
            user.UserDetail.BirthDate = _user.UserDetail.BirthDate;
            user.UserDetail.Gender = _user.UserDetail.Gender;  
            user.UserDetail.HipWidth = _user.UserDetail.HipWidth;
            user.UserDetail.WaistWidth=user.UserDetail.WaistWidth;
            user.Password = _user.Password;
            user.SpecialSituations = _user.SpecialSituations;
            return FEDietDbContext.SaveChanges();
        }

        //kullanıcı kayıtlı mı kontrol / user dönüyor çünkü bir nedeni admin mi değil mi usertype enum ile kontrol edebilmek için direk texboxdan da kontrol edebilirdik ama bu daha sağlıklı
        public User CheckSignIn(string email, string password)
        {
            User user = FEDietDbContext.Users.Where(x => (x.Email == email) && (x.Password == password)).SingleOrDefault();
            if (user != null)
            {
                if (user.Password != null && user.Password == password) return user;
            }
            return null;
        }

        public int AddMealbyUser(User user, Meal meal)//food eklenme ??
        {
            User _user = FEDietDbContext.Users.Where(x => x.UserID == user.UserID).FirstOrDefault();
            _user.Meals.Add(meal);
            return FEDietDbContext.SaveChanges();
        }

        public int UpdateMealbyUser(User _user, Meal _meal)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            Meal meal = _user.Meals.Where(x => x.MealID == _meal.MealID).FirstOrDefault();
            if (meal != null)
            {
                meal.Foods = _meal.Foods;
                meal.MealName = _meal.MealName;
                meal.MealTime = _meal.MealTime;
                meal.Quantity = _meal.Quantity;
                meal.FoodPortion = _meal.FoodPortion;
                meal.TotalCalorie = _meal.TotalCalorie;
            }       

            return FEDietDbContext.SaveChanges();        
        }

        public int DeleteMealbyUser(User _user, Meal _meal)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            Meal meal = _user.Meals.Where(x => x.MealID == _meal.MealID).FirstOrDefault();
            if (meal != null)
            {
                _user.Meals.Remove(meal);
            }
            return FEDietDbContext.SaveChanges();
        }

        public int AddActivityByUser(User user, Activity activity)
        {
             User _user = FEDietDbContext.Users.Where(x => x.UserID == user.UserID).FirstOrDefault();
             _user.Activities.Add(activity);
             return FEDietDbContext.SaveChanges();    
        }
      
        public int UpdateActivityByUser(User _user, Activity _activity)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            Activity activity = _user.Activities.Where(x => x.ActivityID == _activity.ActivityID).FirstOrDefault();
            if (activity != null)
            {
                activity.ActivityDay = _activity.ActivityDay;
                activity.ActivityName = _activity.ActivityName;
                activity.ActivityTime = _activity.ActivityTime;
            }

            return FEDietDbContext.SaveChanges();
        }

        public int DeleteActivityByUser(User _user, Activity _activity)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            Activity activity = _user.Activities.Where(x => x.ActivityID == _activity.ActivityID).FirstOrDefault();
            if (activity != null)
            {
                _user.Activities.Remove(activity);
            }

            return FEDietDbContext.SaveChanges();

        }

        //seçilen tarihe göre aktivite listele 
        public List<Activity> ActivityList(DateTime date,User _user )
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
          var activityList = _user.Activities.Where(x => x.ActivityDay==date).ToList();
            return activityList;
        }

        //günlük aldığı mikro besin oranları ayrı ayrı method user da olmayabilir tabi..

        public decimal UserProteinRate(DateTime day, User _user)
        {
            decimal proteinrate = 0;
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var mealList = _user.Meals.Where(x => x.MealTime.Day == day.Day).ToList();
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    proteinrate += food.ProteinRate;
                }
            }
            return proteinrate; //böyle mi acaba, diğerlerini yapayım mı ki 
        }


        public decimal UserFatRate(DateTime day, User _user)
        {
            decimal proteinrate = 0;
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var mealList = _user.Meals.Where(x=>x.MealTime.Day==day.Day).ToList();
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    proteinrate += food.FatRate;
                }
            }
            return proteinrate; 
        }

        public decimal UserCarbRate(DateTime day, User _user)
        {
            decimal proteinrate = 0;
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var mealList = _user.Meals.Where(x => x.MealTime.Day == day.Day).ToList();
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    proteinrate += food.CarbRate;
                }
            }
            return proteinrate;
        }

        public decimal UserWaterRate(DateTime day, User _user)
        {
            decimal proteinrate = 0;
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var mealList = _user.Meals.Where(x => x.MealTime.Day == day.Day).ToList();
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    proteinrate += food.WaterRate;
                }
            }
            return proteinrate;
        }

        //yağ oranı ortalamadan yüksek olan ve su oranı ortalamadan düşük olan yemekler listesi sorgu; bad idea
        //formuserreports
        public List<Food> BadFoodList(User _user)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var meallist = _user.Meals.ToList();
            List<Food> badfoodList=null;
            foreach (Meal item in meallist)
            {
                foreach (Food food in item.Foods)
                {
                    var avgfaterate = FEDietDbContext.Foods.Where(x=>x.FoodID==food.FoodID).Average(x => x.FatRate);
                    var avgwaterrate = FEDietDbContext.Foods.Where(x => x.FoodID == food.FoodID).Average(x => x.WaterRate);
                    badfoodList= FEDietDbContext.Foods.Where(x => x.FoodID == food.FoodID && (x.FatRate>avgfaterate && x.WaterRate<avgwaterrate)).ToList();
                }
            }
            return badfoodList.ToList();
        }

        //yağ oranı ortalamadan düşük olan ve su oranı ortalamadan yüksek olan yemekler listesi sorgu; better to eat

        public List<Food> BetterFoodList(User _user)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var meallist = _user.Meals.ToList();
            List<Food> badfoodList = null;
            foreach (Meal item in meallist)
            {
                foreach (Food food in item.Foods)
                {
                    var avgfaterate = FEDietDbContext.Foods.Where(x => x.FoodID == food.FoodID).Average(x => x.FatRate);
                    var avgwaterrate = FEDietDbContext.Foods.Where(x => x.FoodID == food.FoodID).Average(x => x.WaterRate);
                    badfoodList = FEDietDbContext.Foods.Where(x => x.FoodID == food.FoodID && (x.FatRate < avgfaterate && x.WaterRate > avgwaterrate)).ToList();
                }
            }
            return badfoodList.ToList();
        }


//favorite food, en çok yediği yemek, desc - top 1, ya da iç içe select daha doğru 
        public string FavoriteFoodbyUser(User _user)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var meallist = _user.Meals.ToList();
            string favoriteFood = "";
            foreach (Meal item in meallist)
            {
                foreach (Food food in item.Foods)
                {

                    favoriteFood = FEDietDbContext.Foods.Where(x => x.FoodID == food.FoodID).GroupBy(x => x.FoodName).Select(g => new
                    {
                        FoodName = g.Key,
                        count = g.Count()
                    }).OrderByDescending(x => x.count).Select(x => x.FoodName).FirstOrDefault();               
                }
            }

            return favoriteFood;
        }

        public string MaxCaloryOfUser(User _user)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            decimal maxCalory = 0;
            string maxCalFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach(Food food in item.Foods)
                {
                    if (maxCalory < food.Calorie)
                    {
                        maxCalory = food.Calorie;
                        maxCalFoodName = food.FoodName;
                    }
                }              
            }
            return maxCalFoodName;
        }

        public string MaxProteinOfUser(User _user)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            decimal maxProtein = 0;
            string maxProtFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    if (maxProtein < food.ProteinRate)
                    {
                        maxProtein = food.ProteinRate;
                        maxProtFoodName = food.FoodName;
                    }
                }
            }
            return maxProtFoodName;
        }

        public string MaxFatOfUser(User _user)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            decimal maxFat = 0;
            string maxFatFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    if (maxFat < food.ProteinRate)
                    {
                        maxFat = food.ProteinRate;
                        maxFatFoodName = food.FoodName;
                    }
                }
            }
            return maxFatFoodName;
        }

        public string MaxCarbsOfUser(User _user)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            decimal maxCarbs = 0;
            string maxCarbsFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    if (maxCarbs < food.ProteinRate)
                    {
                        maxCarbs = food.ProteinRate;
                        maxCarbsFoodName = food.FoodName;
                    }
                }
            }
            return maxCarbsFoodName;
        }

        public string MaxWaterOfUser(User _user)
        {
            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            decimal maxWater = 0;
            string maxWaterFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    if (maxWater < food.ProteinRate)
                    {
                        maxWater = food.ProteinRate;
                        maxWaterFoodName = food.FoodName;
                    }
                }
            }
            return maxWaterFoodName;
        }

        public DateTime UserFailedDay(User _user)
        {

            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();


            DateTime FailDay = FEDietDbContext.Meals.Where(x=>x.Users.Contains(_user)).GroupBy(x => x.MealTime).Select(g => new
                {
                    MealTime = g.Key,
                    summing = g.Sum(x=>x.TotalCalorie)
                }).OrderByDescending(x => x.summing).Select(x => x.MealTime).FirstOrDefault();    

            return FailDay;
        }

        public DateTime BestDay(User _user)
        {

            _user = FEDietDbContext.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
 

            DateTime FailDay = FEDietDbContext.Meals.Where(x => x.Users.Contains(_user)).GroupBy(x => x.MealTime).Select(g => new
            {
                MealTime = g.Key,
                summing = g.Sum(x => x.TotalCalorie)
            }).OrderBy(x => x.summing).Select(x => x.MealTime).FirstOrDefault();

            return FailDay;

        }
        public string PasswordStrengthCheck(string password)
        {
            string passwordStrength = "";
            if (!string.IsNullOrEmpty(password) && password.Length >= 4)
            {
                if (password.Any(char.IsUpper) || password.Any(char.IsLower) && password.Any(char.IsLetter) && !password.Any(char.IsDigit) && !password.Any(char.IsSymbol))
                {
                    passwordStrength = "Weak";
                }
                else if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Length <= 6)
                {
                    passwordStrength = "Medium";
                }
                else
                {
                    passwordStrength = "Strong";
                }
            }
            return passwordStrength;
        }

        public List<User> UserList()
        {
            return FEDietDbContext.Users.ToList();
        }

        public int UserAge(DateTime date)
        {
            return DateTime.Now.Year- date.Year;
        }

    }
}
