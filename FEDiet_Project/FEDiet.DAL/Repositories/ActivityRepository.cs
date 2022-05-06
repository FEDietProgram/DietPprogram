using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class ActivityRepository
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

        //public decimal BurnedCalory(User user, DateTime day)
        //{
        //    List<Activity> activityList = user.Activities.ToList();

        //    decimal burned = 0;
        //    foreach (var item in activityList)
        //    {
        //        if (item.ActivityDay == day)
        //        {
        //            burned += item.ActivityTime * item.BurnedCaloriePerHour;
        //        }
        //    }

        //    return burned;

        //}

    }
}
