using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Activity
    {
        public Activity()
        {
            Users = new HashSet<User>();
        }
        public int ActivityID { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityTime { get; set; }
        public double ActivityDuration { get; set; }
        public double BurnedCalory { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
