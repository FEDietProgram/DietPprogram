using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Strategy
{
    internal class FoodStrategy: CreateDatabaseIfNotExists<FEDietDbContext>
    {
        protected override void Seed(FEDietDbContext context)
        {
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
