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
                Name = "Admin",
                Surname = "Admin",
                Email = "admin@fediet.com",
                Password = "12Ad!.",
                UserType = UserType.Admin
            };

            UserDetail adminDetail = new UserDetail()
            {
                UserDetailID = adminuser.UserID,
                Gender = "Female",
                Birthdate = DateTime.Now.AddYears(-50),
                Weight = 56,
                Height = 160,
                Job = "Admin"
            };

            context.Users.Add(adminuser);
            context.UserDetails.Add(adminDetail);
            context.SaveChanges();

            User user = new User()//userdetail ile optional olsun
            {
                Name = "Esra",
                Surname = "Yazıcı",
                Email = "esra@fediet.com",
                Password = "CtPNa5pX",
                UserType = UserType.StandardUser
            };

            UserDetail userDetail = new UserDetail()
            {
                UserDetailID = user.UserID,
                Gender = "Female",
                Birthdate = DateTime.Now.AddYears(-29),
                Weight = 56,
                Height = 160,
                NeckWidth = 22,
                WaistWidth = 75,
                HipWidth = 95,
                Job = "Yazılım"
            };


            Food food1 = new Food()
            {
                FoodName = "Kısır",
                CaloryPerOnePortion = 178,
                CarbonhydratesCaloryPerGram = 28.8,
                ProteinCaloryPerGram = 4.2,
                FatCaloryPerGram = 3.4,
                FoodPciture = @"C:\Users\Esra\Desktop\BilgeAdam_C#\FEDiet_Project\UIFEDiet\Resources\photo\ksr.jpg"
            };
            context.Foods.Add(food1);

            Food food2 = new Food()
            {
                FoodName = "Mantı",
                CaloryPerOnePortion = 190,
                CarbonhydratesCaloryPerGram = 29.71,
                ProteinCaloryPerGram = 4.12,
                FatCaloryPerGram = 3.5
            };
            context.Foods.Add(food2);


            context.Users.Add(user);
            context.UserDetails.Add(userDetail);
            context.SaveChanges();

            User user1 = new User()//userdetail ile optional olsun
            {
                Name = "Fatma",
                Surname = "Eraslan",
                Email = "fatma@fediet.com",
                Password = "1837fat.",
                UserType = UserType.StandardUser
            };

            UserDetail userDetail1 = new UserDetail()
            {
                UserDetailID = user1.UserID,
                Gender = "Female",
                Birthdate = DateTime.Now.AddYears(-23),
                Weight = 54,
                Height = 169,
                NeckWidth = 18,
                WaistWidth = 60,
                HipWidth = 80,
                Job = "Yıldız Yazılımcı"
            };

            context.Users.Add(user1);
            context.UserDetails.Add(userDetail1);



            Food food3 = new Food()
            {
                FoodName = "Yumurta",
                CaloryPerOnePortion = 50,
                CarbonhydratesCaloryPerGram = 0.3,
                ProteinCaloryPerGram = 6.5,
                FatCaloryPerGram = 6
            };
            context.Foods.Add(food3);

            Food food4 = new Food()
            {
                FoodName = "Erik",
                CaloryPerOnePortion = 19,
                CarbonhydratesCaloryPerGram = 4.94,
                ProteinCaloryPerGram = 0.7,
                FatCaloryPerGram = 0.23

            };
            context.Foods.Add(food4);

            context.SaveChanges();



        }
    }
}
