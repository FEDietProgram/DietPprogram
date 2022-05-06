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
            Goals = new HashSet<Goal>();
            Meals = new HashSet<Meal>();
            Waters = new HashSet<Water>();
            Activities = new HashSet<Activity>();
        }
        public int UserID { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public UserType UserType { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<Water> Waters { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }

    }
}
