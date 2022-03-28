using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class WaterRepository
    {
        FEDietDbContext fEDietDbContext;
        public WaterRepository()
        {
            fEDietDbContext = new FEDietDbContext();
        }

        public int UserWaterAdd(User user,Water water, int cup)
        {
            user.Waters.Add(water);
            water.Cup += cup;
            return fEDietDbContext.SaveChanges();
        }
    }
}
