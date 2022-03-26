using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    internal class MealRepository
    {
        FEDietDbContext FEDietDbContext;
        public MealRepository()
        {
            FEDietDbContext = new FEDietDbContext();
        }

        public Meal FillMeal(List<Food> foodlist)
        {
            Meal meal = new Meal();
            meal.Foods = foodlist;
            return meal;
        }
     
        public decimal TotalMealCal(Meal meal, int quantity)
        {
            FoodPortion portion = new FoodPortion();
            List<Food> foods = new List<Food>();//** 
            foods = (List<Food>)meal.Foods;

            decimal total = 0;  

            foreach (Food food in foods)
            {
                switch (portion)
                {
                    case FoodPortion.Single:
                        total += food.Calorie*1;
                        break;

                    case FoodPortion.Double:
                        total += food.Calorie * 2;
                        break;

                    case FoodPortion.Quarter:
                        total += food.Calorie * Convert.ToDecimal(0.25);
                        break;

                    case FoodPortion.Half:
                        total += food.Calorie * Convert.ToDecimal(0.5);
                        break;
                    case FoodPortion.Piece:
                        total += food.Calorie * 1;
                        break;
                }
                
            }
            return total*quantity;   
        }

        public decimal TotalMealFat (Meal meal, int quantity)
        {
            FoodPortion portion = new FoodPortion();
            List<Food> foods = new List<Food>();
            foods = (List<Food>)meal.Foods;
            decimal total = 0;

            foreach (Food food in foods)
            {
                switch (portion)
                {
                    case FoodPortion.Single:
                        total += food.Calorie * food.FatRate * 1;
                        break;

                    case FoodPortion.Double:
                        total += food.Calorie * food.FatRate * 2;
                        break;

                    case FoodPortion.Quarter:
                        total += food.Calorie * food.FatRate * Convert.ToDecimal(0.25);
                        break;

                    case FoodPortion.Half:
                        total += food.Calorie * food.FatRate * Convert.ToDecimal(0.5);
                        break;
                    case FoodPortion.Piece:
                        total += food.Calorie * food.FatRate * 1;
                        break;
                }
            }
            return total*quantity;
        }

        public decimal TotalMealCarb(Meal meal, int quantity)
        {
            FoodPortion portion = new FoodPortion();
            List<Food> foods = new List<Food>();
            foods = (List<Food>)meal.Foods;
            decimal total = 0;

            foreach (Food food in foods)
            {
                switch (portion)
                {
                    case FoodPortion.Single:
                        total += food.Calorie * food.CarbRate * 1;
                        break;

                    case FoodPortion.Double:
                        total += food.Calorie * food.CarbRate * 2;
                        break;

                    case FoodPortion.Quarter:
                        total += food.Calorie * food.CarbRate * Convert.ToDecimal(0.25);
                        break;

                    case FoodPortion.Half:
                        total += food.Calorie * food.CarbRate * Convert.ToDecimal(0.5);
                        break;
                    case FoodPortion.Piece:
                        total += food.Calorie * food.CarbRate * 1;
                        break;
                }
            }
            return total * quantity;
        }

        public decimal TotalMealProtein(Meal meal, int quantity)
        {
            FoodPortion portion = new FoodPortion();
            List<Food> foods = new List<Food>();
            foods = (List<Food>)meal.Foods;
            decimal total = 0;

            foreach (Food food in foods)
            {
                switch (portion)
                {
                    case FoodPortion.Single:
                        total += food.Calorie * food.ProteinRate * 1;
                        break;

                    case FoodPortion.Double:
                        total += food.Calorie * food.ProteinRate * 2;
                        break;

                    case FoodPortion.Quarter:
                        total += food.Calorie * food.ProteinRate * Convert.ToDecimal(0.25);
                        break;

                    case FoodPortion.Half:
                        total += food.Calorie * food.ProteinRate * Convert.ToDecimal(0.5);
                        break;
                    case FoodPortion.Piece:
                        total += food.Calorie * food.ProteinRate * 1;
                        break;
                }
            }
            return total * quantity;
        }

    }
}
