using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    internal class UserRepository
    {
        FEDietDbContext FEDietDbContext;
        MealRepository MealRepository;
        public UserRepository()
        {
            FEDietDbContext = new FEDietDbContext();
            MealRepository = new MealRepository();
        }

        public int UserSignUp(User user)
        {
            FEDietDbContext.Users.Add(user);
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

        public string PasswordStrengthCheck(string password)
        {
            string passwordStrength = "";
            if (!string.IsNullOrEmpty(password) && password.Length>=4)
            {
                if (password.Any(char.IsUpper) || password.Any(char.IsLower) && password.Any(char.IsLetter) && !password.Any(char.IsDigit) && !password.Any(char.IsSymbol))
                {
                    passwordStrength = "Weak";
                }
                else if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Length <=6)
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

        public List<Meal> AddMeals(User user, Meal meal)
        {
            List<Meal> meals = new List<Meal>();
            user.Meals.Add(meal);
            meals = (List<Meal>)user.Meals;
            return meals;
        }

        public decimal UserDailyCal(User user, List<Meal> mealList, List<Food> foodList, DateTime selectedDate)
        {
            user.Meals = mealList;
            decimal dailyCal = 0;
            foreach (Meal item in mealList)
            {
                if (item.MealTime.Day == selectedDate.Day)
                {
                    ///
                }
                
            }
            return dailyCal;
            
        }
    }
}
