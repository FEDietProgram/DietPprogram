using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Food
    {
        public Food()
        {
            Meals = new HashSet<Meal>();
        }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public decimal Calorie { get; set; }
        public byte[] FoodPictures { get; set; }    
        public Neutrition Neutrition { get; set; } 
        public ICollection<Meal> Meals { get; set; }
        public decimal CarbRate { get; set; }
        public decimal FatRate { get; set; }
        public decimal ProteinRate { get; set; }
        public decimal WaterRate { get; set; }
    }
}
