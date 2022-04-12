using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    public class FoodServices
    {
        FoodRepository foodRepository;
        public FoodServices()
        {
            foodRepository = new FoodRepository();
        }
        public bool AddFoodToUser(Food _food)
        {
            if (_food == null)
            {
                throw new Exception("Food is null");
            }
            else
            {
                return foodRepository.AddFoodToUser(_food);

            }
        }

        public List<Food> ListFoodsAcoordingToMeal(DateTime mealtime, Meal meal, User user)
        {            
            return foodRepository.ListFoodsAcoordingToMeal(mealtime, meal, user);
        }

        public List<Food> FoodsOfMeal(Meal meal, DateTime mealtime, User user)
        {
            List<Food> FoodList = null;
            if (meal != null && mealtime != null && user != null)
            {
                FoodList = foodRepository.ListFoodsAcoordingToMeal(mealtime, meal, user);  
            }

            return FoodList;
        }

        public List<Food> FoodsOfUser(User user)
        {
            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadı");
            }
            return foodRepository.ListFoodsbyUser(user);
        }

       
        public List<Food> GetAllFoods()
        {
            return foodRepository.GetAllFoods();
        }

        public Food GetFoodbyId(int id)
        {
            return foodRepository.GetFoodbyId(id);
        }
        public string GetFoodPicByID(int id)
        {
            return foodRepository.GetFoodPicByID(id);
        }
        public bool UpdateFoodForUser(Food _food)
        { 
            return foodRepository.UpdateFoodForUser(_food);
        }

        public bool DefaultFood(Food food)
        {
           return foodRepository.DefaultFood(food); 
        }

        public bool RemoveFoodFromUser(User _user, int id)
        {
           return foodRepository.RemoveFoodFromUser(_user, id);
        }

        public bool UpdateFoodByUser(User _user, Meal meal, Food oldfood, Food newfood)
        {
            return foodRepository.UpdateFoodByUser(_user, meal, oldfood, newfood);
        }
    }
}
