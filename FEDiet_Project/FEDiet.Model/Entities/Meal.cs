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
        public double MealCalory { get; set; }
        public DateTime MealTime { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
