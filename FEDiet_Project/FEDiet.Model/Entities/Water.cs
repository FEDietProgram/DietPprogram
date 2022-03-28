using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Water
    {
        public Water()
        {
            Users = new HashSet<User>();
        }
        public int WaterID { get; set; }
        public int Cup { get; set; }
        public DateTime WaterDrinkTime { get; set; } = DateTime.Now;
        public ICollection<User> Users { get; set; }

    }
}
