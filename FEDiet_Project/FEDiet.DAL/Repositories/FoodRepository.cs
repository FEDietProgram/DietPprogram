using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    internal class FoodRepository
    {
        FEDietDbContext FEDietDbContext;
        public FoodRepository()
        {
            FEDietDbContext = new FEDietDbContext();
        }
     

    }
}
