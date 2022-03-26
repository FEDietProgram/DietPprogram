using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class User
    {
        public User()
        {
            Activities = new HashSet<Activity>();     
            Meals = new HashSet<Meal>();
            Waters = new HashSet<Water>();   
            SpecialSituations = new HashSet<SpecialSituation>();
        }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }  
        
        public ICollection<Activity> Activities { get; set; }  
        public ICollection<Meal> Meals { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        public ICollection<Water> Waters{ get; set; }
        public int GoalID { get; set; }
        public virtual Goal Goal { get; set; }
        public ICollection<SpecialSituation> SpecialSituations { get; set; }

    }
}
