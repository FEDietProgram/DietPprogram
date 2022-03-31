using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class GoalRepository
    {
        FEDietDbContext FEDietDbContext;
        public GoalRepository()
        {
            FEDietDbContext = new FEDietDbContext();
        }

        public List<Goal> ListGoal()
        {
            return FEDietDbContext.Goals.ToList();
        }

        public Goal GetGoalById(int id)
        {
            return FEDietDbContext.Goals.Find(id);
        }

        public decimal GoalSuccessRate(int userid)
        {
            User user=FEDietDbContext.Users.Find(userid);

            decimal weight =(decimal) user.UserDetail.Weight;
            decimal goalweight = user.Goal.DesiredWeight;

            decimal successweight = 100 * (1 - Math.Abs(weight - goalweight)/100);
            return successweight;
        }
    }
}
