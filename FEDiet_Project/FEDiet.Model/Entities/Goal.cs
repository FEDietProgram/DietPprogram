using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Goal
    {
        public Goal()
        {
            Users = new HashSet<User>();   
        }

        public int GoalID { get; set; }
        public string Name { get; set; }
        public int DesiredWeight { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
