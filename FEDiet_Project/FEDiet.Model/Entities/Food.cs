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
        public string FoodPciture { get; set; }
        public string Portion { get; set; }
        public double Quantity { get; set; }
        public double CaloryPerOnePortion { get; set; }
        public double FatCaloryPerGram { get; set; }
        public double ProteinCaloryPerGram { get; set; }
        public double CarbonhydratesCaloryPerGram { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public int? FoodCategoryID { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
    }
}
