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
    class AdminStrategy:CreateDatabaseIfNotExists<FEDietDbContext>
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

            context.SaveChanges();  

        }
    }
}
