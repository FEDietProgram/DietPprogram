using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    public class MealServices
    {
        MealRepository mealRepository;
        UserRepository userRepository;  
        public MealServices()
        {
            mealRepository = new MealRepository();
            userRepository = new UserRepository();
        }

        public bool Add(Meal meal)
        {
            if (meal == null)
            {
                throw new Exception("Meal is null");
            }
            else
            {
                return mealRepository.Add(meal);
            }
            
        }

        public bool AddUserMeal(User _user, Meal _meal)
        {
            if (_user == null || _meal == null)
            {
                throw new Exception("User or meal is null");
            }
            else
            {
                return mealRepository.AddUserMeal(_user, _meal);
            }
            
        }

        public bool CreateMeal(Meal _meal, List<Food> foodlist)
        {
            if (_meal == null || foodlist == null)
            {
                throw new Exception("Meal or food is null");
            }
            else
            {
               return mealRepository.CreateMeal(_meal, foodlist);
            }           
        }


        public object GetUserMealList(User user)
        {
          return mealRepository.GetUserMealList(user);
        }

        public Meal GetMealByID(int mealID)
        {
            if(mealID == 0)
            { throw new Exception("Böyle bir öğün bulunamadı"); }

           return mealRepository.GetMealByID(mealID);
        }

        public List<Meal> GetMealsByDate(DateTime mealtime, User user)
        {
            if (mealtime == null)
            { throw new Exception("Öğün tarihini seçiniz"); }

            return mealRepository.GetMealsByDate(mealtime, user);
        }

        public List<Meal> GetMealsByDate(DateTime mealtime, User _user, string mealName)//gelen mealname e göre
        {
            return mealRepository.GetMealsByDate(mealtime,_user,mealName);
        }
        public double MealCalorie(Meal _meal)
        {
            return mealRepository.MealCalorie(_meal);
        }

        public double UserDailyConsumedCal(User user)
        {
            return mealRepository.UserDailyConsumedCal(user);
        }
        public List<Food> FoodsOfMeal(Meal meal)
        {
            return mealRepository.FoodsOfMeal(meal);
        }

       
        public int MealIdByName(string mealname, User user)
        {
            return mealRepository.MealIdByName(mealname, user);
        }

        public bool RemoveMealFromUser(User _user, Meal meal)
        {
            return mealRepository.RemoveMealFromUser(_user, meal);
        }
        public bool UpdateMealOfUser(User _user, Meal meal)
        {

            return mealRepository.UpdateMealOfUser(_user, meal);
        }
    }
}
