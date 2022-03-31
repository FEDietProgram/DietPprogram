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

        public byte[] FoodPicture(int id)
        {
            if (id == 0)
            {
                throw new Exception("Yiyecek yok");
            }
            return foodRepository.GetFoodPicByName(id);
        }

        public List<Food> GetAllFoods()
        {
            return foodRepository.GetAllFoods();
        }

    }
}
