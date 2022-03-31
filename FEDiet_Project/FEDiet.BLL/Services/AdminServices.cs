using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    public class AdminServices
    {
        AdminRepository adminRepository;
        FoodRepository foodRepository;
        ActivityRepository activityRepository;
        GoalRepository goalRepository;

        public AdminServices()
        {
            adminRepository = new AdminRepository();
            foodRepository = new FoodRepository();
            activityRepository = new ActivityRepository();
            goalRepository = new GoalRepository();
        }

        public int AddMeal(Meal meal)
        {
            if (meal == null)
            {
                throw new Exception("Öğün girişi başarısız");
            }
            return adminRepository.AddMeal(meal);
        }

        public int AddFood(Food food)
        {
            if (food == null)
            {
                throw new Exception("Yiyecek girişi başarısız");
            }
            return adminRepository.AddFood(food);
        }

        public int DeleteFood(int foodid)
        {
            if(foodid==0)
            {
                throw new Exception("Silinecek yiyeceği seçin");
            }
            return adminRepository.DeleteFood(foodid);  
        }

        public int UpdateFood(Food food)
        {
            if (food == null)
            {
                throw new Exception("Güncellenecek yiyeceği seçin");
            }
            return adminRepository.UpdateFood(food);    
        }

        public Food GetFoodbyId(int id)
        {
            return foodRepository.GetFoodbyId(id);  
        }

        public int AddActivity(Activity activity)
        {
            if(activity == null)
            {
                throw new Exception("Eklenecek aktiviteyi girin");
            }
            return adminRepository.AddActivity(activity);
        }

        public int UpdateActivity(Activity activity)
        {
            if (activity == null)
            {
                throw new Exception("Güncellenecek aktiviteyi girin");
            }
            return adminRepository.UpdateActivity(activity);
        }
        
        public int DeleteActivity(Activity activity)
        {
            if (activity == null)
            {
                throw new Exception("Silinecek aktiviteyi girin");
            }
            return adminRepository.DeleteActivity(activity);
        }

        public Activity GetActivityByID(int id)
        {
            return activityRepository.GetActivityByID(id);
        }

        public int AddGoal(Goal goal)
        {
            if(goal == null)
            {
                throw new Exception("Hedef girişi yapın");
            }
            return adminRepository.AddGoal(goal);
        }

        public int UpdateGoal(int goalid)
        {
            if (goalid == 0)
            {
                throw new Exception("Güncellenecek hedefi girin");
            }
            return adminRepository.UpdateGoal(goalid);
        }

        public int DeleteGoal(int goalid)
        {
            if (goalid == 0)
            {
                throw new Exception("Silinecek hedefi girin");
            }
            return adminRepository.DeleteGoal(goalid);
        }

        public Goal GetGoalById(int id)
        {
            return goalRepository.GetGoalById(id);
        }

        public decimal GetSuccessRate(int id)
        {
            return goalRepository.GoalSuccessRate(id);
        }

        // Admin raporları

        public object UserListbyCalorie() // Kalorilerine Göre Kullanıcılar
        {
            return adminRepository.UserListbyCalorie();
        }

        public object UserMostConsumedFoods()//tüketilme miktarına göre yemek listesi
        {
            
            return adminRepository.UserMostConsumedFoods();
        }

        public object MealListbyCal()//öğünlere göre toplam kalori(garip bi rapor silebilirisn istersen)
        {
           
            return adminRepository.MealListbyCal();
        }

        public object UserListbyWeight()//?? kilo sırasına göre kullanıcılar
        {
           
            return adminRepository.UserListbyWeight();
        }

        public object UserListByActivityTime() //Aktivite Sürelerine Göre Kullanıcılar
        {
            return adminRepository.UserListByActivityTime();
        }

        public object MostConsumedFoodsAccordingToJobs() //Mesleklere göre en çok tüketilen yiyecekler
        {
            return adminRepository.MostConsumedFoodsAccordingToJobs();
        }

    }
}
