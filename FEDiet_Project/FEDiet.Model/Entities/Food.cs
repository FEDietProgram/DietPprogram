using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Food:BaseEntity
    {
        public Food()
        {
            Users = new HashSet<User>();
            Meals = new HashSet<Meal>();
        }
        public decimal Calorie { get; set; }
        public string Picture { get; set; }      
        public Neutrition Neutrition { get; set; } 
        public ICollection<User> Users { get; set; }
        public ICollection<Meal> Meals { get; set; }
        public decimal CarbRate { get; set; }
        public decimal FatRate { get; set; }
        public decimal ProteinRate { get; set; }
    }
}
