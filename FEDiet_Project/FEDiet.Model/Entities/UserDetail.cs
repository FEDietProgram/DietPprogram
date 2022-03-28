using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class UserDetail
    {
        public int ID { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string Job { get; set; }
        public virtual User User { get; set; }
        public decimal GoalCaloriePerDay { get; set; }
        public AgeGroup AgeGroup { get; set; }  

    }
}
