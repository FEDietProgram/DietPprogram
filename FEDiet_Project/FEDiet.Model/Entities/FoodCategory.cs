using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class FoodCategory
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }
        public int FoodCategoryID { get; set; }
        public string FoodCategoryName { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
