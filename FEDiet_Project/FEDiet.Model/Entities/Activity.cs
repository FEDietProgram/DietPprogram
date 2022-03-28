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
        public decimal ActivityTime { get; set; }
        public int BurnedCaloriePerHour { get; set; }
        public DateTime ActivityDay { get; set; } = DateTime.Now;
        public ICollection<User> Users { get; set; }
    }
}
