using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Meal
    {
        public Meal()
        {
            Users = new HashSet<User>();
            Foods = new HashSet<Food>();
        }
        public int MealID { get; set; }
        public string MealName { get; set; }
        public DateTime MealTime { get; set; } = DateTime.Now;
        public ICollection<User> Users { get; set; }
        public ICollection<Food> Foods { get; set; }
        public FoodPortion FoodPortion{ get; set; }
        public int Quantity { get; set; }
        public decimal TotalCalorie { get; set; }
    }
}
