using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    internal class ActivityRepository
    {
        FEDietDbContext FEDietDbContext;

        public ActivityRepository()
        {
            FEDietDbContext = new FEDietDbContext();
        }

        public object GetActivityListofUser(User user)
        {
            return FEDietDbContext.Activities.Where(x => x.Users.Contains(user)).ToList();
        }

        public object GetActivitiesyByName(string ActivityName)
        {
            return FEDietDbContext.Activities.Where(x=>x.ActivityName == ActivityName).FirstOrDefault();
        }

        public Activity GetActivityByID(int id)
        {
            return FEDietDbContext.Activities.Where(x => x.ActivityID == id).FirstOrDefault();
        }

    }
}
