using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Meal:BaseEntity
    {
        public Meal()
        {
            Users = new HashSet<User>();
            Foods = new HashSet<Food>();
        }
        public DateTime MealTime { get; set; } = DateTime.Now;

        public ICollection<User> Users { get; set; }
        public ICollection<Food> Foods { get; set; }
        public FoodPortion FoodPortion{ get; set; }
    }
}
