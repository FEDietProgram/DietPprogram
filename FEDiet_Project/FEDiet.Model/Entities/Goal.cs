using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Goal:BaseEntity
    {
        public Goal()
        {
            Users = new HashSet<User>();   
        }
        public int DesiredWeinght { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
