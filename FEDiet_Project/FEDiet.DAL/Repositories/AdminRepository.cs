using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class AdminRepository
    {
        FEDietDbContext db;
        public AdminRepository()
        {
            db = new FEDietDbContext();    
        }
        
      
        //Edit foods
        public bool AddFood(Food food)
        {
            List<string> foodNamelist = db.Foods.Select(x=>x.FoodName).ToList();
            if (foodNamelist.Contains(food.FoodName))
            {
                throw new Exception("This food is already exist");
            }
            else
            {
                db.Foods.Add(food);
            }           
            return db.SaveChanges() > 0;
        }
        public bool UpdateFood(Food food)
        {
            Food food1 = db.Foods.Find(food.FoodID);
            food1.FoodName = food.FoodName;
            food1.CaloryPerOnePortion = food.CaloryPerOnePortion;
            food1.CarbonhydratesCaloryPerGram = food.CarbonhydratesCaloryPerGram;
            food1.FatCaloryPerGram = food.FatCaloryPerGram;
            food1.ProteinCaloryPerGram = food.ProteinCaloryPerGram;
            food1.FoodPciture = food.FoodPciture;
            return db.SaveChanges() > 0;
        }
        public bool DeleteFood(int foodid)
        {
            Food food1 = db.Foods.Find(foodid);
            db.Foods.Remove(food1);
            return db.SaveChanges() > 0;
        }
        public List<User> UserList()
        {
            return db.Users.Where(x=>x.UserType==UserType.StandardUser).ToList();
        }



        //// Raporlar

        public object UserListbyCalorie()
        {
            object userMeals = db.Meals.GroupBy(x => new { x.Users }).Select(g => new
            {
                users = g.Key.Users,
                sum = g.Sum(y => y.MealCalory)
            }).OrderByDescending(z => z.sum).ToList();

            return userMeals;
        }

        public object UserMostConsumedFoods()//tüketilme miktarına göre yemek listesi
        {
            var foodList = db.Foods.Where(x => x.Meals == (db.Users.Select(y => y.Meals)).ToList()).GroupBy(z => new { z.FoodID }).Select(g => new
            {
                foodID = g.Key.FoodID,
                count = g.Count()

            }).OrderByDescending(a => a.count).ToList();

            return foodList;
        }

        public object MealListbyCal()//öğünlere göre toplam kalori(garip bi rapor silebilirisn istersen)
        {
            var mealList = db.Meals.GroupBy(x => x.MealName).Select(g => new
            {
                MealName = g.Key,
                sumcal = g.Sum(y => y.MealCalory)
            }).ToList();

            return mealList;
        }

        public object UserListbyWeight()// kilo sırasına göre kullanıcılar
        {
            var userList = db.UserDetails.Select(x => new
            {
                x.Weight,
                x.User.Name,
                x.User.Surname
            }
            ).OrderByDescending(x => x.Weight).ToList();


            return userList;
        }

       
        public object MostConsumedFoodsAccordingToJobs()//Mesleklere göre en çok tüketilen yiyecekler
        {

            return db.Meals.GroupBy(m => new { Foods = m.Foods, Jobs = m.Users.Select(x => x.UserDetail.Job) }).Select(g => new
            {
                g.Key.Foods,
                g.Key.Jobs,
                maxcount = g.Max(x => x.Foods.Count),
            }).OrderByDescending(y => y.maxcount);

        }
    }
}
