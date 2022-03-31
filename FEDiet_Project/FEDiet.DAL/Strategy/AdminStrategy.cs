using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Strategy
{
    class AdminStrategy:DropCreateDatabaseAlways<FEDietDbContext>
    {
        protected override void Seed(FEDietDbContext context)
        {
            User adminuser = new User()//userdetail ile optional olsun
            {
                FirstName = "Admin",
                LastName = "Admn",
                Email = "admin@gmail.com",
                Password = "1234",
                UserType=UserType.Admin
            };

            context.Users.Add(adminuser);

            Goal goal1 = new Goal()
            {
               Name = "Lose weight"             
            };

            Goal goal2 = new Goal()
            {
                Name = "Lose weight"
            };

            Goal goal3 = new Goal()
            {
                Name = "Lose weight"
            };

            context.Goals.Add(goal1);
            context.Goals.Add(goal2);
            context.Goals.Add(goal3);

            Activity activity1 = new Activity()
            {
                ActivityName = "Yürüyüş",
                BurnedCaloriePerHour = 270
            };

            Activity activity2 = new Activity()
            {
                ActivityName = "Koşu",
                BurnedCaloriePerHour = 650
            };

            Activity activity3 = new Activity()
            {
                ActivityName = "Bisiklet Sürme",
                BurnedCaloriePerHour = 650
            };

            Activity activity4 = new Activity()
            {
                ActivityName = "Yoga",
                BurnedCaloriePerHour = 244
            };

            Activity activity5 = new Activity()
            {
                ActivityName = "Fitness",
                BurnedCaloriePerHour = 546
            };

            context.Activities.Add(activity1);
            context.Activities.Add(activity2);
            context.Activities.Add(activity3);
            context.Activities.Add(activity4);
            context.Activities.Add(activity5);

            Food food1 = new Food()
            {
                FoodName = "Kısır",
                Calorie = 178,
                CarbRate = 28.8M,
                ProteinRate = 4.2M,
                FatRate = 3.4M
            };
            context.Foods.Add(food1);

            Food food2 = new Food()
            {
                FoodName = "Mantı",
                Calorie = 190,
                CarbRate = 29.71M,
                ProteinRate = 4.12M,
                FatRate = 3.5M
            };
            context.Foods.Add(food2);

            Food food3 = new Food()
            {
                FoodName = "Yumurta",
                Calorie = 50,
                CarbRate = 0.3M,
                ProteinRate = 6.5M,
                FatRate = 6
            };
            context.Foods.Add(food3);

            Food food4 = new Food()
            {
                FoodName = "Erik",
                Calorie = 19,
                CarbRate = 4.94M,
                ProteinRate = 0.7M,
                FatRate = 0.23m

            };
            context.Foods.Add(food4);

   

            context.SaveChanges();  

        }
    }
}
