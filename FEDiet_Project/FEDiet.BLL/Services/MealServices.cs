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

        public object GetMealsByDate(DateTime mealtime, User user)
        {
            if (mealtime == null)
            { throw new Exception("Öğün tarihini seçiniz"); }

            return mealRepository.GetMealsByDate((DateTime)mealtime, user);
        }

        public decimal MealCalorie(User user, Meal meal)
        {
            return mealRepository.MealCalorie(user, meal);
        }

        public decimal DailyCalori(User user,  DateTime time)
        {
            return mealRepository.DailyCalori(user,  time);
        }

        public decimal WeeklyCalori(User user, DateTime time1, DateTime time2)
        {
            return mealRepository.WeeklyCalori(user,  time1, time2);  
        }

        public decimal MountlyCalori(User user, DateTime time1)
        {
            return mealRepository.MountlyCalori(user,  time1);    
        }

        public int AddMealbyUser(User user, Meal meal)
        {
            if(meal==null)
            { throw new Exception("Ekleyeceğiniz yemeğin öğününü seçiniz"); }

            return userRepository.AddMealbyUser(user, meal);
        }
        public int UpdateMealbyUser(User user, Meal meal)
        {
            if (meal == null)
            { throw new Exception("Güncelleyeceğiniz yemeğin öğününü seçiniz"); }

            return userRepository.UpdateMealbyUser(user, meal);   
        }
        public int DeleteMealbyUser(User user, Meal meal)
        {
            if (meal == null)
            { throw new Exception("Sileceğiniz yemeğin öğününü seçiniz"); }

            return userRepository.DeleteMealbyUser(user, meal);
        }

        public object GetFoodsByMealName(User user, string mealname, DateTime mealtime)
        {
            if (user== null || mealname == null || mealtime == null)
            {
                throw new Exception("Kullanıcı, öğün adı ya da öğün tarihinden en az biri belirtilmemiştir.");
            }
            return mealRepository.GetMealsbyName(user, mealname, mealtime);
        }
       



    }
}
