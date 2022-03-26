using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class User:BaseEntity
    {
        public User()
        {
            Activities = new HashSet<Activity>();  
            Foods = new HashSet<Food>();   
            Meals = new HashSet<Meal>();
            Waters = new HashSet<Water>();
        }
        public string Surname { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }  
        
        public ICollection<Activity> Activities { get; set; }  

        public ICollection<Food> Foods { get; set; }//*

        public int GoalID { get; set; } 
        public virtual Goal Goal { get; set; }

        public ICollection<Meal> Meals { get; set; }

        public UserDetail UserDetail { get; set; }

        public ICollection<Water> Waters{ get; set; }

    }
}
