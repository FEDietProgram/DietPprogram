using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    public class GoalServices
    {
        GoalRepository goalRepository;
        public GoalServices()
        {
            goalRepository = new GoalRepository();
        }


        public List<Goal> ListGoal()
        {
            return goalRepository.ListGoal();
        }

        public Goal GetGoalById(int id)
        {
            return goalRepository.GetGoalById(id);
        }

        //public decimal GoalSuccessRate(int userid)
        //{
        //   return goalRepository.GoalSuccessRate(userid);
        //}

    }
}
