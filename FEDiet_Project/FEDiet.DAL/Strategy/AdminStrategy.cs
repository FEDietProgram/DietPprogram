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
                WaistWidth=20,
                HipWidth=20,
                NeckWidth=20,
                Job = "Admin"

            };

            context.Users.Add(adminuser);
            context.UserDetails.Add(adminDetail);
            context.SaveChanges();

            User user = new User()
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
                Job = "CEO",
                UserSituation = SpecialSituation.No.ToString()
                
            };
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
                Job = "Software Developer",
                UserSituation = SpecialSituation.Pregnant.ToString(),
                PregnancyStartDate = DateTime.Now.AddMonths(-5)
            };

            context.Users.Add(user1);
            context.UserDetails.Add(userDetail1);
            context.SaveChanges();


            Food food1 = new Food()
            {
                FoodName = "Kısır",
                CaloryPerOnePortion = 178,
                CarbonhydratesCaloryPerGram = 28.8,
                ProteinCaloryPerGram = 4.2,
                FatCaloryPerGram = 3.4,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\ksr.jpg"
            };
            context.Foods.Add(food1);

            Food food2 = new Food()
            {
                FoodName = "Mantı",
                CaloryPerOnePortion = 190,
                CarbonhydratesCaloryPerGram = 29.71,
                ProteinCaloryPerGram = 4.12,
                FatCaloryPerGram = 3.5,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\manti.jpg"
            };
            context.Foods.Add(food2);

            User userd = new User()
            {
                Name = "Erdal",
                Surname = "Dağ",
                Email = "erdal@fediet.com",
                Password = "123Er.",
                UserType = UserType.StandardUser
            };

            UserDetail userDetaild = new UserDetail()
            {
                UserDetailID = userd.UserID,
                Gender = "Male",
                Birthdate = DateTime.Now.AddYears(-48),
                Weight = 85,
                Height = 170,
                NeckWidth = 30,
                WaistWidth = 120,
                HipWidth = 140,
                Job = "Software Developer",
                UserSituation = SpecialSituation.Diabetes.ToString()
            };


            context.Users.Add(userd);
            context.UserDetails.Add(userDetaild);
            context.SaveChanges();

            Food food3 = new Food()
            {
                FoodName = "Egg",
                CaloryPerOnePortion = 50,
                CarbonhydratesCaloryPerGram = 0.3,
                ProteinCaloryPerGram = 6.5,
                FatCaloryPerGram = 6,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\yumurta.jpg"
            };
            context.Foods.Add(food3);

            Food food4 = new Food()
            {
                FoodName = "Plum",
                CaloryPerOnePortion = 19,
                CarbonhydratesCaloryPerGram = 4.94,
                ProteinCaloryPerGram = 0.7,
                FatCaloryPerGram = 0.23,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\erik.jpg"

            };
            context.Foods.Add(food4);
            Food food5 = new Food()
            {
                FoodName = "Rozbif",
                CaloryPerOnePortion = 267,
                CarbonhydratesCaloryPerGram = 0,
                ProteinCaloryPerGram = 25.91,
                FatCaloryPerGram = 17.32,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\rozbif.jpg"
            };
            context.Foods.Add(food5);

            Food food6 = new Food()
            {
                FoodName = "Coleslaw Salad",
                CaloryPerOnePortion = 390,
                CarbonhydratesCaloryPerGram = 23.8,
                ProteinCaloryPerGram = 0.9,
                FatCaloryPerGram = 33.4,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\coleslawSalad.jpg"
            };
            context.Foods.Add(food6);

            Food food7 = new Food()
            {
                FoodName = "Turkey",
                CaloryPerOnePortion = 238,
                CarbonhydratesCaloryPerGram = 0,
                ProteinCaloryPerGram = 41.05,
                FatCaloryPerGram = 6.96,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\turkey.jpg"
            };
            context.Foods.Add(food7);

            Food food8 = new Food()
            {
                FoodName = "Burrito",
                CaloryPerOnePortion = 203,
                CarbonhydratesCaloryPerGram = 15.95,
                ProteinCaloryPerGram = 8.86,
                FatCaloryPerGram = 26.1,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\burrito.jpg"
            };
            context.Foods.Add(food8);

            Food food9 = new Food()
            {
                FoodName = "Donut",
                CaloryPerOnePortion = 190,
                CarbonhydratesCaloryPerGram = 21.62,
                ProteinCaloryPerGram = 2.62,
                FatCaloryPerGram = 10.51,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\donut.jpg"
            };
            context.Foods.Add(food9);

            Food food10 = new Food()
            {
                FoodName = "Cheesecake",
                CaloryPerOnePortion = 257,
                CarbonhydratesCaloryPerGram = 20.4,
                ProteinCaloryPerGram = 4.4,
                FatCaloryPerGram = 18,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\cheesecake.jpg"
            };
            context.Foods.Add(food10);

            Food food11 = new Food()
            {
                FoodName = "Bagel",
                CaloryPerOnePortion = 250,
                CarbonhydratesCaloryPerGram = 48.9,
                ProteinCaloryPerGram = 8,
                FatCaloryPerGram = 1.53,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\bagel.jpg"
            };
            context.Foods.Add(food11);

            Food food12 = new Food()
            {
                FoodName = "Clam Chowder",
                CaloryPerOnePortion = 280,
                CarbonhydratesCaloryPerGram = 24,
                ProteinCaloryPerGram = 8,
                FatCaloryPerGram = 16,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\bagel.jpg"
            };
            context.Foods.Add(food12);

            Food food13 = new Food()
            {
                FoodName = "Hot Dog",
                CaloryPerOnePortion = 195,
                CarbonhydratesCaloryPerGram = 14,
                ProteinCaloryPerGram = 8,
                FatCaloryPerGram = 12,
                FoodPciture = @"C:\Users\Esra\Desktop\GitOrganizationRepo\DietPprogram\FEDiet_Project\UIFEDiet\Resources\photo\hotDog.jpg"
            };
            context.Foods.Add(food13);

   
            context.SaveChanges();



        }
    }
}
