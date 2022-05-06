using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FEDiet.DAL.Repositories
{
    public class UserRepository
    {
        FEDietDbContext db;
        
        public UserRepository()
        {
            db = new FEDietDbContext();           
        }
        
        public bool UserSignUp(User user)
        {
            db.Users.Add(user);
            return db.SaveChanges() > 0;
        }

        public bool UpdateUser(User user)
        {
            User updatedUser = db.Users.Find(user.UserID);
            updatedUser.Name = user.Name;
            updatedUser.Surname = user.Surname;
            updatedUser.Email = user.Email;
            updatedUser.Password = user.Password;
            updatedUser.IsActive = user.IsActive;
            return db.SaveChanges() > 0;
        }
        public bool DeleteUser(User user)
        {
            User deletedUser = db.Users.Find(user.UserID);
            deletedUser.IsActive = false;
            return db.SaveChanges() > 0;
        }

        public User CheckSignIn(string email, string password)
        {
            User user = db.Users.Where(x => (x.Email == email) && (x.Password == password)).SingleOrDefault();
            if (user != null)
            {
                if (user.Password != null && user.Password == password) return user;
            }
            return null;
        }

        public int AddMealbyUser(User user, Meal meal)//food eklenme ??
        {
            User _user = db.Users.Where(x => x.UserID == user.UserID).FirstOrDefault();
            _user.Meals.Add(meal);
            return db.SaveChanges();
        }

        public bool UpdateMealbyUser(User _user, Meal _meal,Food _food)
        {
            User user = db.Users.Find(_user.UserID);
            Meal meal = db.Meals.Find(_meal.MealID);
            Food food = db.Foods.Find(_food.FoodID);

            if (meal != null)
            {
                if (user.Meals.Contains(meal))
                {
                    if(meal.Foods.Contains(food))
                    {
                        meal.Foods = _meal.Foods;
                        meal.MealName = _meal.MealName;
                        meal.MealTime = _meal.MealTime;
                        food.Quantity = _food.Quantity;
                        food.Portion = _food.Portion;
                    }                                   
                }
            }           

            return db.SaveChanges()>0;
        }

        public bool DeleteMealbyUser(User _user,Meal _meal,Food _food)
        {
            User user = db.Users.Find(_user.UserID);
            Meal meal = db.Meals.Find(_meal.MealID);
            Food food = db.Foods.Find(_food.FoodID);

            if (meal != null)
            {
                if(user.Meals.Contains(meal))
                {
                    if(meal.Foods.Contains(food))
                    {
                       meal.Foods.Remove(food);
                    }
                }               
            }
            return db.SaveChanges()>0;
        }

   
        public double UserProteinRate(DateTime day, User _user)
        {
            double proteinrate = 0;
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var mealList = _user.Meals.Where(x => x.MealTime.Day == day.Day).ToList();
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    proteinrate += food.ProteinCaloryPerGram;
                }
            }
            return proteinrate; //böyle mi acaba, diğerlerini yapayım mı ki 
        }


        public double UserFatRate(DateTime day, User _user)
        {
            double proteinrate = 0;
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var mealList = _user.Meals.Where(x => x.MealTime.Day == day.Day).ToList();
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    proteinrate += food.FatCaloryPerGram;
                }
            }
            return proteinrate;
        }

        public double UserCarbRate(DateTime day, User _user)
        {
            double proteinrate = 0;
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var mealList = _user.Meals.Where(x => x.MealTime.Day == day.Day).ToList();
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    proteinrate += food.CarbonhydratesCaloryPerGram;
                }
            }
            return proteinrate;
        }


        //yağ oranı ortalamadan yüksek olan ve su oranı ortalamadan düşük olan yemekler listesi sorgu; bad idea
        //formuserreports
        public List<Food> BadFoodList(User _user)
        {
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var meallist = _user.Meals.ToList();
            List<Food> badfoodList = null;
            foreach (Meal item in meallist)
            {
                foreach (Food food in item.Foods)
                {
                    var avgfaterate = db.Foods.Where(x => x.FoodID == food.FoodID).Average(x => x.FatCaloryPerGram);
                
                    badfoodList = db.Foods.Where(x => x.FoodID == food.FoodID && (x.FatCaloryPerGram > avgfaterate)).ToList();
                }
            }
            return badfoodList.ToList();
        }

        //yağ oranı ortalamadan düşük olan ve su oranı ortalamadan yüksek olan yemekler listesi sorgu; better to eat

        public List<Food> BetterFoodList(User _user)
        {
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var meallist = _user.Meals.ToList();
            List<Food> badfoodList = null;
            foreach (Meal item in meallist)
            {
                foreach (Food food in item.Foods)
                {
                    var avgfaterate = db.Foods.Where(x => x.FoodID == food.FoodID).Average(x => x.FatCaloryPerGram);
                  
                    badfoodList = db.Foods.Where(x => x.FoodID == food.FoodID && (x.FatCaloryPerGram < avgfaterate)).ToList();
                }
            }
            return badfoodList.ToList();
        }


        //favorite food, en çok yediği yemek, desc - top 1, ya da iç içe select daha doğru 
        public string FavoriteFoodbyUser(User _user)
        {
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();
            var meallist = _user.Meals.ToList();
            string favoriteFood = "";
            foreach (Meal item in meallist)
            {
                foreach (Food food in item.Foods)
                {

                    favoriteFood = db.Foods.Where(x => x.FoodID == food.FoodID).GroupBy(x => x.FoodName).Select(g => new
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
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            double maxCalory = 0;
            string maxCalFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    if (maxCalory < food.CaloryPerOnePortion)
                    {
                        maxCalory = food.CaloryPerOnePortion;
                        maxCalFoodName = food.FoodName;
                    }
                }
            }
            return maxCalFoodName;
        }

        public string MaxProteinOfUser(User _user)
        {
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            double maxProtein = 0;
            string maxProtFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    if (maxProtein < food.ProteinCaloryPerGram)
                    {
                        maxProtein = food.ProteinCaloryPerGram;
                        maxProtFoodName = food.FoodName;
                    }
                }
            }
            return maxProtFoodName;
        }

        public string MaxFatOfUser(User _user)
        {
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            double maxFat = 0;
            string maxFatFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    if (maxFat < food.FatCaloryPerGram)
                    {
                        maxFat = food.FatCaloryPerGram;
                        maxFatFoodName = food.FoodName;
                    }
                }
            }
            return maxFatFoodName;
        }

        public string MaxCarbsOfUser(User _user)
        {
            _user = db.Users.Where(x => x.UserID == _user.UserID).FirstOrDefault();

            var mealList = _user.Meals.ToList();
            double maxCarbs = 0;
            string maxCarbsFoodName = "";
            foreach (Meal item in mealList)
            {
                foreach (Food food in item.Foods)
                {
                    if (maxCarbs < food.CarbonhydratesCaloryPerGram)
                    {
                        maxCarbs = food.CarbonhydratesCaloryPerGram;
                        maxCarbsFoodName = food.FoodName;
                    }
                }
            }
            return maxCarbsFoodName;
        }

       
        public DateTime UserFailedDay(User _user)
        {


            _user = db.Users.Find(_user.UserID);

            var mealList = _user.Meals.ToList();

            double cal = 0;
            List<double> CalList = new List<double>();
            List<DateTime> mealDaytime = new List<DateTime>();
            for (int i = 0; i < mealList.Count; i++)
            {

                for (int j = 0; j < mealList.Count; j++)
                {
                    if (i != j && mealList[i].MealTime.Day == mealList[j].MealTime.Day && mealList[i].MealTime.Month == mealList[j].MealTime.Month && mealList[i].MealTime.Year == mealList[j].MealTime.Year)
                    {

                        cal += mealList[i].MealCalory;
                    }
                    else
                    {
                        CalList.Add(cal);
                        mealDaytime.Add(mealList[i].MealTime);

                        cal = 0;
                    }
                }

            }

            double maximumCal = CalList.Max();
            int maxIndex = CalList.IndexOf(maximumCal);
            return mealDaytime[maxIndex];
        }

        public DateTime BestDay(User _user)
        {

            _user = db.Users.Find(_user.UserID);

            var mealList = _user.Meals.ToList();

            double cal = 0;
            List<double> CalList = new List<double>();
            List<DateTime> mealDaytime = new List<DateTime>();
            for (int i = 0; i < mealList.Count; i++)
            {
                
                for (int j = 0; j < mealList.Count; j++)
                {
                    if (i!=j && mealList[i].MealTime.Day == mealList[j].MealTime.Day && mealList[i].MealTime.Month == mealList[j].MealTime.Month && mealList[i].MealTime.Year == mealList[j].MealTime.Year)
                    {

                        cal += mealList[i].MealCalory;
                    }
                    else
                    {
                        CalList.Add(cal);
                        mealDaytime.Add(mealList[i].MealTime);

                        cal = 0;                       
                    }         
                }
                
            }

            double minimumCal = CalList.Min();
            int minIndex = CalList.IndexOf(minimumCal);
            return mealDaytime[minIndex];


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

      
        public int UserAge(DateTime date)
        {
            return DateTime.Now.Year - date.Year;
        }

        

    }
}
